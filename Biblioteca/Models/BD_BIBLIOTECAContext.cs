using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Biblioteca.Models
{
    public partial class BD_BIBLIOTECAContext : DbContext
    {
        public BD_BIBLIOTECAContext()
        {
        }

        public BD_BIBLIOTECAContext(DbContextOptions<BD_BIBLIOTECAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autors { get; set; } = null!;
        public virtual DbSet<Livro> Livros { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=PEDRO;Database=BD_BIBLIOTECA;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>(entity =>
            {
                entity.ToTable("Autor");

                entity.Property(e => e.Nome)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Livro>(entity =>
            {
                entity.ToTable("Livro");

                entity.Property(e => e.Autor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Edição)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
