namespace WinAppGym1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using WinAppGym1.Models;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BioTemplate> BioTemplate { get; set; }
        public virtual DbSet<Correlativos> Correlativos { get; set; }
        public virtual DbSet<FingerVein> FingerVein { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<LossCard> LossCard { get; set; }
        public virtual DbSet<Membresias> Membresias { get; set; }
        public virtual DbSet<MembresiasxSocio> MembresiasxSocio { get; set; }
        public virtual DbSet<OfflinePermitDoors> OfflinePermitDoors { get; set; }
        public virtual DbSet<OfflinePermitGroups> OfflinePermitGroups { get; set; }
        public virtual DbSet<OfflinePermitUsers> OfflinePermitUsers { get; set; }
        public virtual DbSet<ParamSet> ParamSet { get; set; }
        public virtual DbSet<Periodos> Periodos { get; set; }
        public virtual DbSet<ReportField> ReportField { get; set; }
        public virtual DbSet<STD_WiegandFmt> STD_WiegandFmt { get; set; }
        public virtual DbSet<TmpPermitDoors> TmpPermitDoors { get; set; }
        public virtual DbSet<TmpPermitGroups> TmpPermitGroups { get; set; }
        public virtual DbSet<TmpPermitUsers> TmpPermitUsers { get; set; }
        public virtual DbSet<USERINFO> USERINFO { get; set; }
        public virtual DbSet<CustomReport> CustomReport { get; set; }
        public virtual DbSet<FaceTempEx> FaceTempEx { get; set; }
        public virtual DbSet<FingerVeinEx> FingerVeinEx { get; set; }
        public virtual DbSet<TEMPLATEEx> TEMPLATEEx { get; set; }
        public virtual DbSet<zz_Membresias> zz_Membresias { get; set; }
        public virtual DbSet<zz_userinfo> zz_userinfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BioTemplate>()
                .Property(e => e.BadgeNumber)
                .IsUnicode(false);

            modelBuilder.Entity<BioTemplate>()
                .Property(e => e.CreateOperator)
                .IsUnicode(false);

            modelBuilder.Entity<BioTemplate>()
                .Property(e => e.ValidFlag)
                .IsUnicode(false);

            modelBuilder.Entity<BioTemplate>()
                .Property(e => e.IsDuress)
                .IsUnicode(false);

            modelBuilder.Entity<BioTemplate>()
                .Property(e => e.Version)
                .IsUnicode(false);

            modelBuilder.Entity<BioTemplate>()
                .Property(e => e.TemplateData)
                .IsUnicode(false);

            modelBuilder.Entity<FingerVein>()
                .Property(e => e.UserCode)
                .IsUnicode(false);

            modelBuilder.Entity<FingerVein>()
                .Property(e => e.StateMigrationFlag)
                .IsUnicode(false);

            modelBuilder.Entity<Genero>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Membresias>()
                .Property(e => e.Cantidad)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Membresias>()
                .Property(e => e.Precio)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Membresias>()
                .HasMany(e => e.MembresiasxSocio)
                .WithRequired(e => e.Membresias)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MembresiasxSocio>()
                .Property(e => e.Precio)
                .HasPrecision(12, 2);

            modelBuilder.Entity<MembresiasxSocio>()
                .Property(e => e.descuento)
                .HasPrecision(12, 2);

            modelBuilder.Entity<MembresiasxSocio>()
                .Property(e => e.ImportePactado)
                .HasPrecision(12, 2);

            modelBuilder.Entity<MembresiasxSocio>()
                .Property(e => e.PagosaCuenta)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Periodos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Periodos>()
                .Property(e => e.CantidadMeses)
                .HasPrecision(12, 2);

            modelBuilder.Entity<ReportField>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<ReportField>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<USERINFO>()
                .HasMany(e => e.MembresiasxSocio)
                .WithRequired(e => e.USERINFO)
                .HasForeignKey(e => e.UserInfoID);

            modelBuilder.Entity<FaceTempEx>()
                .Property(e => e.StateMigrationFlag)
                .IsUnicode(false);

            modelBuilder.Entity<FingerVeinEx>()
                .Property(e => e.UserCode)
                .IsUnicode(false);

            modelBuilder.Entity<FingerVeinEx>()
                .Property(e => e.StateMigrationFlag)
                .IsUnicode(false);

            modelBuilder.Entity<TEMPLATEEx>()
                .Property(e => e.StateMigrationFlag)
                .IsUnicode(false);

            modelBuilder.Entity<zz_Membresias>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<zz_Membresias>()
                .Property(e => e.Cantidad)
                .HasPrecision(12, 2);

            modelBuilder.Entity<zz_Membresias>()
                .Property(e => e.Precio)
                .HasPrecision(12, 2);
        }
    }
}
