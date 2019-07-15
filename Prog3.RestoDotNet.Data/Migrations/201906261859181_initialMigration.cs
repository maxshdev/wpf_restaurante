namespace Prog3.RestoDotNet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Resto.Chairs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsAvailable = c.Boolean(nullable: false),
                        TableId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Resto.Tables", t => t.TableId, cascadeDelete: true)
                .Index(t => t.TableId);
            
            CreateTable(
                "Resto.Tables",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Description = c.String(),
                        State = c.Int(nullable: false),
                        Shape = c.Int(nullable: false),
                        MaxChairs = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Resto.Meals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Resto.Waiters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Resto.Chairs", "TableId", "Resto.Tables");
            DropIndex("Resto.Chairs", new[] { "TableId" });
            DropTable("Resto.Waiters");
            DropTable("Resto.Meals");
            DropTable("Resto.Tables");
            DropTable("Resto.Chairs");
        }
    }
}
