namespace Sandbox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBottleType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BottleTypes",
                c => new
                    {
                        BottleTypeID = c.Int(nullable: false, identity: true),
                        BottleTypeName = c.String(),
                    })
                .PrimaryKey(t => t.BottleTypeID);
            
            AddColumn("dbo.Bottles", "BottleType_BottleTypeID", c => c.Int());
            CreateIndex("dbo.Bottles", "BottleType_BottleTypeID");
            AddForeignKey("dbo.Bottles", "BottleType_BottleTypeID", "dbo.BottleTypes", "BottleTypeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bottles", "BottleType_BottleTypeID", "dbo.BottleTypes");
            DropIndex("dbo.Bottles", new[] { "BottleType_BottleTypeID" });
            DropColumn("dbo.Bottles", "BottleType_BottleTypeID");
            DropTable("dbo.BottleTypes");
        }
    }
}
