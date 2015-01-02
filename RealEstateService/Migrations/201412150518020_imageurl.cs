namespace RealEstateService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imageurl : DbMigration
    {
        public override void Up()
        {
            AddColumn("RealEstateService.Images", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("RealEstateService.Images", "ImageUrl");
        }
    }
}
