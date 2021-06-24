# StandardAUTest

StandardAUTest:
Build with build-in Microsoft ASP.NET CORE with React Template

How to run:
server : dotnet run or just click start debugging from VS  - running on localhost:44347
frontend: npm start    - localhost:3000

Backend Structure:

StandardsAUTest
- Endpoints, Configs, DIs
- ClientApp

StandardsAUTest.Domain
- POCOs, DTOs, ViewModels, Constants
- Interfaces

StandardsAUTest.Infrastructure
- DataAccess, Seeding, DbConfig, Migrations

StandardsAUTest.Application
- Implmention of contracts, service & repo implementation
- ViewModel Validations

TODOs:
- Add Middleware to handle global exceptions and map status
- Add more stylings to frontend page
- Implement AutoMapper to make code more clean when mapping
- Separte ClientApp out from StandardAUTest project
- Add more validations on frontend for all fields
