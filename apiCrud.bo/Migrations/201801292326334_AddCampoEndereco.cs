namespace apiCrud.bo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCampoEndereco : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.pessoa", "endereco", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.pessoa", "endereco");
        }
    }
}
