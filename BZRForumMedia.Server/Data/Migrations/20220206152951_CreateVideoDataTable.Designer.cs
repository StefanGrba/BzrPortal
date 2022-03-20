﻿// <auto-generated />
using System;
using BZRForumMedia.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BZRForumMedia.Server.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220206152951_CreateVideoDataTable")]
    partial class CreateVideoDataTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BZRForumMedia.Server.Models.Clanak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumObjavljivanja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TekstClanka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clanci");
                });

            modelBuilder.Entity("BZRForumMedia.Server.Models.Dokumentacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DatumObjavljivanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdTipa")
                        .HasColumnType("int");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PdfPutanja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WordPutanja")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdTipa");

                    b.ToTable("Dokumentacije");
                });

            modelBuilder.Entity("BZRForumMedia.Server.Models.PitanjaIOdgovori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Odgovor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pitanje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PitanjaIOdgovori");
                });

            modelBuilder.Entity("BZRForumMedia.Server.Models.Podrubrika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.HasKey("Id");

                    b.ToTable("Podrubrike");
                });

            modelBuilder.Entity("BZRForumMedia.Server.Models.Propis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DatumObjavljivanjaOsnovnogTeksta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumObjavljivanjeVerzije")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumPocetkaPrimene")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumPrestankaVazenjaPravnogPrethodnika")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumPrestankaVazenjaPropisa")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumPrestankaVerzije")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumStupanjaNaSnaguMedjunarodnogUgovora")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumStupanjaNaSnaguOsnovnogTeksta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumStupanjaNaSnaguPropisa")
                        .HasColumnType("datetime2");

                    b.Property<string>("Donosilac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlasiloIDatum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdPodrubrika")
                        .HasColumnType("int");

                    b.Property<int?>("IdRubrika")
                        .HasColumnType("int");

                    b.Property<int?>("IdVrstaPropis")
                        .HasColumnType("int");

                    b.Property<string>("IstorijskaVerzijaPropisa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NapomenaGlasnika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivoVazenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormaOsnovaZaDonosenje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormaOsnovaZaPrestanakVazenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PravniOsnovZaDonosenjePropisa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropisKojiJePrestaoDaVazi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TekstPropisa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdPodrubrika");

                    b.HasIndex("IdRubrika");

                    b.HasIndex("IdVrstaPropis");

                    b.ToTable("Propisi");
                });

            modelBuilder.Entity("BZRForumMedia.Server.Models.Rubrika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.HasKey("Id");

                    b.ToTable("Rubrike");
                });

            modelBuilder.Entity("BZRForumMedia.Server.Models.TipDokumentacije", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImeTipa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoviDokumentacije");
                });

            modelBuilder.Entity("BZRForumMedia.Server.Models.Vest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DatumObjavljivanja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Podnaslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PutanjaDoSlike")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sazetak")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vesti");
                });

            modelBuilder.Entity("BZRForumMedia.Server.Models.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Video");
                });

            modelBuilder.Entity("BZRForumMedia.Server.Models.VrstaPropisa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.HasKey("Id");

                    b.ToTable("VrstePropisa");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BZRForumMedia.Server.Models.AppUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AppUser");
                });

            modelBuilder.Entity("BZRForumMedia.Server.Models.Dokumentacija", b =>
                {
                    b.HasOne("BZRForumMedia.Server.Models.TipDokumentacije", "IdTipaNavigation")
                        .WithMany("Dokumentacije")
                        .HasForeignKey("IdTipa")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("IdTipaNavigation");
                });

            modelBuilder.Entity("BZRForumMedia.Server.Models.Propis", b =>
                {
                    b.HasOne("BZRForumMedia.Server.Models.Podrubrika", "IdPodrubrikaNavigation")
                        .WithMany("Propisi")
                        .HasForeignKey("IdPodrubrika")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BZRForumMedia.Server.Models.Rubrika", "IdRubrikaNavigation")
                        .WithMany("Propisi")
                        .HasForeignKey("IdRubrika")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BZRForumMedia.Server.Models.VrstaPropisa", "IdVrstaPropisaNavigation")
                        .WithMany("Propisi")
                        .HasForeignKey("IdVrstaPropis")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("IdPodrubrikaNavigation");

                    b.Navigation("IdRubrikaNavigation");

                    b.Navigation("IdVrstaPropisaNavigation");
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

            modelBuilder.Entity("BZRForumMedia.Server.Models.Podrubrika", b =>
                {
                    b.Navigation("Propisi");
                });

            modelBuilder.Entity("BZRForumMedia.Server.Models.Rubrika", b =>
                {
                    b.Navigation("Propisi");
                });

            modelBuilder.Entity("BZRForumMedia.Server.Models.TipDokumentacije", b =>
                {
                    b.Navigation("Dokumentacije");
                });

            modelBuilder.Entity("BZRForumMedia.Server.Models.VrstaPropisa", b =>
                {
                    b.Navigation("Propisi");
                });
#pragma warning restore 612, 618
        }
    }
}
