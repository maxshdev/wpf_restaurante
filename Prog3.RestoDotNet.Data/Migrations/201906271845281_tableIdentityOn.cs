namespace Prog3.RestoDotNet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tableIdentityOn : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Resto.Chairs", "TableId", "Resto.Tables");
            DropPrimaryKey("Resto.Tables");
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
            
            AddColumn("Resto.Tables", "Caption", c => c.String(maxLength: 50));
            AddColumn("Resto.Tables", "BoundedMapId", c => c.Guid(nullable: false));
            AddColumn("Resto.Meals", "OrderId", c => c.Int(nullable: false));
            AlterColumn("Resto.Tables", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("Resto.Tables", "Id");
            CreateIndex("Resto.Meals", "OrderId");
            AddForeignKey("Resto.Meals", "OrderId", "Resto.Orders", "Id", cascadeDelete: true);
            AddForeignKey("Resto.Chairs", "TableId", "Resto.Tables", "Id", cascadeDelete: true);
            DropColumn("Resto.Tables", "Description");
        }
        
        public override void Down()
        {
            AddColumn("Resto.Tables", "Description", c => c.String());
            DropForeignKey("Resto.Chairs", "TableId", "Resto.Tables");
            DropForeignKey("Resto.Meals", "OrderId", "Resto.Orders");
            DropForeignKey("Resto.Orders", "WaiterId", "Resto.Waiters");
            DropForeignKey("Resto.Orders", "TableId", "Resto.Tables");
            DropIndex("Resto.Orders", new[] { "WaiterId" });
            DropIndex("Resto.Orders", new[] { "TableId" });
            DropIndex("Resto.Meals", new[] { "OrderId" });
            DropPrimaryKey("Resto.Tables");
            AlterColumn("Resto.Tables", "Id", c => c.Int(nullable: false));
            DropColumn("Resto.Meals", "OrderId");
            DropColumn("Resto.Tables", "BoundedMapId");
            DropColumn("Resto.Tables", "Caption");
            DropTable("Resto.Orders");
            AddPrimaryKey("Resto.Tables", "Id");
            AddForeignKey("Resto.Chairs", "TableId", "Resto.Tables", "Id", cascadeDelete: true);
        }
    }
}
