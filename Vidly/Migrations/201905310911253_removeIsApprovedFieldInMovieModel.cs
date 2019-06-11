namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeIsApprovedFieldInMovieModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "IsApproved");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "IsApproved", c => c.Int(nullable: false));
        }
    }
}
