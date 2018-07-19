namespace Sandbox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bottles", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bottles", "Cost");
        }
    }
}
