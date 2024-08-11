# REST API ASP.NET Core 8
Swagger UI is used.

In order to use Entity Framework in the project:
"Microsoft.EntityFrameworkCore"
"Microsoft.EntityFrameworkCore.SqlServer"
"Microsoft.EntityFrameworkCore.Tools"
NuGet packages should be installed.

To create migration after creating DataContext:
1. Add proper ConnectionString to the appsettings.json 
2. Open Package Manager Console
3. Type "Add-Migration <Migration Name>"
4. Type Update-Database
