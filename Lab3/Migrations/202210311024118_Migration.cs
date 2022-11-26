namespace CD_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hotels", "Rooms", c => c.Int());
        }

        public override void Down()
        {
            DropColumn("dbo.Hotels", "Rooms");
        }
    }
}