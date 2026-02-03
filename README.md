JobTracker – Full-Stack Job Application Tracking System

JobTracker is a full-stack web application that helps users track and manage their job applications in one place.

The project demonstrates real-world backend and frontend development, secure authentication, and clean API design.

This is a personal project built to strengthen full-stack skills and showcase readiness for junior / internship software developer roles.


What This Project Does?

Allows users to register and log in securely

Enables users to create and manage job applications

Tracks application status (Pending, Accepted, Rejected)

Protects sensitive data using JWT authentication

Separates backend and frontend responsibilities clearly

Provides a simple, clean dashboard UI


Why This Project Matters?

This project was built to simulate real-world application logic.

It focuses on:

Secure authentication & authorization

Clean REST API architecture

Practical CRUD operations

Frontend–backend communication

Code organization and scalability


Key Features

Authentication & Security

	User registration and login
	
	JWT-based authentication
	
	Protected API endpoints
	
	Secure access to user-specific data
	
Job Application Management

	Create, update, delete job applications
	
	Filter applications by status
	
	Pagination support
	
	User-specific data isolation

Frontend

	React-based UI
	
	Login & register forms
	
	Protected routes
	
	Simple dashboard layout
	
	Dark / light mode support
	

Tech Stack

Backend: 

.NET 8, 

Entity Framework Core, 

MSSQL, 

JWT authentication.

Frontend: 

React, 

Axios


Tools & Practices

Git & GitHub

RESTful API design

Clean code principles

Separation of concerns


Project Structure

JobTracker.API
│
├── Controllers        # API endpoints

├── Models             # Database entities

├── DTOs               # Data transfer objects

├── Data               # DbContext & configuration

├── Migrations         # EF Core migrations

├── Program.cs

└── appsettings.json


How to Run the Project

Backend: 

Open the project in Visual Studio, 

Configure the database connection in appsettings.json,

Run migrations:

Add-Migration InitialCreate

Update-Database

Run the API

Open Swagger: http://localhost:5211/swagger

Frontend: 

Navigate to the frontend directory, install dependencies:

npm install

And start the app:

npm start
