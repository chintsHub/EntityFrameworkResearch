This project is based upon the articles -:
http://www.dotnet-tricks.com/Tutorial/entityframework/2VOa140214-Entity-Framework-6-Code-First-Migrations-with-Multiple-Data-Contexts.html




Following code first commands are used -:

add-migration -configuration CodeFirst.AdminContextMigrations.AdminMigrationConfig Initial
update-Database -configuration  CodeFirst.AdminContextMigrations.AdminMigrationConfig -ConnectionString "Integrated Security=SSPI;Pooling=false;Data Source=BEAK\CHINTSSQL2012;Initial Catalog=ef4" -ConnectionProviderName "System.Data.SqlClient" -Verbose

add-migration -configuration CodeFirst.CustomerContextMigrations.Configuration Initial
update-Database -configuration  CodeFirst.CustomerContextMigrations.Configuration -ConnectionString "Integrated Security=SSPI;Pooling=false;Data Source=BEAK\CHINTSSQL2012;Initial Catalog=ef4" -ConnectionProviderName "System.Data.SqlClient" -Verbose