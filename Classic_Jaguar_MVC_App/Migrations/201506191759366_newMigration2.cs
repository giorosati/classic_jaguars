namespace Classic_Jaguar_MVC_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.models",
                c => new
                    {
                        ModelId = c.Int(nullable: false, identity: true),
                        ModelName = c.String(nullable: false),
                        FirstYear = c.Int(nullable: false),
                        LastYear = c.Int(nullable: false),
                        UnitsProduced = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                        Synopsis = c.String(),
                        ImgUrl = c.String(),
                    })
                .PrimaryKey(t => t.ModelId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.models");
        }
    }
}
