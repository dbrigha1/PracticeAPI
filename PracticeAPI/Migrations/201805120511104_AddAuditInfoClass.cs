namespace PracticeAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuditInfoClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PracticeEntities", "UserId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PracticeEntities", "UserId");
        }
    }
}
