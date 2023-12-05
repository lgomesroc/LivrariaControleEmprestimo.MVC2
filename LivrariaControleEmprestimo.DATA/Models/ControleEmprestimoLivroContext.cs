﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LivrariaControleEmprestimo.DATA.Models;

public partial class ControleEmprestimoLivroContext : DbContext
{
    public ControleEmprestimoLivroContext()
    {
    }

    public ControleEmprestimoLivroContext(DbContextOptions<ControleEmprestimoLivroContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Livro> Livros { get; set; }

    public virtual DbSet<LivroClienteEmprestimo> LivroClienteEmprestimos { get; set; }

////    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
////        => optionsBuilder.UseSqlServer(@"Data Source=LUCGOMROC\\SQLEXPRESS;Initial Catalog=ControleEmprestimoLivro;User ID=sa;Password=5577azcD@");

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var conexao = @"Data Source=LUCGOMROC\SQLEXPRESS;Initial Catalog=ControleEmprestimoLivro;User ID=sa; MultipleActiveResultSets=true;Password=123;TrustServerCertificate=True";
        options.UseSqlServer(conexao);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Livro>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<LivroClienteEmprestimo>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.LivroClienteEmprestimo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Livro_Cliente_Emprestimo_Cliente");

            entity.HasOne(d => d.Id1).WithOne(p => p.LivroClienteEmprestimo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Livro_Cliente_Emprestimo_Livro");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}