namespace Sandbox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bottles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BottleName = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Volume = c.Int(nullable: false),
                        OnHand = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bottles");
        }
    }
}
