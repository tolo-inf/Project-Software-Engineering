﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.DatabaseCommunication;

namespace Server.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220512141924_v11")]
    partial class v11
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("KnjigaKnjizevniZanr", b =>
                {
                    b.Property<int>("KnjigeId")
                        .HasColumnType("int");

                    b.Property<int>("KnjizevniZanroviId")
                        .HasColumnType("int");

                    b.HasKey("KnjigeId", "KnjizevniZanroviId");

                    b.HasIndex("KnjizevniZanroviId");

                    b.ToTable("KnjigaKnjizevniZanr");
                });

            modelBuilder.Entity("Models.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumSmrti")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MestoRodjenja")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MestoSmrti")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("OAutoru")
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SlikaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SlikaId");

                    b.ToTable("Autori");
                });

            modelBuilder.Entity("Models.Cekanje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("Datum")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("KnjigaId")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KnjigaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Cekanja");
                });

            modelBuilder.Entity("Models.Citanje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FizickaKnjigaId")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int?>("MestoId")
                        .HasColumnType("int");

                    b.Property<int?>("RadnikDodelioId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("VremeUzimanjaKnjige")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("VremeVracanjaKnjige")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FizickaKnjigaId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("MestoId");

                    b.HasIndex("RadnikDodelioId");

                    b.ToTable("Citanja");
                });

            modelBuilder.Entity("Models.Citaonica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("BrojKolona")
                        .HasColumnType("int");

                    b.Property<int?>("BrojVrsta")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OgranakBibliotekeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OgranakBibliotekeId");

                    b.ToTable("Citaonice");
                });

            modelBuilder.Entity("Models.FizickaKnjiga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("IzdavacId")
                        .HasColumnType("int");

                    b.Property<int?>("JezikId")
                        .HasColumnType("int");

                    b.Property<int>("KnjigaId")
                        .HasColumnType("int");

                    b.Property<int>("OgranakBibliotekeId")
                        .HasColumnType("int");

                    b.Property<string>("Sifra")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Slobodna")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("IzdavacId");

                    b.HasIndex("JezikId");

                    b.HasIndex("KnjigaId");

                    b.HasIndex("OgranakBibliotekeId");

                    b.HasIndex("Sifra")
                        .IsUnique();

                    b.ToTable("FizickeKnjige");
                });

            modelBuilder.Entity("Models.Izdavac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Izdavaci");
                });

            modelBuilder.Entity("Models.Iznajmljivanje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("DatumIznajmljivanja")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumVracanja")
                        .HasColumnType("datetime2");

                    b.Property<int>("FizickaKnjigaId")
                        .HasColumnType("int");

                    b.Property<float>("Kazna")
                        .HasColumnType("real");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int?>("OgranakBibliotekeId")
                        .HasColumnType("int");

                    b.Property<int?>("RadnikDodelioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FizickaKnjigaId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("OgranakBibliotekeId");

                    b.HasIndex("RadnikDodelioId");

                    b.ToTable("Iznajmljivanja");
                });

            modelBuilder.Entity("Models.Jezik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Jezici");
                });

            modelBuilder.Entity("Models.Knjiga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AutorId")
                        .HasColumnType("int");

                    b.Property<int?>("KnjizevnaVrstaId")
                        .HasColumnType("int");

                    b.Property<int?>("KnjizevniRodId")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(4000)");

                    b.Property<int?>("SlikaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("KnjizevnaVrstaId");

                    b.HasIndex("KnjizevniRodId");

                    b.HasIndex("SlikaId");

                    b.ToTable("Knjige");
                });

            modelBuilder.Entity("Models.KnjizevnaVrsta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("KnjizevniRodId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("KnjizevniRodId");

                    b.ToTable("KnjizevneVrste");
                });

            modelBuilder.Entity("Models.KnjizevniRod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("KnjizevniRodovi");
                });

            modelBuilder.Entity("Models.KnjizevniZanr", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("KnjizevniZanrovi");
                });

            modelBuilder.Entity("Models.Komentar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("KnjigaId")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)");

                    b.HasKey("Id");

                    b.HasIndex("KnjigaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Komentari");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("DatumPlacanjaClanarine")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<float>("Kazna")
                        .HasColumnType("real");

                    b.Property<string>("Kontakt")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("JMBG")
                        .IsUnique();

                    b.HasIndex("KorisnickoIme")
                        .IsUnique();

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("Models.Mesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CitaonicaId")
                        .HasColumnType("int");

                    b.Property<bool>("Racunar")
                        .HasColumnType("bit");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.Property<bool>("Zauzeto")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CitaonicaId");

                    b.ToTable("Mesta");
                });

            modelBuilder.Entity("Models.OgranakBiblioteke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Kontakt")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("OgranciBiblioteke");
                });

            modelBuilder.Entity("Models.Prijava", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("OgranakBibliotekeId")
                        .HasColumnType("int");

                    b.Property<int>("RadnikId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("VremeOdjave")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VremePrijave")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OgranakBibliotekeId");

                    b.HasIndex("RadnikId");

                    b.ToTable("Prijave");
                });

            modelBuilder.Entity("Models.Radnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Kontakt")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)");

                    b.Property<bool>("Menadzer")
                        .HasColumnType("bit");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickoIme")
                        .IsUnique();

                    b.ToTable("Radnici");
                });

            modelBuilder.Entity("Models.Raspored", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("DatumDo")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumOd")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int?>("MenadzerId")
                        .HasColumnType("int");

                    b.Property<int?>("OgranakBibliotekeId")
                        .HasColumnType("int");

                    b.Property<int?>("RadnikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MenadzerId");

                    b.HasIndex("OgranakBibliotekeId");

                    b.HasIndex("RadnikId");

                    b.ToTable("Rasporedi");
                });

            modelBuilder.Entity("Models.Slika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("OgranakBibliotekeId")
                        .HasColumnType("int");

                    b.Property<int?>("VestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OgranakBibliotekeId");

                    b.HasIndex("VestId");

                    b.ToTable("Slike");
                });

            modelBuilder.Entity("Models.Vest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("Naslov")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("RadnikId")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)");

                    b.HasKey("Id");

                    b.HasIndex("RadnikId");

                    b.ToTable("Vesti");
                });

            modelBuilder.Entity("KnjigaKnjizevniZanr", b =>
                {
                    b.HasOne("Models.Knjiga", null)
                        .WithMany()
                        .HasForeignKey("KnjigeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.KnjizevniZanr", null)
                        .WithMany()
                        .HasForeignKey("KnjizevniZanroviId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Autor", b =>
                {
                    b.HasOne("Models.Slika", "Slika")
                        .WithMany()
                        .HasForeignKey("SlikaId");

                    b.Navigation("Slika");
                });

            modelBuilder.Entity("Models.Cekanje", b =>
                {
                    b.HasOne("Models.Knjiga", "Knjiga")
                        .WithMany("Cekanja")
                        .HasForeignKey("KnjigaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany("Cekanja")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Knjiga");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("Models.Citanje", b =>
                {
                    b.HasOne("Models.FizickaKnjiga", "FizickaKnjiga")
                        .WithMany("Citanja")
                        .HasForeignKey("FizickaKnjigaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany("Citanja")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Mesto", "Mesto")
                        .WithMany("Citanja")
                        .HasForeignKey("MestoId");

                    b.HasOne("Models.Radnik", "RadnikDodelio")
                        .WithMany()
                        .HasForeignKey("RadnikDodelioId");

                    b.Navigation("FizickaKnjiga");

                    b.Navigation("Korisnik");

                    b.Navigation("Mesto");

                    b.Navigation("RadnikDodelio");
                });

            modelBuilder.Entity("Models.Citaonica", b =>
                {
                    b.HasOne("Models.OgranakBiblioteke", "OgranakBiblioteke")
                        .WithMany("Citaonice")
                        .HasForeignKey("OgranakBibliotekeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OgranakBiblioteke");
                });

            modelBuilder.Entity("Models.FizickaKnjiga", b =>
                {
                    b.HasOne("Models.Izdavac", "Izdavac")
                        .WithMany("FizickeKnjige")
                        .HasForeignKey("IzdavacId");

                    b.HasOne("Models.Jezik", "Jezik")
                        .WithMany()
                        .HasForeignKey("JezikId");

                    b.HasOne("Models.Knjiga", "Knjiga")
                        .WithMany("FizickeKnjige")
                        .HasForeignKey("KnjigaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.OgranakBiblioteke", "OgranakBiblioteke")
                        .WithMany("FizickeKnjige")
                        .HasForeignKey("OgranakBibliotekeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Izdavac");

                    b.Navigation("Jezik");

                    b.Navigation("Knjiga");

                    b.Navigation("OgranakBiblioteke");
                });

            modelBuilder.Entity("Models.Iznajmljivanje", b =>
                {
                    b.HasOne("Models.FizickaKnjiga", "FizickaKnjiga")
                        .WithMany("Iznajmljivanja")
                        .HasForeignKey("FizickaKnjigaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany("Iznajmljivanja")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.OgranakBiblioteke", "OgranakBiblioteke")
                        .WithMany()
                        .HasForeignKey("OgranakBibliotekeId");

                    b.HasOne("Models.Radnik", "RadnikDodelio")
                        .WithMany()
                        .HasForeignKey("RadnikDodelioId");

                    b.Navigation("FizickaKnjiga");

                    b.Navigation("Korisnik");

                    b.Navigation("OgranakBiblioteke");

                    b.Navigation("RadnikDodelio");
                });

            modelBuilder.Entity("Models.Knjiga", b =>
                {
                    b.HasOne("Models.Autor", "Autor")
                        .WithMany("Knjige")
                        .HasForeignKey("AutorId");

                    b.HasOne("Models.KnjizevnaVrsta", "KnjizevnaVrsta")
                        .WithMany()
                        .HasForeignKey("KnjizevnaVrstaId");

                    b.HasOne("Models.KnjizevniRod", "KnjizevniRod")
                        .WithMany()
                        .HasForeignKey("KnjizevniRodId");

                    b.HasOne("Models.Slika", "Slika")
                        .WithMany()
                        .HasForeignKey("SlikaId");

                    b.Navigation("Autor");

                    b.Navigation("KnjizevnaVrsta");

                    b.Navigation("KnjizevniRod");

                    b.Navigation("Slika");
                });

            modelBuilder.Entity("Models.KnjizevnaVrsta", b =>
                {
                    b.HasOne("Models.KnjizevniRod", "KnjizevniRod")
                        .WithMany("KnjizevneVrste")
                        .HasForeignKey("KnjizevniRodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KnjizevniRod");
                });

            modelBuilder.Entity("Models.Komentar", b =>
                {
                    b.HasOne("Models.Knjiga", "Knjiga")
                        .WithMany("Komentari")
                        .HasForeignKey("KnjigaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany("Komentari")
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Knjiga");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("Models.Mesto", b =>
                {
                    b.HasOne("Models.Citaonica", "Citaonica")
                        .WithMany("Mesta")
                        .HasForeignKey("CitaonicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Citaonica");
                });

            modelBuilder.Entity("Models.Prijava", b =>
                {
                    b.HasOne("Models.OgranakBiblioteke", "OgranakBiblioteke")
                        .WithMany("Prijave")
                        .HasForeignKey("OgranakBibliotekeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Radnik", "Radnik")
                        .WithMany("Prijave")
                        .HasForeignKey("RadnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OgranakBiblioteke");

                    b.Navigation("Radnik");
                });

            modelBuilder.Entity("Models.Raspored", b =>
                {
                    b.HasOne("Models.Radnik", "Menadzer")
                        .WithMany()
                        .HasForeignKey("MenadzerId");

                    b.HasOne("Models.OgranakBiblioteke", "OgranakBiblioteke")
                        .WithMany()
                        .HasForeignKey("OgranakBibliotekeId");

                    b.HasOne("Models.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("RadnikId");

                    b.Navigation("Menadzer");

                    b.Navigation("OgranakBiblioteke");

                    b.Navigation("Radnik");
                });

            modelBuilder.Entity("Models.Slika", b =>
                {
                    b.HasOne("Models.OgranakBiblioteke", null)
                        .WithMany("Slike")
                        .HasForeignKey("OgranakBibliotekeId");

                    b.HasOne("Models.Vest", null)
                        .WithMany("Slike")
                        .HasForeignKey("VestId");
                });

            modelBuilder.Entity("Models.Vest", b =>
                {
                    b.HasOne("Models.Radnik", "Radnik")
                        .WithMany()
                        .HasForeignKey("RadnikId");

                    b.Navigation("Radnik");
                });

            modelBuilder.Entity("Models.Autor", b =>
                {
                    b.Navigation("Knjige");
                });

            modelBuilder.Entity("Models.Citaonica", b =>
                {
                    b.Navigation("Mesta");
                });

            modelBuilder.Entity("Models.FizickaKnjiga", b =>
                {
                    b.Navigation("Citanja");

                    b.Navigation("Iznajmljivanja");
                });

            modelBuilder.Entity("Models.Izdavac", b =>
                {
                    b.Navigation("FizickeKnjige");
                });

            modelBuilder.Entity("Models.Knjiga", b =>
                {
                    b.Navigation("Cekanja");

                    b.Navigation("FizickeKnjige");

                    b.Navigation("Komentari");
                });

            modelBuilder.Entity("Models.KnjizevniRod", b =>
                {
                    b.Navigation("KnjizevneVrste");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Navigation("Cekanja");

                    b.Navigation("Citanja");

                    b.Navigation("Iznajmljivanja");

                    b.Navigation("Komentari");
                });

            modelBuilder.Entity("Models.Mesto", b =>
                {
                    b.Navigation("Citanja");
                });

            modelBuilder.Entity("Models.OgranakBiblioteke", b =>
                {
                    b.Navigation("Citaonice");

                    b.Navigation("FizickeKnjige");

                    b.Navigation("Prijave");

                    b.Navigation("Slike");
                });

            modelBuilder.Entity("Models.Radnik", b =>
                {
                    b.Navigation("Prijave");
                });

            modelBuilder.Entity("Models.Vest", b =>
                {
                    b.Navigation("Slike");
                });
#pragma warning restore 612, 618
        }
    }
}
