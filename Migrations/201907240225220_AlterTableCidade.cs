namespace WebApi2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTableCidade : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cidades", "Nome", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Cidades", "UF", c => c.String(nullable: false, maxLength: 2, fixedLength: true, unicode: false));
            AlterColumn("dbo.Cidades", "CEP", c => c.String(maxLength: 8, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cidades", "CEP", c => c.String(maxLength: 8));
            AlterColumn("dbo.Cidades", "UF", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Cidades", "Nome", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
