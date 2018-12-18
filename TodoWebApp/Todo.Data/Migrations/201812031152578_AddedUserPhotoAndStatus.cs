namespace Todo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserPhotoAndStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "UserPhoto", c => c.String(nullable: false));
            AddColumn("dbo.Tasks", "Status", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Status");
            DropColumn("dbo.Tasks", "UserPhoto");
        }
    }
}
