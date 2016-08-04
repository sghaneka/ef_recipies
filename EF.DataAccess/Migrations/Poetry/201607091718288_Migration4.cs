namespace EF.DataAccess.Migrations.Poetry
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Poems", "Poet_PoetId", "dbo.Poets");
            AddForeignKey("dbo.Poems", "Poet_PoetId", "dbo.Poets", "PoetId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Poems", "Poet_PoetId", "dbo.Poets");
            AddForeignKey("dbo.Poems", "Poet_PoetId", "dbo.Poets", "PoetId", cascadeDelete: true);
        }
    }
}
