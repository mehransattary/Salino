namespace SalinoMvc5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FactorDetails", "ProductId", "dbo.Products");
            DropIndex("dbo.FactorDetails", new[] { "ProductId" });
            AddColumn("dbo.FactorMains", "SaleReferenceId", c => c.String(maxLength: 50));
            AddColumn("dbo.FactorMains", "UserCodePosti", c => c.String());
            AddColumn("dbo.FactorMains", "UserOstan", c => c.String());
            AddColumn("dbo.FactorMains", "UserCity", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FactorMains", "UserCity");
            DropColumn("dbo.FactorMains", "UserOstan");
            DropColumn("dbo.FactorMains", "UserCodePosti");
            DropColumn("dbo.FactorMains", "SaleReferenceId");
            CreateIndex("dbo.FactorDetails", "ProductId");
            AddForeignKey("dbo.FactorDetails", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
