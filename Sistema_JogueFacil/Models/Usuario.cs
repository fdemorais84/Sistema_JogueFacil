namespace Sistema_JogueFacil.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Nome_usuario { get; set; }

        [Required]
        [StringLength(8)]
        public string Senha { get; set; }
    }
}
