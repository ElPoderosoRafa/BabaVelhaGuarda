﻿// <auto-generated />
using System;
using BabaVelhaGuardaDigital.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BabaVelhaGuardaDigital.Migrations
{
    [DbContext(typeof(BabaVelhaGuardaContext))]
    [Migration("20230523013840_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BabaVelhaGuardaDigital.Models.Participantes.Participante", b =>
                {
                    b.Property<int>("ParticipanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Assistencias")
                        .HasColumnType("int");

                    b.Property<int>("Gols")
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("ParticipanteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Participantes");
                });

            modelBuilder.Entity("BabaVelhaGuardaDigital.Models.Usuarios.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BabaVelhaGuardaDigital.Models.Participantes.Participante", b =>
                {
                    b.HasOne("BabaVelhaGuardaDigital.Models.Usuarios.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId");

                    b.Navigation("usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
