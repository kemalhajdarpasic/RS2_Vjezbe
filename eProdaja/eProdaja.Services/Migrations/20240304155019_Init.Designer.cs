﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eProdaja.Services.Database;

#nullable disable

namespace eProdaja.Services.Migrations
{
    [DbContext(typeof(EProdajaContext))]
    [Migration("20240304155019_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Latin1_General_CI_AI")
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eProdaja.Services.Database.Dobavljaci", b =>
                {
                    b.Property<int>("DobavljacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DobavljacID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DobavljacId"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Fax")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("KontaktOsoba")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Napomena")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Web")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ZiroRacuni")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("DobavljacId");

                    b.ToTable("Dobavljaci", (string)null);
                });

            modelBuilder.Entity("eProdaja.Services.Database.IzlazStavke", b =>
                {
                    b.Property<int>("IzlazStavkaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IzlazStavkaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IzlazStavkaId"));

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("IzlazId")
                        .HasColumnType("int")
                        .HasColumnName("IzlazID");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<decimal?>("Popust")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int")
                        .HasColumnName("ProizvodID");

                    b.HasKey("IzlazStavkaId");

                    b.HasIndex("IzlazId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("IzlazStavke", (string)null);
                });

            modelBuilder.Entity("eProdaja.Services.Database.Izlazi", b =>
                {
                    b.Property<int>("IzlazId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IzlazID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IzlazId"));

                    b.Property<string>("BrojRacuna")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime");

                    b.Property<decimal>("IznosBezPdv")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("IznosBezPDV");

                    b.Property<decimal>("IznosSaPdv")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("IznosSaPDV");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    b.Property<int?>("NarudzbaId")
                        .HasColumnType("int")
                        .HasColumnName("NarudzbaID");

                    b.Property<int>("SkladisteId")
                        .HasColumnType("int")
                        .HasColumnName("SkladisteID");

                    b.Property<bool>("Zakljucen")
                        .HasColumnType("bit");

                    b.HasKey("IzlazId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("NarudzbaId");

                    b.HasIndex("SkladisteId");

                    b.ToTable("Izlazi", (string)null);
                });

            modelBuilder.Entity("eProdaja.Services.Database.JediniceMjere", b =>
                {
                    b.Property<int>("JedinicaMjereId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("JedinicaMjereID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JedinicaMjereId"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("JedinicaMjereId");

                    b.ToTable("JediniceMjere", (string)null);
                });

            modelBuilder.Entity("eProdaja.Services.Database.Korisnici", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikId"));

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Telefon")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("KorisnikId");

                    b.HasIndex(new[] { "Email" }, "CS_Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex(new[] { "KorisnickoIme" }, "CS_KorisnickoIme")
                        .IsUnique();

                    b.ToTable("Korisnici", (string)null);
                });

            modelBuilder.Entity("eProdaja.Services.Database.KorisniciUloge", b =>
                {
                    b.Property<int>("KorisnikUlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KorisnikUlogaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikUlogaId"));

                    b.Property<DateTime>("DatumIzmjene")
                        .HasColumnType("datetime");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    b.Property<int>("UlogaId")
                        .HasColumnType("int")
                        .HasColumnName("UlogaID");

                    b.HasKey("KorisnikUlogaId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("UlogaId");

                    b.ToTable("KorisniciUloge", (string)null);
                });

            modelBuilder.Entity("eProdaja.Services.Database.Kupci", b =>
                {
                    b.Property<int>("KupacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KupacID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KupacId"));

                    b.Property<DateTime>("DatumRegistracije")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("KupacId");

                    b.ToTable("Kupci", (string)null);
                });

            modelBuilder.Entity("eProdaja.Services.Database.NarudzbaStavke", b =>
                {
                    b.Property<int>("NarudzbaStavkaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("NarudzbaStavkaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NarudzbaStavkaId"));

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("NarudzbaId")
                        .HasColumnType("int")
                        .HasColumnName("NarudzbaID");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int")
                        .HasColumnName("ProizvodID");

                    b.HasKey("NarudzbaStavkaId");

                    b.HasIndex("NarudzbaId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("NarudzbaStavke", (string)null);
                });

            modelBuilder.Entity("eProdaja.Services.Database.Narudzbe", b =>
                {
                    b.Property<int>("NarudzbaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("NarudzbaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NarudzbaId"));

                    b.Property<string>("BrojNarudzbe")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime");

                    b.Property<int>("KupacId")
                        .HasColumnType("int")
                        .HasColumnName("KupacID");

                    b.Property<bool?>("Otkazano")
                        .HasColumnType("bit");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("NarudzbaId");

                    b.HasIndex("KupacId");

                    b.ToTable("Narudzbe", (string)null);
                });

            modelBuilder.Entity("eProdaja.Services.Database.Ocjene", b =>
                {
                    b.Property<int>("OcjenaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OcjenaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OcjenaId"));

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime");

                    b.Property<int>("KupacId")
                        .HasColumnType("int")
                        .HasColumnName("KupacID");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int")
                        .HasColumnName("ProizvodID");

                    b.HasKey("OcjenaId");

                    b.HasIndex("KupacId");

                    b.HasIndex("ProizvodId");

                    b.ToTable("Ocjene", (string)null);
                });

            modelBuilder.Entity("eProdaja.Services.Database.Proizvodi", b =>
                {
                    b.Property<int>("ProizvodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProizvodID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProizvodId"));

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("JedinicaMjereId")
                        .HasColumnType("int")
                        .HasColumnName("JedinicaMjereID");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Sifra")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SlikaThumb")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("StateMachine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("VrstaId")
                        .HasColumnType("int")
                        .HasColumnName("VrstaID");

                    b.HasKey("ProizvodId");

                    b.HasIndex("JedinicaMjereId");

                    b.HasIndex("VrstaId");

                    b.ToTable("Proizvodi", (string)null);
                });

            modelBuilder.Entity("eProdaja.Services.Database.Skladistum", b =>
                {
                    b.Property<int>("SkladisteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SkladisteID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkladisteId"));

                    b.Property<string>("Adresa")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Opis")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("SkladisteId");

                    b.ToTable("Skladista");
                });

            modelBuilder.Entity("eProdaja.Services.Database.UlazStavke", b =>
                {
                    b.Property<int>("UlazStavkaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UlazStavkaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UlazStavkaId"));

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodId")
                        .HasColumnType("int")
                        .HasColumnName("ProizvodID");

                    b.Property<int>("UlazId")
                        .HasColumnType("int")
                        .HasColumnName("UlazID");

                    b.HasKey("UlazStavkaId");

                    b.HasIndex("ProizvodId");

                    b.HasIndex("UlazId");

                    b.ToTable("UlazStavke", (string)null);
                });

            modelBuilder.Entity("eProdaja.Services.Database.Ulazi", b =>
                {
                    b.Property<int>("UlazId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UlazID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UlazId"));

                    b.Property<string>("BrojFakture")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime");

                    b.Property<int>("DobavljacId")
                        .HasColumnType("int")
                        .HasColumnName("DobavljacID");

                    b.Property<decimal>("IznosRacuna")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int")
                        .HasColumnName("KorisnikID");

                    b.Property<string>("Napomena")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal>("Pdv")
                        .HasColumnType("numeric(18, 2)")
                        .HasColumnName("PDV");

                    b.Property<int>("SkladisteId")
                        .HasColumnType("int")
                        .HasColumnName("SkladisteID");

                    b.HasKey("UlazId");

                    b.HasIndex("DobavljacId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("SkladisteId");

                    b.ToTable("Ulazi", (string)null);
                });

            modelBuilder.Entity("eProdaja.Services.Database.Uloge", b =>
                {
                    b.Property<int>("UlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UlogaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UlogaId"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Opis")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UlogaId");

                    b.ToTable("Uloge", (string)null);
                });

            modelBuilder.Entity("eProdaja.Services.Database.VrsteProizvodum", b =>
                {
                    b.Property<int>("VrstaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VrstaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VrstaId"));

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("VrstaId");

                    b.ToTable("VrsteProizvoda");
                });

            modelBuilder.Entity("eProdaja.Services.Database.IzlazStavke", b =>
                {
                    b.HasOne("eProdaja.Services.Database.Izlazi", "Izlaz")
                        .WithMany("IzlazStavkes")
                        .HasForeignKey("IzlazId")
                        .IsRequired()
                        .HasConstraintName("FK_IzlazStavke_Izlazi");

                    b.HasOne("eProdaja.Services.Database.Proizvodi", "Proizvod")
                        .WithMany("IzlazStavkes")
                        .HasForeignKey("ProizvodId")
                        .IsRequired()
                        .HasConstraintName("FK_IzlazStavke_Proizvodi");

                    b.Navigation("Izlaz");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("eProdaja.Services.Database.Izlazi", b =>
                {
                    b.HasOne("eProdaja.Services.Database.Korisnici", "Korisnik")
                        .WithMany("Izlazis")
                        .HasForeignKey("KorisnikId")
                        .IsRequired()
                        .HasConstraintName("FK_Izlazi_Korisnici");

                    b.HasOne("eProdaja.Services.Database.Narudzbe", "Narudzba")
                        .WithMany("Izlazis")
                        .HasForeignKey("NarudzbaId")
                        .HasConstraintName("FK_Izlazi_Narudzbe");

                    b.HasOne("eProdaja.Services.Database.Skladistum", "Skladiste")
                        .WithMany("Izlazis")
                        .HasForeignKey("SkladisteId")
                        .IsRequired()
                        .HasConstraintName("FK_Izlazi_Skladista");

                    b.Navigation("Korisnik");

                    b.Navigation("Narudzba");

                    b.Navigation("Skladiste");
                });

            modelBuilder.Entity("eProdaja.Services.Database.KorisniciUloge", b =>
                {
                    b.HasOne("eProdaja.Services.Database.Korisnici", "Korisnik")
                        .WithMany("KorisniciUloges")
                        .HasForeignKey("KorisnikId")
                        .IsRequired()
                        .HasConstraintName("FK_KorisniciUloge_Korisnici");

                    b.HasOne("eProdaja.Services.Database.Uloge", "Uloga")
                        .WithMany("KorisniciUloges")
                        .HasForeignKey("UlogaId")
                        .IsRequired()
                        .HasConstraintName("FK_KorisniciUloge_Uloge");

                    b.Navigation("Korisnik");

                    b.Navigation("Uloga");
                });

            modelBuilder.Entity("eProdaja.Services.Database.NarudzbaStavke", b =>
                {
                    b.HasOne("eProdaja.Services.Database.Narudzbe", "Narudzba")
                        .WithMany("NarudzbaStavkes")
                        .HasForeignKey("NarudzbaId")
                        .IsRequired()
                        .HasConstraintName("FK_NarudzbaStavke_Narudzbe");

                    b.HasOne("eProdaja.Services.Database.Proizvodi", "Proizvod")
                        .WithMany("NarudzbaStavkes")
                        .HasForeignKey("ProizvodId")
                        .IsRequired()
                        .HasConstraintName("FK_NarudzbaStavke_Proizvodi");

                    b.Navigation("Narudzba");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("eProdaja.Services.Database.Narudzbe", b =>
                {
                    b.HasOne("eProdaja.Services.Database.Kupci", "Kupac")
                        .WithMany("Narudzbes")
                        .HasForeignKey("KupacId")
                        .IsRequired()
                        .HasConstraintName("FK_Narudzbe_Kupci");

                    b.Navigation("Kupac");
                });

            modelBuilder.Entity("eProdaja.Services.Database.Ocjene", b =>
                {
                    b.HasOne("eProdaja.Services.Database.Kupci", "Kupac")
                        .WithMany("Ocjenes")
                        .HasForeignKey("KupacId")
                        .IsRequired()
                        .HasConstraintName("FK_Ocjene_Kupci");

                    b.HasOne("eProdaja.Services.Database.Proizvodi", "Proizvod")
                        .WithMany("Ocjenes")
                        .HasForeignKey("ProizvodId")
                        .IsRequired()
                        .HasConstraintName("FK_Ocjene_Proizvodi");

                    b.Navigation("Kupac");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("eProdaja.Services.Database.Proizvodi", b =>
                {
                    b.HasOne("eProdaja.Services.Database.JediniceMjere", "JedinicaMjere")
                        .WithMany("Proizvodis")
                        .HasForeignKey("JedinicaMjereId")
                        .IsRequired()
                        .HasConstraintName("FK_Proizvodi_JediniceMjere");

                    b.HasOne("eProdaja.Services.Database.VrsteProizvodum", "Vrsta")
                        .WithMany("Proizvodis")
                        .HasForeignKey("VrstaId")
                        .IsRequired()
                        .HasConstraintName("FK_Proizvodi_VrsteProizvoda");

                    b.Navigation("JedinicaMjere");

                    b.Navigation("Vrsta");
                });

            modelBuilder.Entity("eProdaja.Services.Database.UlazStavke", b =>
                {
                    b.HasOne("eProdaja.Services.Database.Proizvodi", "Proizvod")
                        .WithMany("UlazStavkes")
                        .HasForeignKey("ProizvodId")
                        .IsRequired()
                        .HasConstraintName("FK_UlazStavke_Proizvodi");

                    b.HasOne("eProdaja.Services.Database.Ulazi", "Ulaz")
                        .WithMany("UlazStavkes")
                        .HasForeignKey("UlazId")
                        .IsRequired()
                        .HasConstraintName("FK_UlazStavke_Ulazi");

                    b.Navigation("Proizvod");

                    b.Navigation("Ulaz");
                });

            modelBuilder.Entity("eProdaja.Services.Database.Ulazi", b =>
                {
                    b.HasOne("eProdaja.Services.Database.Dobavljaci", "Dobavljac")
                        .WithMany("Ulazis")
                        .HasForeignKey("DobavljacId")
                        .IsRequired()
                        .HasConstraintName("FK_Ulazi_Dobavljaci");

                    b.HasOne("eProdaja.Services.Database.Korisnici", "Korisnik")
                        .WithMany("Ulazis")
                        .HasForeignKey("KorisnikId")
                        .IsRequired()
                        .HasConstraintName("FK_Ulazi_Korisnici");

                    b.HasOne("eProdaja.Services.Database.Skladistum", "Skladiste")
                        .WithMany("Ulazis")
                        .HasForeignKey("SkladisteId")
                        .IsRequired()
                        .HasConstraintName("FK_Ulazi_Skladista");

                    b.Navigation("Dobavljac");

                    b.Navigation("Korisnik");

                    b.Navigation("Skladiste");
                });

            modelBuilder.Entity("eProdaja.Services.Database.Dobavljaci", b =>
                {
                    b.Navigation("Ulazis");
                });

            modelBuilder.Entity("eProdaja.Services.Database.Izlazi", b =>
                {
                    b.Navigation("IzlazStavkes");
                });

            modelBuilder.Entity("eProdaja.Services.Database.JediniceMjere", b =>
                {
                    b.Navigation("Proizvodis");
                });

            modelBuilder.Entity("eProdaja.Services.Database.Korisnici", b =>
                {
                    b.Navigation("Izlazis");

                    b.Navigation("KorisniciUloges");

                    b.Navigation("Ulazis");
                });

            modelBuilder.Entity("eProdaja.Services.Database.Kupci", b =>
                {
                    b.Navigation("Narudzbes");

                    b.Navigation("Ocjenes");
                });

            modelBuilder.Entity("eProdaja.Services.Database.Narudzbe", b =>
                {
                    b.Navigation("Izlazis");

                    b.Navigation("NarudzbaStavkes");
                });

            modelBuilder.Entity("eProdaja.Services.Database.Proizvodi", b =>
                {
                    b.Navigation("IzlazStavkes");

                    b.Navigation("NarudzbaStavkes");

                    b.Navigation("Ocjenes");

                    b.Navigation("UlazStavkes");
                });

            modelBuilder.Entity("eProdaja.Services.Database.Skladistum", b =>
                {
                    b.Navigation("Izlazis");

                    b.Navigation("Ulazis");
                });

            modelBuilder.Entity("eProdaja.Services.Database.Ulazi", b =>
                {
                    b.Navigation("UlazStavkes");
                });

            modelBuilder.Entity("eProdaja.Services.Database.Uloge", b =>
                {
                    b.Navigation("KorisniciUloges");
                });

            modelBuilder.Entity("eProdaja.Services.Database.VrsteProizvodum", b =>
                {
                    b.Navigation("Proizvodis");
                });
#pragma warning restore 612, 618
        }
    }
}
