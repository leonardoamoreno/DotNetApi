﻿// <auto-generated />
using System;
using DotProject.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DotProject.Infra.Data.Migrations.EventStoreSql
{
    [DbContext(typeof(EventStoreSqlContext))]
    [Migration("20231206182856_Initia")]
    partial class Initia
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DotProject.Domain.Core.Events.StoredEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AggregateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageType")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Action");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationDate");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StoredEvent");
                });
#pragma warning restore 612, 618
        }
    }
}
