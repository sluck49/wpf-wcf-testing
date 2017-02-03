namespace WcfService.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGroobs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        FarkleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Farkles", t => t.FarkleId, cascadeDelete: true)
                .Index(t => t.FarkleId);
            
            AlterColumn("dbo.Farkles", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Groobs", "FarkleId", "dbo.Farkles");
            DropIndex("dbo.Groobs", new[] { "FarkleId" });
            AlterColumn("dbo.Farkles", "Name", c => c.String());
            DropTable("dbo.Groobs");
        }
    }
}
