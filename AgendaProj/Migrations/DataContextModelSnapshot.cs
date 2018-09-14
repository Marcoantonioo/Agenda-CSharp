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

                    b.Property<DateTime>("data");

                    b.Property<string>("descricao");

                    b.Property<TimeSpan>("duracao");

                    b.Property<string>("email");

                    b.Property<int>("fone");

                    b.Property<TimeSpan>("horaFim");

                    b.Property<TimeSpan>("horaInicio");

                    b.Property<string>("name");

                    b.Property<int>("numChamada");

                    b.HasKey("id");

                    b.ToTable("Agenda");
                });
#pragma warning restore 612, 618
        }
    }
}
