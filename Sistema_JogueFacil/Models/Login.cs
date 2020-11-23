namespace Sistema_JogueFacil.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Login : DbContext
    {
        public Login()
            : base("name=LoginEntities")
        {
        }

        public virtual DbSet<TB_LOGIN> TB_LOGIN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
