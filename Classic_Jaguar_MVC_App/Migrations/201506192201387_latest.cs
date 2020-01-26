namespace Classic_Jaguar_MVC_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class latest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.models", "DateDeleted", c => c.DateTime());
            AddColumn("dbo.models", "DateCreated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.models", "DateCreated");
            DropColumn("dbo.models", "DateDeleted");
        }
    }
}
