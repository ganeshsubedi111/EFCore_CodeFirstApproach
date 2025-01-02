# EF_CodeFirstApproach

This project demonstrates the **Entity Framework Core (EF Core) Code First Approach**. It focuses on creating a database from C# model classes, allowing developers to design the database schema using C# code.

## Project Overview

The **Code First Approach** allows developers to define their database schema using classes in C#. EF Core will generate the corresponding database tables based on these model classes. This is ideal for projects where the database schema is not pre-existing, and you want to have full control over your data models.

### Key Features:
- **Model Classes**: Defines the database tables and relationships.
- **Migrations**: EF Core migrations allow easy updates to the database schema based on changes in the model classes.
- **DbContext**: Central class for managing the database connection and providing access to entities.

## Getting Started

### Prerequisites
- Install [Visual Studio](https://visualstudio.microsoft.com/) (or any other IDE supporting EF Core).
- Install [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) in your project.

### Setup Instructions
1. Clone this repository to your local machine.
2. Open the project in your preferred development environment.
3. Run the EF Core migrations to create the database.

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
