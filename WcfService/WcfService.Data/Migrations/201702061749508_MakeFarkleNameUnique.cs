namespace WcfService.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeFarkleNameUnique : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Farkles", "Name", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Farkles", "Name", unique: true, name: "UQ_Farkle_Name");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Farkles", "UQ_Farkle_Name");
            AlterColumn("dbo.Farkles", "Name", c => c.String(nullable: false));
        }
    }
}
