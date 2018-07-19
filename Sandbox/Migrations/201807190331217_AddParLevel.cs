namespace Sandbox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddParLevel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bottles", "ParLevel", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bottles", "ParLevel");
        }
    }
}
