namespace Smartkey_Calculator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KeysModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Key = c.String(nullable: false, maxLength: 9),
                        Licence = c.String(),
                        CalcDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KeysModels");
        }
    }
}
