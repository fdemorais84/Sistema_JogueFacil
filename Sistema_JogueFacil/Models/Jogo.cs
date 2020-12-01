namespace Sistema_JogueFacil.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Jogo")]
    public partial class Jogo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jogo()
        {
            Compra = new HashSet<Compra>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Nome_jogo { get; set; }

        [Required]
        [StringLength(20)]
        public string Genero { get; set; }

        [Required]
        [StringLength(20)]
        public string Plataforma { get; set; }

        public decimal Valor { get; set; }

        [Required]
        [StringLength(50)]
        public string Descricao { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data_Lancamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compra> Compra { get; set; }
    }
}
