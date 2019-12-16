namespace course_manage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create01 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SideBars", "Name", c => c.String(maxLength: 30));
            AlterColumn("dbo.SideBars", "Controller", c => c.String(maxLength: 30));
            AlterColumn("dbo.SideBars", "Action", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SideBars", "Action", c => c.String(maxLength: 10));
            AlterColumn("dbo.SideBars", "Controller", c => c.String(maxLength: 10));
            AlterColumn("dbo.SideBars", "Name", c => c.String(maxLength: 10));
        }
    }
}
