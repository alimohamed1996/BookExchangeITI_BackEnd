namespace Final_Project_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixedrelationuserwantbook : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BookUsers", newName: "User_Want_Book");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.User_Want_Book", newName: "BookUsers");
        }
    }
}
