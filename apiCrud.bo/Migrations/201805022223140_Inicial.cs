namespace apiCrud.bo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.pessoa",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        nome = c.String(maxLength: 50),
                        telefone = c.String(maxLength: 50),
                        Nascimento = c.String(maxLength: 50),
                        CPF = c.String(maxLength: 50),
                        email = c.String(maxLength: 50),
                        RG = c.String(maxLength: 50),
                        Cep = c.String(maxLength: 50),
                        Sexo = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.pessoa");
        }
    }
}
