# The Simple Shop Backend

## Overview
A .NET 9 Web API backend service for The Simple Shop e-commerce platform, implementing clean architecture principles with CQRS pattern using MediatR.

## Prerequisites
- Visual Studio 2022 (17.9.0 or later)
- .NET 9.0 SDK
- SQL Server 2022 or later
- SQL Server Management Studio (SSMS) 19.0 or later

## Dependencies
Key NuGet packages used:
- Microsoft.AspNetCore.OpenApi (9.0.1)
- Microsoft.EntityFrameworkCore (9.0.1)
- Microsoft.EntityFrameworkCore.SqlServer (9.0.1)
- Microsoft.EntityFrameworkCore.Tools (9.0.1)
- Microsoft.Extensions.Logging (9.0.1)
- MediatR (12.4.1)
- Scalar.AspNetCore (2.0.5)

## Getting Started

### Database Setup
1. Open SQL Server Management Studio
2. Connect to your local SQL Server instance
3. The connection string in `appsettings.json` uses Windows Authentication by default
4. Update the connection string if using a different authentication method

### Running Locally
1. Open Visual Studio 2022
2. Open the solution file `SimpleShopBackEnd/TheSimpleShopApi.sln`
3. Right-click on the solution in Solution Explorer and select "Restore NuGet Packages"
4. In Package Manager Console, run:
    ```
    Update-Database
    ```
5. Set `TheSimpleShopApi` as the startup project
6. Press F5 or click the "Start Debugging" button
7. The API will launch at http://localhost:5187 by default

## API Documentation
Once running, the Scalar documentation is available at:
- http://localhost:5187/scalar/v1

---

*Note: This README was generated using GitHub Copilot. While the information is accurate, it's recommended to verify the steps and requirements for your specific environment.*