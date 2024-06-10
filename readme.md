# RPG Character API

Welcome to my RPG Character API project! This is a simple API for managing RPG characters, built using .NET 8 (ASP.NET), Entity Framework 8, and SQL Server. Here, I'll explain what I learned and how I implemented different parts of the project.

## Table of Contents
- [RPG Character API](#rpg-character-api)
  - [Table of Contents](#table-of-contents)
  - [Introduction](#introduction)
  - [Features](#features)
  - [Technologies Used](#technologies-used)
  - [Setup](#setup)
  - [Usage](#usage)
  - [What I Learned](#what-i-learned)
  - [Contact](#contact)

## Introduction
This project is a web API for managing RPG characters. It supports basic CRUD operations (Create, Read, Update, Delete) and is designed to be easy to understand and extend. I created this project to improve my skills in building APIs with .NET 8 and Entity Framework 8.

## Features
- Create, read, update, and delete RPG characters.
- Attribute routing for flexible and clean API endpoints.
- Asynchronous operations for better performance.
- Data Transfer Objects (DTOs) to ensure a clean separation between API and database models.
- AutoMapper for easy and reliable object mapping.

## Technologies Used
- .NET 8
- Entity Framework 8
- SQL Server Express
- Visual Studio Code

## Setup
1. **Clone the repository**
   ```bash
    git clone https://github.com/mishodzuliashvili/dotnet-rpg.git
    cd dotnet-rpg
   ```
2. **Build with Docker and run**
   ```bash
    docker build -t dotnet-rpg .
    docker run -d -p 8080:8080 dotnet-rpg
   ```

## Usage
- **GET /api/character**: Retrieve all characters.
- **GET /api/character/{id}**: Retrieve a specific character by ID.
- **POST /api/character**: Create a new character.
- **PUT /api/character/{id}**: Update an existing character.
- **DELETE /api/character/{id}**: Delete a character.
- See the Swagger documentation for more details on the API endpoints.

## What I Learned
- **Creating a Web API with .NET 8**: I learned how to set up a new Web API project using .NET 8.
- **Entity Framework 8**: I implemented data access using Entity Framework 8 with a Code-First approach, including migrations to manage the database schema.
- **Routing and HTTP Methods**: I used attribute routing to define API endpoints and understood the use of different HTTP methods (GET, POST, PUT, DELETE).
- **Asynchronous Programming**: I learned to implement asynchronous operations in API methods to improve performance.
- **Service Layer**: I separated business logic into a service layer, making the code cleaner and more maintainable.
- **DTOs and AutoMapper**: I used Data Transfer Objects and AutoMapper to simplify data handling and ensure a clean separation between API models and database models.

## Contact
If you have any questions or suggestions, feel free to contact me at [dzuliashvilimikheil9@gmail.com].

---

Thank you for checking out my RPG Character API project! I hope you find it useful and easy to understand. If you have any feedback, I'd love to hear from you!