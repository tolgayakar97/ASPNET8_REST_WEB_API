In order to use Entity Framework in the project:
"Microsoft.EntityFrameworkCore"
"Microsoft.EntityFrameworkCore.SqlServer"
"Microsoft.EntityFrameworkCore.Tools"
NuGet packages are needed.

To create migration:
1. Add proper ConnectionString to the appsettings.json 
2. Open Package Manager Console
3. Type "Add-Migration <Migration Name>"
4. Type Update-Database