namespace Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaskAssignment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "AssignTo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "AssignTo");
        }
    }
}
