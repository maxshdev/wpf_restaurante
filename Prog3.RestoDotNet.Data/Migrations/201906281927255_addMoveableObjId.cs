namespace Prog3.RestoDotNet.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMoveableObjId : DbMigration
    {
        public override void Up()
        {
            AddColumn("Resto.Tables", "MoveableTableId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("Resto.Tables", "MoveableTableId");
        }
    }
}
