namespace EF.DataAccess.Migrations.Albums
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "alb.PictureCategories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ParentCategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryId)
                .ForeignKey("alb.PictureCategories", t => t.ParentCategoryId)
                .Index(t => t.ParentCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("alb.PictureCategories", "ParentCategoryId", "alb.PictureCategories");
            DropIndex("alb.PictureCategories", new[] { "ParentCategoryId" });
            DropTable("alb.PictureCategories");
        }
    }
}
