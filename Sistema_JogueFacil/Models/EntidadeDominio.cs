namespace Sistema_JogueFacil.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntidadeDominio : DbContext
    {
        public EntidadeDominio()
            : base("name=EntidadeDominio")
        {
        }

        public virtual DbSet<Cidade> Cidade { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<Endereco> Endereco { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Jogo> Jogo { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cidade>()
                .Property(e => e.Nome_cidade)
                .IsUnicode(false);

            modelBuilder.Entity<Cidade>()
                .HasMany(e => e.Endereco)
                .WithRequired(e => e.Cidade)
                .HasForeignKey(e => e.Id_cidade)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Cpf)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Compra)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.Id_cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Compra>()
                .Property(e => e.Valor_total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Logradouro)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Cep)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Complemento)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Endereco>()
                .HasMany(e => e.Cliente)
                .WithRequired(e => e.Endereco)
                .HasForeignKey(e => e.Id_endereco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.Sigla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.Nome_estado)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .HasMany(e => e.Cidade)
                .WithRequired(e => e.Estado)
                .HasForeignKey(e => e.Id_estado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estado>()
                .HasMany(e => e.Endereco)
                .WithRequired(e => e.Estado)
                .HasForeignKey(e => e.Id_estado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Jogo>()
                .Property(e => e.Nome_jogo)
                .IsUnicode(false);

            modelBuilder.Entity<Jogo>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<Jogo>()
                .Property(e => e.Plataforma)
                .IsUnicode(false);

            modelBuilder.Entity<Jogo>()
                .Property(e => e.Valor)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Jogo>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Jogo>()
                .HasMany(e => e.Compra)
                .WithRequired(e => e.Jogo)
                .HasForeignKey(e => e.Id_jogo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nome_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Senha)
                .IsUnicode(false);
        }
    }
}
