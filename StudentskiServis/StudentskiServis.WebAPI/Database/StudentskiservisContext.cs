using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudentskiServis.WebAPI.Database
{
    public partial class StudentskiservisContext : DbContext
    {
        public StudentskiservisContext()
        {
        }

        public StudentskiservisContext(DbContextOptions<StudentskiservisContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administracija> Administracija { get; set; }
        public virtual DbSet<Ispit> Ispit { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual DbSet<Kurs> Kurs { get; set; }
        public virtual DbSet<Obavijest> Obavijest { get; set; }
        public virtual DbSet<Pohadja> Pohadja { get; set; }
        public virtual DbSet<Predaje> Predaje { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<Raspored> Raspored { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
        public virtual DbSet<Uplata> Uplata { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=Studentski servis;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administracija>(entity =>
            {
                entity.Property(e => e.AdministracijaId).HasColumnName("AdministracijaID");

                entity.Property(e => e.Adresa).HasMaxLength(60);

                entity.Property(e => e.DatumRodjenja).HasColumnType("datetime");

                entity.Property(e => e.DatumZaposlenja).HasColumnType("datetime");

                entity.Property(e => e.Ime).HasMaxLength(20);

                entity.Property(e => e.Kancelarija).HasMaxLength(13);

                entity.Property(e => e.KorisnickoIme).HasMaxLength(50);

                entity.Property(e => e.LozinkaHash).HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(50);

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.Prezime).HasMaxLength(30);

                entity.Property(e => e.Spol).HasMaxLength(1);

                entity.Property(e => e.VrstaUgovora).HasMaxLength(11);
            });

            modelBuilder.Entity<Ispit>(entity =>
            {
                entity.Property(e => e.IspitId).HasColumnName("IspitID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.KursId).HasColumnName("KursID");

                entity.Property(e => e.ParcijalnoBodovanje).HasMaxLength(2);

                entity.Property(e => e.ProfesorId).HasColumnName("ProfesorID");

                entity.Property(e => e.Ucionica).HasMaxLength(15);

                entity.HasOne(d => d.Kurs)
                    .WithMany(p => p.Ispit)
                    .HasForeignKey(d => d.KursId)
                    .HasConstraintName("Kurs_Id_FK");

                entity.HasOne(d => d.Profesor)
                    .WithMany(p => p.Ispit)
                    .HasForeignKey(d => d.ProfesorId)
                    .HasConstraintName("Profesor_Id_FK");
            });

            modelBuilder.Entity<KorisniciUloge>(entity =>
            {
                entity.HasKey(e => e.KorisnikUlogaId);

                entity.Property(e => e.KorisnikUlogaId).HasColumnName("KorisnikUlogaID");

                entity.Property(e => e.AdministracijaId).HasColumnName("AdministracijaID");

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.Property(e => e.ProfesorId).HasColumnName("ProfesorID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.HasOne(d => d.Administracija)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.AdministracijaId)
                    .HasConstraintName("AdministracijaID_FK");

                entity.HasOne(d => d.Profesor)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.ProfesorId)
                    .HasConstraintName("ProfesorID_FK");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("StudentID_FK");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.UlogaId)
                    .HasConstraintName("UlogaID_FK");
            });

            modelBuilder.Entity<Kurs>(entity =>
            {
                entity.Property(e => e.KursId).HasColumnName("KursID");

                entity.Property(e => e.Ects).HasColumnName("ECTS");

                entity.Property(e => e.Naziv).HasMaxLength(50);

                entity.Property(e => e.PosjedujePraksu).HasMaxLength(2);

                entity.Property(e => e.PosjedujeSeminarski).HasMaxLength(2);
            });

            modelBuilder.Entity<Obavijest>(entity =>
            {
                entity.Property(e => e.ObavijestId).HasColumnName("ObavijestID");

                entity.Property(e => e.DatumObjave).HasColumnType("datetime");

                entity.Property(e => e.Naslov).HasMaxLength(30);

                entity.Property(e => e.ProfesorId).HasColumnName("ProfesorID");

                entity.HasOne(d => d.Profesor)
                    .WithMany(p => p.Obavijest)
                    .HasForeignKey(d => d.ProfesorId)
                    .HasConstraintName("Profesor_ID_FK");
            });

            modelBuilder.Entity<Pohadja>(entity =>
            {
                entity.ToTable("pohadja");

                entity.Property(e => e.PohadjaId).HasColumnName("pohadjaID");

                entity.Property(e => e.Aktivan).HasMaxLength(2);

                entity.Property(e => e.KursId).HasColumnName("KursID");

                entity.Property(e => e.Obnavlja).HasMaxLength(2);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.DatumPohadjanja).HasColumnType("datetime");

                entity.Property(e => e.Ocjena).HasColumnName("Ocjena");

                entity.HasOne(d => d.Kurs)
                    .WithMany(p => p.Pohadja)
                    .HasForeignKey(d => d.KursId)
                    .HasConstraintName("Kurs_Id_Fk");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Pohadja)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("Studenti_ID_FK");
            });

            modelBuilder.Entity<Predaje>(entity =>
            {
                entity.ToTable("predaje");

                entity.Property(e => e.PredajeId).HasColumnName("predajeID");

                entity.Property(e => e.DatumPredavanja).HasColumnType("datetime");

                entity.Property(e => e.KursId).HasColumnName("KursID");

                entity.Property(e => e.Odrzano).HasMaxLength(2);

                entity.Property(e => e.ProfesorId).HasColumnName("ProfesorID");

                entity.Property(e => e.Vrsta).HasMaxLength(10);

                entity.HasOne(d => d.Kurs)
                    .WithMany(p => p.Predaje)
                    .HasForeignKey(d => d.KursId)
                    .HasConstraintName("KursID_FK");

                entity.HasOne(d => d.Profesor)
                    .WithMany(p => p.Predaje)
                    .HasForeignKey(d => d.ProfesorId)
                    .HasConstraintName("Profesori_ID_FK");
            });

            modelBuilder.Entity<Profesor>(entity =>
            {
                entity.Property(e => e.ProfesorId).HasColumnName("ProfesorID");

                entity.Property(e => e.Adresa).HasMaxLength(60);

                entity.Property(e => e.DatumRodjenja).HasColumnType("datetime");

                entity.Property(e => e.DatumZaposlenja).HasColumnType("datetime");

                entity.Property(e => e.Ime).HasMaxLength(20);

                entity.Property(e => e.Kancelarija).HasMaxLength(13);

                entity.Property(e => e.KorisnickoIme).HasMaxLength(50);

                entity.Property(e => e.LozinkaHash).HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(50);

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.Prezime).HasMaxLength(30);

                entity.Property(e => e.Spol).HasMaxLength(1);

                entity.Property(e => e.VrstaUgovora).HasMaxLength(11);

                entity.Property(e => e.Zvanje).HasMaxLength(15);
            });

            modelBuilder.Entity<Raspored>(entity =>
            {
                entity.Property(e => e.RasporedId).HasColumnName("RasporedID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Naslov).HasMaxLength(40);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Vazno).HasMaxLength(2);

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Raspored)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("Student_Id_FK");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Adresa).HasMaxLength(50);

                entity.Property(e => e.DatumRodjenja).HasColumnType("datetime");

                entity.Property(e => e.DatumUpisa).HasColumnType("datetime");

                entity.Property(e => e.Ime).HasMaxLength(20);

                entity.Property(e => e.Indeks).HasMaxLength(8);

                entity.Property(e => e.KorisnickoIme).HasMaxLength(50);

                entity.Property(e => e.LozinkaHash).HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(50);

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.NacinStudiranja).HasMaxLength(8);

                entity.Property(e => e.ObnavljaGodinu).HasMaxLength(2);

                entity.Property(e => e.Prezime).HasMaxLength(30);

                entity.Property(e => e.Spol).HasMaxLength(1);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.Telefon).HasMaxLength(11);
            });

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.HasKey(e => e.UlogaId);

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(200);
            });

            modelBuilder.Entity<Uplata>(entity =>
            {
                entity.Property(e => e.UplataId).HasColumnName("UplataID");

                entity.Property(e => e.AdministracijaId).HasColumnName("AdministracijaID");

                entity.Property(e => e.DatumUplate).HasColumnType("datetime");

                entity.Property(e => e.Ovjereno).HasMaxLength(2);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Svrha).HasMaxLength(40);

                entity.HasOne(d => d.Administracija)
                    .WithMany(p => p.Uplata)
                    .HasForeignKey(d => d.AdministracijaId)
                    .HasConstraintName("Administracija_ID_FK");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Uplata)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("Student_ID_FK");
            });
        }
    }
}
