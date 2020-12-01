namespace Sistema_JogueFacil.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Compra")]
    public partial class Compra
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data_compra { get; set; }

        public decimal Valor_total { get; set; }

        public bool Forma_pagamento { get; set; }

        public int Id_jogo { get; set; }

        public int Id_cliente { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Jogo Jogo { get; set; }
    }
}
