﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQL04codeFirst;
using SQL04CodeFrist;

#nullable disable

namespace SQL04CodeFrist.Migrations
{
    [DbContext(typeof(AppDBcontext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SQL04CodeFrist.Coach", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("DateOfEmployee")
                    .HasColumnType("datetime2");

                b.Property<string>("ExperienceDescription")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("Height")
                    .HasColumnType("float");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Coaches");
            });
#pragma warning restore 612, 618
        }
    }
}
