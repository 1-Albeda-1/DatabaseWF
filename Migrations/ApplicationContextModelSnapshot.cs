// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserStoryAir;

namespace UserStoryAir.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UserStoryAir.Models.Reys", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("NumberCrew")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NumberPassengers")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NumberReys")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Plane")
                        .HasColumnType("int");

                    b.Property<decimal>("SborC")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SborP")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("allowance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("arrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("proverka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReysBD");
                });
#pragma warning restore 612, 618
        }
    }
}
