# SmartQA

The starting point of how I have created this project and how it has been referenced
- Run these one by one:
      dotnet new classlib -n SmartQA.Domain
      dotnet new classlib -n SmartQA.Application
      dotnet new classlib -n SmartQA.Infrastructure
      dotnet new webapi -n SmartQA.Api -minimal 

  - Add all projects to the solution
      dotnet sln add SmartQA.Domain/SmartQA.Domain.csproj
      dotnet sln add SmartQA.Application/SmartQA.Application.csproj
      dotnet sln add SmartQA.Infrastructure/SmartQA.Infrastructure.csproj
      dotnet sln add SmartQA.Api/SmartQA.Api.csproj
  This registers them so Visual Studio/Codespace treats them as one solution.
