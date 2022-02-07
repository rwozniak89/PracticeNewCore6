
#DB
##in PMC
if with identity
Update-Database

##Add NuGet packages
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Microsoft.EntityFrameworkCore.SqlServer


##SQL
Add-Migration InitialCreate
Update-Database

Add-Migration Rating
Update-Database


