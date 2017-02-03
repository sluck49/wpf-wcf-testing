namespace WcfService.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsFarkedColumnToFarkle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Farkles", "IsFarked", c => c.Boolean(nullable: false, defaultValue:true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Farkles", "IsFarked");
        }
    }
}
