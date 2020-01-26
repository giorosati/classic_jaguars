namespace Classic_Jaguar_MVC_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class transactions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.transactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        ModelID = c.Int(nullable: false),
                        TransType = c.Int(nullable: false),
                        SalePrice = c.Int(nullable: false),
                        DateSold = c.DateTime(nullable: false),
                        SellerName = c.String(),
                        SellerCountry = c.String(),
                        BuyerName = c.String(),
                        BuyerCountry = c.String(),
                        CarYear = c.Int(nullable: false),
                        ExtColor = c.String(),
                        IntColor = c.String(),
                        CarMiles = c.Int(nullable: false),
                        NumsMatch = c.Boolean(nullable: false),
                        notes = c.String(),
                    })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.cars", t => t.ModelID, cascadeDelete: true)
                .Index(t => t.ModelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.transactions", "ModelID", "dbo.cars");
            DropIndex("dbo.transactions", new[] { "ModelID" });
            DropTable("dbo.transactions");
        }
    }
}
