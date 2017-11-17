using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using LicencePlateWebApp.Entities;

namespace LicencePlateWebApp.Migrations
{
    [DbContext(typeof(CarPlateContext))]
    partial class CarPlateContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LicencePlateWebApp.Models.CarPlate", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("Color");

                    b.Property<string>("Model");

                    b.Property<string>("Plate");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("CarPlates");
                });
        }
    }
}
