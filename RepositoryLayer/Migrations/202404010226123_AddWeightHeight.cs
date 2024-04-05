namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWeightHeight : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Weight", c => c.Int(nullable: false));
            AddColumn("dbo.Product", "Height", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "Height");
            DropColumn("dbo.Product", "Weight");
        }
    }
}
