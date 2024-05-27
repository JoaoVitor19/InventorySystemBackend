# Inventory Management System

Welcome to InventorySystemAPI, a robust inventory management system built using modern development practices and tools.
This API is designed with a focus on scalability, maintainability, and ease of use, making it an ideal project to demonstrate a wide range of skills in software development.

## Features

- **CQRS (Command Query Responsibility Segregation)**: Separates the write and read operations for improved scalability and maintainability.
- **FluentValidation**: Ensures data integrity and business rules compliance with fluent and expressive validation.
- **MediatR**: Implements the mediator pattern to decouple request handling logic.
- **Clean Architecture**: Promotes separation of concerns, making the system easier to maintain and test.
- **EntityFrameworkCore**: Provides a modern data access layer with SQLite(or others) database integration
  
## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- **.NET 8 SDK** (v14.x or later)
- **Visual Studio or Visual Studio Code** (v13.x or later)
- **SQLite**

### Installing

1. **Clone the Repository**

   ```bash
   git clone https://github.com/JoaoVitor19/InventorySystemBackend.git
   cd InventorySystemAPI

2. **Restore the dependencies**
   
   Navigate to the back-end directory, restore the dependencies and run.
   ```bash
    dotnet restore

3. **Apply Migrations and Seed the Database**
   
   Navigate to the front-end directory, install the dependencies and run.
   ```bash
    dotnet ef database update
 
4. **Access the Application**
   ```bash
   dotnet run
