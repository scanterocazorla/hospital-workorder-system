# Hospital Work Order Management System

Software engineering project developed as part of a university course.

The system manages hospital work orders and basic operational tasks using a layered architecture.
It demonstrates the use of separation of concerns between business logic, persistence, and user interface.

## Architecture

The application follows a **layered architecture**:

* **Business Logic Layer** – Implements the core functionality and system rules.
* **Persistence Layer** – Handles database access using **Entity Framework**.
* **Database Layer** – Stores system data and entities.
* **User Interface** – Simple interface for interacting with the system.

This structure allows the application to remain modular, maintainable, and scalable.

## Technologies

* C#
* .NET
* Entity Framework
* SQL Database
* Layered Architecture

## Project Structure

```
ProyectoPracticas
│
├── ClassLibrary                # Core domain and shared components
├── ManteHosApp                 # Main application
├── DBTest                      # Database related tests
├── ManteHosObjectDesignTest    # Object design tests
└── ManteHosPersistenceTests    # Persistence layer tests
```

## Team Project

This project was developed collaboratively by a team of **four students** as part of the Software Engineering course.

The goal of the assignment was to design and implement a modular system using good software engineering practices such as layered architecture, separation of concerns, and database persistence.

## Purpose

The project focuses on demonstrating:

* software architecture design
* modular application structure
* integration of persistence with Entity Framework
* collaborative software development practices
