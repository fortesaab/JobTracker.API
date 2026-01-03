using JobTracker.API.Data;
using JobTracker.API.DTOs;
using JobTracker.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class JobApplicationsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public JobApplicationsController(AppDbContext context)
        {
            _context = context;
        }

        // GET /api/JobApplications?page=0&pageSize=10&status=pending
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobApplicationDto>>> GetAll(
            [FromQuery] int page = 0,
            [FromQuery] int pageSize = 10,
            [FromQuery] string? status = null)
        {
            var query = _context.JobApplications.AsQueryable();

            if (!string.IsNullOrEmpty(status))
                query = query.Where(j => j.Status == status);

            var result = await query
                .Skip(page * pageSize)
                .Take(pageSize)
                .Select(j => new JobApplicationDto
                {
                    JobTitle = j.JobTitle,
                    Company = j.Company,
                    AppliedOn = j.AppliedOn,
                    UserId = j.UserId,
                    Status = j.Status
                })
                .ToListAsync();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<JobApplicationDto>> GetById(int id)
        {
            var job = await _context.JobApplications.FindAsync(id);
            if (job == null) return NotFound();

            return Ok(new JobApplicationDto
            {
                JobTitle = job.JobTitle,
                Company = job.Company,
                AppliedOn = job.AppliedOn,
                UserId = job.UserId,
                Status = job.Status
            });
        }

        [HttpPost]
        public async Task<ActionResult<JobApplicationDto>> Create(JobApplicationDto dto)
        {
            var job = new JobApplication
            {
                JobTitle = dto.JobTitle,
                Company = dto.Company,
                AppliedOn = DateTime.UtcNow,
                UserId = dto.UserId,
                Status = dto.Status
            };

            _context.JobApplications.Add(job);
            await _context.SaveChangesAsync();

            dto.AppliedOn = job.AppliedOn;

            return CreatedAtAction(nameof(GetById), new { id = job.Id }, dto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, JobApplicationDto dto)
        {
            var job = await _context.JobApplications.FindAsync(id);
            if (job == null) return NotFound();

            job.JobTitle = dto.JobTitle ?? job.JobTitle;
            job.Company = dto.Company ?? job.Company;
            job.Status = dto.Status ?? job.Status;
            job.UserId = dto.UserId != 0 ? dto.UserId : job.UserId;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var job = await _context.JobApplications.FindAsync(id);
            if (job == null) return NotFound();

            _context.JobApplications.Remove(job);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
