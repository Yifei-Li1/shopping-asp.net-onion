namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Menufacture = c.String(),
                        Category = c.String(),
                        Description = c.String(),
                        Series = c.String(),
                        Model = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubCategory = c.String(),
                        DateMenufactured = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
            DropTable("dbo.Product");
        }
    }
}
