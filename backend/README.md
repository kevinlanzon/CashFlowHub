# CashFlowHub Backend

This is the .NET 10 backend scaffold for CashFlowHub using vertical slice architecture, CQRS, and Event Sourcing with Marten.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) installed
- (Optional) Docker if using containers for database or other services

## Build and Run

From the `backend/` folder:

# Restore NuGet packages
dotnet restore CashFlowHub.sln

# Build all projects
dotnet build CashFlowHub.sln

# Run the API project
dotnet run --project Api/CashFlowHub.ApiThe API will start and be available at:
- **HTTPS**: `https://localhost:7083`
- **HTTP**: `http://localhost:5125`

### Development Mode with Hot Reload

For automatic reloading on code changes:

dotnet watch run --project Api/CashFlowHub.Api## Running Tests

From the `backend/` folder:

# Run all tests
dotnet test

# Run just the Domain tests
dotnet test --filter "FullyQualifiedName~Domain.Events"

# Run with verbose output to see what's happening
dotnet test --logger "console;verbosity=detailed"## Notes

## Notes

- The project currently uses the default ASP.NET Core Web API template
- Domain layer: AccountCreated event implemented ✅
- Application and Infrastructure layers are scaffolded but not yet implemented
- All projects target .NET 10.0
- Nullable reference types are enabled across all projects
