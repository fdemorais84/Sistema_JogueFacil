namespace Sistema_JogueFacil.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Endereco")]
    public partial class Endereco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Endereco()
        {
            Cliente = new HashSet<Cliente>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Logradouro { get; set; }

        [Required]
        [StringLength(9)]
        public string Cep { get; set; }

        [StringLength(20)]
        public string Complemento { get; set; }

        [Required]
        [StringLength(10)]
        public string Numero { get; set; }

        public int Id_estado { get; set; }

        public int Id_cidade { get; set; }

        public virtual Cidade Cidade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Cliente { get; set; }

        public virtual Estado Estado { get; set; }
    }
}
