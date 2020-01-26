namespace Classic_Jaguar_MVC_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lastMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.models", "FirstYear", c => c.Int());
            AlterColumn("dbo.models", "LastYear", c => c.Int());
            AlterColumn("dbo.models", "UnitsProduced", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.models", "UnitsProduced", c => c.Int(nullable: false));
            AlterColumn("dbo.models", "LastYear", c => c.Int(nullable: false));
            AlterColumn("dbo.models", "FirstYear", c => c.Int(nullable: false));
        }
    }
}
