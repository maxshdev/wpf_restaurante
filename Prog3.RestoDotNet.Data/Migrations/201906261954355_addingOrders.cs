namespace Prog3.RestoDotNet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingOrders : DbMigration
    {
        public override void Up()
        {
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
            
            AddColumn("Resto.Meals", "OrderId", c => c.Int(nullable: false));
            CreateIndex("Resto.Meals", "OrderId");
            AddForeignKey("Resto.Meals", "OrderId", "Resto.Orders", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Resto.Meals", "OrderId", "Resto.Orders");
            DropForeignKey("Resto.Orders", "WaiterId", "Resto.Waiters");
            DropForeignKey("Resto.Orders", "TableId", "Resto.Tables");
            DropIndex("Resto.Orders", new[] { "WaiterId" });
            DropIndex("Resto.Orders", new[] { "TableId" });
            DropIndex("Resto.Meals", new[] { "OrderId" });
            DropColumn("Resto.Meals", "OrderId");
            DropTable("Resto.Orders");
        }
    }
}
