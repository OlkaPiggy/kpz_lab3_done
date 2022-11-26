namespace CD_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
               CreateTable(
                "dbo.Hotels",
                c => new
                {
                    Id = c.Int(),
                    Name = c.String(),
                    Address = c.String(),
                    Price = c.Int(),
                    Type = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);

        }

        public override void Down()
        {
            DropIndex("dbo.Hotels", new[] { "Id" });
            DropTable("dbo.Hotels");
        }
    }
}
