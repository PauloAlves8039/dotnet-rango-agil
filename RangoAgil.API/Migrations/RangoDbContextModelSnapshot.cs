﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RangoAgil.API.Context;

#nullable disable

namespace RangoAgil.API.Migrations
{
    [DbContext(typeof(RangoDbContext))]
    partial class RangoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("IngredienteRango", b =>
                {
                    b.Property<int>("IngredientesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RangosId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IngredientesId", "RangosId");

                    b.HasIndex("RangosId");

                    b.ToTable("IngredienteRango");

                    b.HasData(
                        new
                        {
                            IngredientesId = 1,
                            RangosId = 1
                        },
                        new
                        {
                            IngredientesId = 2,
                            RangosId = 1
                        },
                        new
                        {
                            IngredientesId = 3,
                            RangosId = 1
                        },
                        new
                        {
                            IngredientesId = 4,
                            RangosId = 1
                        },
                        new
                        {
                            IngredientesId = 5,
                            RangosId = 1
                        },
                        new
                        {
                            IngredientesId = 6,
                            RangosId = 1
                        },
                        new
                        {
                            IngredientesId = 7,
                            RangosId = 1
                        },
                        new
                        {
                            IngredientesId = 8,
                            RangosId = 1
                        },
                        new
                        {
                            IngredientesId = 14,
                            RangosId = 1
                        },
                        new
                        {
                            IngredientesId = 9,
                            RangosId = 2
                        },
                        new
                        {
                            IngredientesId = 19,
                            RangosId = 2
                        },
                        new
                        {
                            IngredientesId = 11,
                            RangosId = 2
                        },
                        new
                        {
                            IngredientesId = 12,
                            RangosId = 2
                        },
                        new
                        {
                            IngredientesId = 13,
                            RangosId = 2
                        },
                        new
                        {
                            IngredientesId = 2,
                            RangosId = 2
                        },
                        new
                        {
                            IngredientesId = 21,
                            RangosId = 2
                        },
                        new
                        {
                            IngredientesId = 8,
                            RangosId = 2
                        },
                        new
                        {
                            IngredientesId = 1,
                            RangosId = 3
                        },
                        new
                        {
                            IngredientesId = 12,
                            RangosId = 3
                        },
                        new
                        {
                            IngredientesId = 17,
                            RangosId = 3
                        },
                        new
                        {
                            IngredientesId = 14,
                            RangosId = 3
                        },
                        new
                        {
                            IngredientesId = 2,
                            RangosId = 3
                        },
                        new
                        {
                            IngredientesId = 16,
                            RangosId = 3
                        },
                        new
                        {
                            IngredientesId = 23,
                            RangosId = 3
                        },
                        new
                        {
                            IngredientesId = 8,
                            RangosId = 3
                        },
                        new
                        {
                            IngredientesId = 1,
                            RangosId = 4
                        },
                        new
                        {
                            IngredientesId = 18,
                            RangosId = 4
                        },
                        new
                        {
                            IngredientesId = 16,
                            RangosId = 4
                        },
                        new
                        {
                            IngredientesId = 20,
                            RangosId = 4
                        },
                        new
                        {
                            IngredientesId = 22,
                            RangosId = 4
                        },
                        new
                        {
                            IngredientesId = 2,
                            RangosId = 4
                        },
                        new
                        {
                            IngredientesId = 21,
                            RangosId = 4
                        },
                        new
                        {
                            IngredientesId = 8,
                            RangosId = 4
                        },
                        new
                        {
                            IngredientesId = 24,
                            RangosId = 5
                        },
                        new
                        {
                            IngredientesId = 10,
                            RangosId = 5
                        },
                        new
                        {
                            IngredientesId = 23,
                            RangosId = 5
                        },
                        new
                        {
                            IngredientesId = 2,
                            RangosId = 5
                        },
                        new
                        {
                            IngredientesId = 12,
                            RangosId = 5
                        },
                        new
                        {
                            IngredientesId = 18,
                            RangosId = 5
                        },
                        new
                        {
                            IngredientesId = 14,
                            RangosId = 5
                        },
                        new
                        {
                            IngredientesId = 20,
                            RangosId = 5
                        },
                        new
                        {
                            IngredientesId = 13,
                            RangosId = 5
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RangoAgil.API.Entities.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Ingredientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Carne de Vaca"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Cebola"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Cerveja Escura"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Fatia de Pão Integral"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Mostarda"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Chicória"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Maionese"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Vários Temperos"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Mexilhões"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Aipo"
                        },
                        new
                        {
                            Id = 11,
                            Nome = "Batatas Fritas"
                        },
                        new
                        {
                            Id = 12,
                            Nome = "Tomate"
                        },
                        new
                        {
                            Id = 13,
                            Nome = "Extrato de Tomate"
                        },
                        new
                        {
                            Id = 14,
                            Nome = "Folha de Louro"
                        },
                        new
                        {
                            Id = 15,
                            Nome = "Cenoura"
                        },
                        new
                        {
                            Id = 16,
                            Nome = "Alho"
                        },
                        new
                        {
                            Id = 17,
                            Nome = "Vinho Tinto"
                        },
                        new
                        {
                            Id = 18,
                            Nome = "Leite de Coco"
                        },
                        new
                        {
                            Id = 19,
                            Nome = "Gengibre"
                        },
                        new
                        {
                            Id = 20,
                            Nome = "Pimenta Malagueta"
                        },
                        new
                        {
                            Id = 21,
                            Nome = "Tamarindo"
                        },
                        new
                        {
                            Id = 22,
                            Nome = "Peixe Firme"
                        },
                        new
                        {
                            Id = 23,
                            Nome = "Pasta de Gengibre e Alho"
                        },
                        new
                        {
                            Id = 24,
                            Nome = "Garam Masala"
                        });
                });

            modelBuilder.Entity("RangoAgil.API.Entities.Rango", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Rangos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Ensopado Flamengo de Carne de Vaca com Chicória"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Mexilhões com Batatas Fritas"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Ragu alla Bolognese"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Rendang"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Masala de Peixe"
                        });
                });

            modelBuilder.Entity("IngredienteRango", b =>
                {
                    b.HasOne("RangoAgil.API.Entities.Ingrediente", null)
                        .WithMany()
                        .HasForeignKey("IngredientesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RangoAgil.API.Entities.Rango", null)
                        .WithMany()
                        .HasForeignKey("RangosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
