namespace EF.DataAccess.Migrations.Poetry
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Poems", "Poet_PoetId", c => c.Int());
            CreateIndex("dbo.Poems", "Poet_PoetId");
            AddForeignKey("dbo.Poems", "Poet_PoetId", "dbo.Poets", "PoetId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Poems", "Poet_PoetId", "dbo.Poets");
            DropIndex("dbo.Poems", new[] { "Poet_PoetId" });
            DropColumn("dbo.Poems", "Poet_PoetId");
        }
    }
}
