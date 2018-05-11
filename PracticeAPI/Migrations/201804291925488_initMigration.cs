namespace PracticeAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PracticeEntities",
                c => new
                    {
                        PracticeId = c.Int(nullable: false, identity: true),
                        PracticeName = c.String(),
                    })
                .PrimaryKey(t => t.PracticeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PracticeEntities");
        }
    }
}
