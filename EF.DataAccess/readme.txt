(1) Enable-Migrations:

Enable-Migrations -ContextTypeName BreakAwayContext -MigrationsDirectory MigrationsBaga
Enable-Migrations -ContextTypeName EF.DataAccess.Contexts.BreakAwayContextFluent -MigrationsDirectory MigrationsBagaFluent
Enable-Migrations -ContextTypeName PoetryModelContext -MigrationsDirectory Migrations\Poetry
Enable-Migrations -ContextTypeName AlbumContext -MigrationsDirectory Migrations\Albums

(2) Add first migration:
Add-Migration -ConfigurationTypeName EF.DataAccess.MigrationsBaga.Configuration Migration0
Add-Migration -ConfigurationTypeName EF.DataAccess.MigrationsBagaFluent.Configuration Migration0
Add-Migration -ConfigurationTypeName EF.DataAccess.Migrations.Poetry.Configuration Migration0
Add-Migration -ConfigurationTypeName EF.DataAccess.Migrations.Albums.Configuration Migration0

Update-DataBase -ConfigurationTypeName EF.DataAccess.MigrationsBaga.Configuration -TargetMigration ...
Update-DataBase -ConfigurationTypeName EF.DataAccess.MigrationsBagaFluent.Configuration
Update-DataBase -ConfigurationTypeName EF.DataAccess.Migrations.Poetry.Configuration
Update-DataBase -ConfigurationTypeName EF.DataAccess.Migrations.Albums.Configuration