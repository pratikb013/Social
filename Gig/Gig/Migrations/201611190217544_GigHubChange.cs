namespace Gig.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GigHubChange : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Gigs", newName: "GigHubs");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.GigHubs", newName: "Gigs");
        }
    }
}
