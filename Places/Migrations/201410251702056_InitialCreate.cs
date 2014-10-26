namespace Places.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.County",
                c => new
                {
                    CountyID = c.Int(nullable: false, identity: true),
                    CountyName = c.String(),
                })
                .PrimaryKey(t => t.CountyID);
        }
        
        public override void Down()
        {
        }
    }
}
