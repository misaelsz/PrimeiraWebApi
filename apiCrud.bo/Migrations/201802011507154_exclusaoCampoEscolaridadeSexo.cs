namespace apiCrud.bo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class exclusaoCampoEscolaridadeSexo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.pessoa", "Escolaridade", c => c.String(maxLength: 50));
            AddColumn("dbo.pessoa", "Sexo", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.pessoa", "Sexo");
            DropColumn("dbo.pessoa", "Escolaridade");
        }
    }
}
