namespace Final_Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetMaxNameLengthOfMovies : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
        }
    }
}
