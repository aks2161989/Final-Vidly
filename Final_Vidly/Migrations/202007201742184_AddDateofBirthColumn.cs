namespace Final_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateofBirthColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "DateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "DateOfBirth");
        }
    }
}
