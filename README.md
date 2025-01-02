# EF_CodeFirstApproach

This project demonstrates the **Entity Framework Core (EF Core) Code First Approach**. It focuses on creating a database from C# model classes, allowing developers to design the database schema using C# code.

## Project Overview

The **Code First Approach** allows developers to define their database schema using classes in C#. EF Core will generate the corresponding database tables based on these model classes. This is ideal for projects where the database schema is not pre-existing, and you want to have full control over your data models.

### Key Features:
- **Model Classes**: Defines the database tables and relationships.
- **Migrations**: EF Core migrations allow easy updates to the database schema based on changes in the model classes.
- **DbContext**: Central class for managing the database connection and providing access to entities.

## Getting Started

### Step-by-Step Guide

#### Step 1: Install Necessary NuGet Packages
Install the following NuGet packages via NuGet Package Manager or Package Manager Console:
- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore`
- `Microsoft.EntityFrameworkCore.Tools`
- `Microsoft.EntityFrameworkCore.Design`

These packages are required to enable Entity Framework Core functionality in your project.

#### Step 2: Create Model Classes
Define your model classes that represent the tables in the database. These classes should include the properties that map to the columns in the corresponding table.

#### Step 3: Create a DbContext Class
Create a `DbContext` class that will manage the database connection and provide access to your model classes. This class should inherit from `DbContext`, and you should define a property for each model class you want to interact with.

#### Step 4: Create a Connection String in `appsettings.json`
In the `appsettings.json` file, add a connection string that specifies how to connect to your database (e.g., SQL Server, SQLite). This string will be used by the `DbContext` class to establish a connection to the database.

#### Step 5: Register the Connection String in `Program.cs`
In your `Program.cs` (or `Startup.cs`), register the `DbContext` with the configured connection string. This tells Entity Framework Core how to use the connection to interact with the database.

#### Step 6: Run Migrations Using the Package Manager Console
Use the **Package Manager Console** in Visual Studio to run migrations. Follow these steps:
- **Add a Migration**: This will create a migration file based on the changes in your model classes.
- **Update the Database**: Apply the migration to your database, which will create or update the database schema to match your model classes.

### Project Structure

- **Model Classes**: Defines the database schema.
- **DbContext**: Handles data access.
- **Migrations**: Keeps track of changes to the database schema.

## Technologies Used
- C#
- Entity Framework Core (EF Core)
- SQL Server

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
