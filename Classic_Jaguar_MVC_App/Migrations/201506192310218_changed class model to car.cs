namespace Classic_Jaguar_MVC_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedclassmodeltocar : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.models", newName: "cars");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.cars", newName: "models");
        }
    }
}
