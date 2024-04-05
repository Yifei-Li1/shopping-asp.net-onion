namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "ImageLink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "ImageLink");
        }
    }
}
