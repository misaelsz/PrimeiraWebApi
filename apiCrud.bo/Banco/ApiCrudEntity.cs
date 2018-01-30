namespace apiCrud.bo.Banco
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApiCrudEntity : DbContext
    {
        public ApiCrudEntity()
            : base("name=ApiCrudEntity")
        {
        }

        public virtual DbSet<pessoa> pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<pessoa>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.senha)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.telefone)
                .IsUnicode(false);
        }
    }
}
