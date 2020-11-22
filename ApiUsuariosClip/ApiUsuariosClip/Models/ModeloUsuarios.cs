namespace ApiUsuariosClip.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModeloUsuarios : DbContext
    {
        public ModeloUsuarios()
            : base("name=ModeloUsuarios")
        {
        }

        public virtual DbSet<usuarios> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<usuarios>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.foto_frente_dni)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.foto_reverso_dni)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.calle)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.numero_calle)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.puerta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.barrio)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.codigo_postal)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
