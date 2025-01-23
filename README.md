# Pilot API

A .NET 6 Web API project implementing Clean Architecture principles for managing football/soccer matches, teams, players, and referees.

## 🏗️ Project Structure

The solution follows Clean Architecture principles with these main projects:

```bash
pilot-API/
├── src/
│ ├── Pilot.API # API Controllers and configuration
│ ├── Pilot.Application # Application business logic
│ ├── Pilot.Domain # Domain entities and business rules
│ └── Pilot.Infrastructure# Data access and external services
```

## 🛠️ Technology Stack

- **.NET 6**
- **Entity Framework Core 6.0**
- **MediatR** for CQRS pattern implementation
- **FluentValidation** for request validation
- **SQL Server** as the database
- **Swagger/OpenAPI** for API documentation

## 🏛️ Architecture

This project implements Clean Architecture with:

- **Domain Layer**: Contains all entities, enums, exceptions, interfaces, types and logic specific to the domain.
- **Application Layer**: Contains all application logic. Depends on the domain layer.
- **Infrastructure Layer**: Contains all external concerns like database configuration, migrations, etc.
- **API Layer**: Contains all API configuration and controllers.

## 📊 Domain Model

The API manages these main entities:

- **Match**: Represents a football match
- **Team**: Represents a football team
- **Player**: Represents a team player
- **Referee**: Represents a match referee
- **Competition**: Represents a football competition
- **Language**: Represents languages spoken by referees

## 🚀 Getting Started

### Prerequisites

- .NET 6 SDK
- SQL Server
- Visual Studio 2022 or VS Code

### Database Configuration

The project is configured to use SQL Server. Update the connection string in `src/Pilot.API/appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(LocalDb)\\MSSQLLocalDB;Database=pilot_db;Integrated Security=True;"
  }
}
```

### Running the Application

1. Clone the repository
2. Navigate to the solution directory
3. Run the following commands:

```bash
dotnet restore
dotnet build
dotnet run --project src/Pilot.API/Pilot.API.csproj
```

The API will be available at `https://localhost:7092/swagger`

## 🔄 Current Status

This is a work in progress. Currently implemented:

- ✅ Basic project structure
- ✅ Entity configurations
- ✅ Database context and migrations
- ✅ Basic dependency injection setup
- ✅ Initial domain models
- 🚧 API endpoints (in progress)
- 🚧 Business logic implementation (in progress)
- 🚧 Authentication and authorization (pending)

## 📝 License

[MIT License](LICENSE)

## 🤝 Contributing

Contributions, issues and feature requests are welcome!
