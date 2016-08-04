namespace EF.DataAccess.Migrations.Poetry
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Poems", "MeterId");
            AddForeignKey("dbo.Poems", "MeterId", "dbo.Meters", "MeterId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Poems", "MeterId", "dbo.Meters");
            DropIndex("dbo.Poems", new[] { "MeterId" });
        }
    }
}
