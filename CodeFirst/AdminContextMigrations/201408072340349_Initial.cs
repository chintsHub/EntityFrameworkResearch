namespace CodeFirst.AdminContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoldeId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RoldeId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        MyRole_RoldeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Roles", t => t.MyRole_RoldeId, cascadeDelete: true)
                .Index(t => t.MyRole_RoldeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "MyRole_RoldeId", "dbo.Roles");
            DropIndex("dbo.Users", new[] { "MyRole_RoldeId" });
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
        }
    }
}
