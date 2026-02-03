JobTracker – Full-Stack Job Application Tracking System

JobTracker is a full-stack web application designed to help users track and manage their job applications in one centralized platform.

The project demonstrates practical, real-world backend and frontend development skills, including secure authentication, clean REST API design, and clear separation of concerns.

It was built as a personal project to strengthen full-stack engineering skills and showcase readiness for junior or internship software developer roles.

What the Project Does

Allows users to register and log in securely

Enables users to create, update, and manage job applications

Tracks application status (Pending, Accepted, Rejected)

Protects user data through authentication and authorization

Ensures users can access only their own data

Provides a simple and clean dashboard interface

Why This Project Matters

This project was built to simulate real-world application logic and development workflows.

It focuses on:

Secure authentication and authorization

Clean and scalable REST API architecture

Practical CRUD operations

Frontend–backend communication

Code organization and maintainability

Key Features

Authentication & Security

User registration and login

JWT-based authentication

Protected API endpoints

Secure access to user-specific data

Job Application Management

Create, update, and delete job applications

Filter applications by status

Pagination support

User-specific data isolation

Frontend

React-based user interface

Login and registration forms

Protected routes

Simple dashboard layout

Dark / light mode support

Tech Stack

Backend

.NET 8

Entity Framework Core

MSSQL

JWT Authentication

Frontend

React

Axios

Tools & Practices

Git & GitHub

RESTful API design

Clean code principles

Separation of concerns

Project Structure

JobTracker.API

Controllers – API endpoints

Models – Database entities

DTOs – Data transfer objects

Data – DbContext & configuration

Migrations – EF Core migrations

Program.cs

appsettings.json

How to Run the Project

Backend

Open the project in Visual Studio

Configure the database connection in appsettings.json

Run migrations

Add-Migration InitialCreate

Update-Database

Run the API

Open Swagger at http://localhost:5211/swagger

Frontend

Navigate to the frontend directory

Install dependencies

npm install

Start the application

npm start
