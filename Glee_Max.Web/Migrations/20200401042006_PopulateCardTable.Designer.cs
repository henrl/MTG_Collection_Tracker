﻿// <auto-generated />
using Glee_Max.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Glee_Max.Migrations
{
    [DbContext(typeof(CardContext))]
    [Migration("20200401042006_PopulateCardTable")]
    partial class PopulateCardTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Glee_Max.Web.Models.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cmc")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("ColorIdentity");

                    b.Property<string>("Colors");

                    b.Property<bool>("CommanderLegal");

                    b.Property<string>("FlavorText");

                    b.Property<string>("Language");

                    b.Property<string>("ManaCost");

                    b.Property<string>("Name");

                    b.Property<string>("OracleId");

                    b.Property<string>("OracleText");

                    b.Property<string>("Power");

                    b.Property<int>("Quantity");

                    b.Property<string>("ScryfallUri");

                    b.Property<string>("SetName");

                    b.Property<string>("Toughness");

                    b.Property<string>("TypeLine");

                    b.Property<string>("Uri");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
