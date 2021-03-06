﻿// <auto-generated />
using System;
using AgendaProj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgendaProj.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AgendaProj.Models.Agenda", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("clientid");

                    b.Property<DateTime>("data");

                    b.Property<string>("descricao");

                    b.Property<TimeSpan>("duracao");

                    b.Property<string>("email");

                    b.Property<int>("fone");

                    b.Property<TimeSpan>("horaFim");

                    b.Property<TimeSpan>("horaInicio");

                    b.Property<string>("name");

                    b.Property<int>("numChamada");

                    b.Property<int?>("sitid");

                    b.HasKey("id");

                    b.HasIndex("clientid");

                    b.HasIndex("sitid");

                    b.ToTable("Agenda");
                });

            modelBuilder.Entity("AgendaProj.Models.Client", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<int>("fone");

                    b.Property<string>("nome");

                    b.HasKey("id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("AgendaProj.Models.Situacao", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("sit");

                    b.HasKey("id");

                    b.ToTable("Situacao");
                });

            modelBuilder.Entity("AgendaProj.Models.Agenda", b =>
                {
                    b.HasOne("AgendaProj.Models.Client", "client")
                        .WithMany()
                        .HasForeignKey("clientid");

                    b.HasOne("AgendaProj.Models.Situacao", "sit")
                        .WithMany()
                        .HasForeignKey("sitid");
                });
#pragma warning restore 612, 618
        }
    }
}
