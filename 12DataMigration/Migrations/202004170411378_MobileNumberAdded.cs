namespace _12DataMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MobileNumberAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "MobileNo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "MobileNo");
        }
    }
}
