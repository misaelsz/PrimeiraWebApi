namespace apiCrud.bo.Banco
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pessoa")]
    public partial class pessoa
    {
        public Guid id { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string senha { get; set; }

        [StringLength(50)]
        public string telefone { get; set; }

        [StringLength(50)]
        public string endereco { get; set; }
    }
}
