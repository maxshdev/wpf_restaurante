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
                        Id = c.Int(nullable: false, identity: true),
                        Caption = c.String(maxLength: 50),
                        BoundedMapId = c.Guid(nullable: false),
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
                        OrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Resto.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
            CreateTable(
                "Resto.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateFrom = c.DateTime(nullable: false),
                        DateTo = c.DateTime(),
                        Obs = c.String(),
                        TableId = c.Int(nullable: false),
                        WaiterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Resto.Tables", t => t.TableId, cascadeDelete: true)
                .ForeignKey("Resto.Waiters", t => t.WaiterId, cascadeDelete: true)
                .Index(t => t.TableId)
                .Index(t => t.WaiterId);
            
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
            DropForeignKey("Resto.Meals", "OrderId", "Resto.Orders");
            DropForeignKey("Resto.Orders", "WaiterId", "Resto.Waiters");
            DropForeignKey("Resto.Orders", "TableId", "Resto.Tables");
            DropForeignKey("Resto.Chairs", "TableId", "Resto.Tables");
            DropIndex("Resto.Orders", new[] { "WaiterId" });
            DropIndex("Resto.Orders", new[] { "TableId" });
            DropIndex("Resto.Meals", new[] { "OrderId" });
            DropIndex("Resto.Chairs", new[] { "TableId" });
            DropTable("Resto.Waiters");
            DropTable("Resto.Orders");
            DropTable("Resto.Meals");
            DropTable("Resto.Tables");
            DropTable("Resto.Chairs");
        }
    }
}
