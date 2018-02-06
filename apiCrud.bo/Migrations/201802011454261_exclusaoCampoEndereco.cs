namespace apiCrud.bo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class exclusaoCampoEndereco : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.pessoa", "endereco");
        }
        
        public override void Down()
        {
            AddColumn("dbo.pessoa", "endereco", c => c.String(maxLength: 50));
        }
    }
}
