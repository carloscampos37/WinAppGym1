namespace WinAppGym.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<acc_antiback> acc_antiback { get; set; }
        public virtual DbSet<acc_auxiliary> acc_auxiliary { get; set; }
        public virtual DbSet<acc_door> acc_door { get; set; }
        public virtual DbSet<acc_firstopen> acc_firstopen { get; set; }
        public virtual DbSet<acc_firstopen_emp> acc_firstopen_emp { get; set; }
        public virtual DbSet<acc_holidays> acc_holidays { get; set; }
        public virtual DbSet<acc_interlock> acc_interlock { get; set; }
        public virtual DbSet<acc_levelset> acc_levelset { get; set; }
        public virtual DbSet<acc_levelset_door_group> acc_levelset_door_group { get; set; }
        public virtual DbSet<acc_levelset_emp> acc_levelset_emp { get; set; }
        public virtual DbSet<acc_linkageio> acc_linkageio { get; set; }
        public virtual DbSet<acc_map> acc_map { get; set; }
        public virtual DbSet<acc_mapdoorpos> acc_mapdoorpos { get; set; }
        public virtual DbSet<acc_monitor_log> acc_monitor_log { get; set; }
        public virtual DbSet<acc_morecardempgroup> acc_morecardempgroup { get; set; }
        public virtual DbSet<acc_morecardgroup> acc_morecardgroup { get; set; }
        public virtual DbSet<acc_morecardset> acc_morecardset { get; set; }
        public virtual DbSet<acc_reader> acc_reader { get; set; }
        public virtual DbSet<acc_timeseg> acc_timeseg { get; set; }
        public virtual DbSet<acc_wiegandfmt> acc_wiegandfmt { get; set; }
        public virtual DbSet<ACGroup> ACGroup { get; set; }
        public virtual DbSet<acholiday> acholiday { get; set; }
        public virtual DbSet<ACTimeZones> ACTimeZones { get; set; }
        public virtual DbSet<action_log> action_log { get; set; }
        public virtual DbSet<ACUnlockComb> ACUnlockComb { get; set; }
        public virtual DbSet<areaadmin> areaadmin { get; set; }
        public virtual DbSet<att_attreport> att_attreport { get; set; }
        public virtual DbSet<att_waitforprocessdata> att_waitforprocessdata { get; set; }
        public virtual DbSet<attcalclog> attcalclog { get; set; }
        public virtual DbSet<attexception> attexception { get; set; }
        public virtual DbSet<AttParam> AttParam { get; set; }
        public virtual DbSet<AuditedExc> AuditedExc { get; set; }
        public virtual DbSet<auth_group> auth_group { get; set; }
        public virtual DbSet<auth_group_permissions> auth_group_permissions { get; set; }
        public virtual DbSet<auth_message> auth_message { get; set; }
        public virtual DbSet<auth_permission> auth_permission { get; set; }
        public virtual DbSet<auth_user> auth_user { get; set; }
        public virtual DbSet<auth_user_groups> auth_user_groups { get; set; }
        public virtual DbSet<auth_user_user_permissions> auth_user_user_permissions { get; set; }
        public virtual DbSet<AUTHDEVICE> AUTHDEVICE { get; set; }
        public virtual DbSet<base_additiondata> base_additiondata { get; set; }
        public virtual DbSet<base_appoption> base_appoption { get; set; }
        public virtual DbSet<base_basecode> base_basecode { get; set; }
        public virtual DbSet<base_datatranslation> base_datatranslation { get; set; }
        public virtual DbSet<base_operatortemplate> base_operatortemplate { get; set; }
        public virtual DbSet<base_option> base_option { get; set; }
        public virtual DbSet<base_personaloption> base_personaloption { get; set; }
        public virtual DbSet<base_strresource> base_strresource { get; set; }
        public virtual DbSet<base_strtranslation> base_strtranslation { get; set; }
        public virtual DbSet<base_systemoption> base_systemoption { get; set; }
        public virtual DbSet<CHECKEXACT> CHECKEXACT { get; set; }
        public virtual DbSet<CHECKINOUT> CHECKINOUT { get; set; }
        public virtual DbSet<dbapp_viewmodel> dbapp_viewmodel { get; set; }
        public virtual DbSet<dbbackuplog> dbbackuplog { get; set; }
        public virtual DbSet<DEPARTMENTS> DEPARTMENTS { get; set; }
        public virtual DbSet<deptadmin> deptadmin { get; set; }
        public virtual DbSet<DeptUsedSchs> DeptUsedSchs { get; set; }
        public virtual DbSet<devcmds> devcmds { get; set; }
        public virtual DbSet<devcmds_bak> devcmds_bak { get; set; }
        public virtual DbSet<devlog> devlog { get; set; }
        public virtual DbSet<django_content_type> django_content_type { get; set; }
        public virtual DbSet<django_session> django_session { get; set; }
        public virtual DbSet<EmOpLog> EmOpLog { get; set; }
        public virtual DbSet<empitemdefine> empitemdefine { get; set; }
        public virtual DbSet<FaceTemp> FaceTemp { get; set; }
        public virtual DbSet<FingerVein> FingerVein { get; set; }
        public virtual DbSet<HOLIDAYS> HOLIDAYS { get; set; }
        public virtual DbSet<iclock_dstime> iclock_dstime { get; set; }
        public virtual DbSet<iclock_oplog> iclock_oplog { get; set; }
        public virtual DbSet<iclock_testdata> iclock_testdata { get; set; }
        public virtual DbSet<iclock_testdata_admin_area> iclock_testdata_admin_area { get; set; }
        public virtual DbSet<iclock_testdata_admin_dept> iclock_testdata_admin_dept { get; set; }
        public virtual DbSet<LeaveClass> LeaveClass { get; set; }
        public virtual DbSet<LeaveClass1> LeaveClass1 { get; set; }
        public virtual DbSet<LossCard> LossCard { get; set; }
        public virtual DbSet<Machines> Machines { get; set; }
        public virtual DbSet<NUM_RUN> NUM_RUN { get; set; }
        public virtual DbSet<NUM_RUN_DEIL> NUM_RUN_DEIL { get; set; }
        public virtual DbSet<OfflinePermitDoors> OfflinePermitDoors { get; set; }
        public virtual DbSet<OfflinePermitGroups> OfflinePermitGroups { get; set; }
        public virtual DbSet<OfflinePermitUsers> OfflinePermitUsers { get; set; }
        public virtual DbSet<operatecmds> operatecmds { get; set; }
        public virtual DbSet<ParamSet> ParamSet { get; set; }
        public virtual DbSet<personnel_area> personnel_area { get; set; }
        public virtual DbSet<personnel_cardtype> personnel_cardtype { get; set; }
        public virtual DbSet<personnel_empchange> personnel_empchange { get; set; }
        public virtual DbSet<personnel_issuecard> personnel_issuecard { get; set; }
        public virtual DbSet<personnel_leavelog> personnel_leavelog { get; set; }
        public virtual DbSet<ReportField> ReportField { get; set; }
        public virtual DbSet<ReportItem> ReportItem { get; set; }
        public virtual DbSet<SchClass> SchClass { get; set; }
        public virtual DbSet<SECURITYDETAILS> SECURITYDETAILS { get; set; }
        public virtual DbSet<ServerLog> ServerLog { get; set; }
        public virtual DbSet<SHIFT> SHIFT { get; set; }
        public virtual DbSet<STD_WiegandFmt> STD_WiegandFmt { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<SystemLog> SystemLog { get; set; }
        public virtual DbSet<TBSMSALLOT> TBSMSALLOT { get; set; }
        public virtual DbSet<TBSMSINFO> TBSMSINFO { get; set; }
        public virtual DbSet<TEMPLATE> TEMPLATE { get; set; }
        public virtual DbSet<TmpPermitDoors> TmpPermitDoors { get; set; }
        public virtual DbSet<TmpPermitGroups> TmpPermitGroups { get; set; }
        public virtual DbSet<TmpPermitUsers> TmpPermitUsers { get; set; }
        public virtual DbSet<USER_OF_RUN> USER_OF_RUN { get; set; }
        public virtual DbSet<USER_SPEDAY> USER_SPEDAY { get; set; }
        public virtual DbSet<USER_TEMP_SCH> USER_TEMP_SCH { get; set; }
        public virtual DbSet<UserACMachines> UserACMachines { get; set; }
        public virtual DbSet<UserACPrivilege> UserACPrivilege { get; set; }
        public virtual DbSet<USERINFO> USERINFO { get; set; }
        public virtual DbSet<userinfo_attarea> userinfo_attarea { get; set; }
        public virtual DbSet<UsersMachines> UsersMachines { get; set; }
        public virtual DbSet<UserUpdates> UserUpdates { get; set; }
        public virtual DbSet<UserUsedSClasses> UserUsedSClasses { get; set; }
        public virtual DbSet<worktable_groupmsg> worktable_groupmsg { get; set; }
        public virtual DbSet<worktable_instantmsg> worktable_instantmsg { get; set; }
        public virtual DbSet<worktable_msgtype> worktable_msgtype { get; set; }
        public virtual DbSet<worktable_usrmsg> worktable_usrmsg { get; set; }
        public virtual DbSet<Zk_Autorizaciones> Zk_Autorizaciones { get; set; }
        public virtual DbSet<Zk_FormaPago> Zk_FormaPago { get; set; }
        public virtual DbSet<Zk_Membresias> Zk_Membresias { get; set; }
        public virtual DbSet<Zk_MembresiasxSocio> Zk_MembresiasxSocio { get; set; }
        public virtual DbSet<Zk_PagosSocios> Zk_PagosSocios { get; set; }
        public virtual DbSet<Zk_Periodos> Zk_Periodos { get; set; }
        public virtual DbSet<Zk_Turno> Zk_Turno { get; set; }
        public virtual DbSet<Zk_Usuario> Zk_Usuario { get; set; }
        public virtual DbSet<Zk_Validaciones> Zk_Validaciones { get; set; }
        public virtual DbSet<ZKAttendanceMonthStatistics> ZKAttendanceMonthStatistics { get; set; }
        public virtual DbSet<AlarmLog> AlarmLog { get; set; }
        public virtual DbSet<CustomReport> CustomReport { get; set; }
        public virtual DbSet<Zk_Correlativos> Zk_Correlativos { get; set; }
        public virtual DbSet<Zk_Genero> Zk_Genero { get; set; }
        public virtual DbSet<Zk_TipodePago> Zk_TipodePago { get; set; }
        public virtual DbSet<zz_membresiasxsocio> zz_membresiasxsocio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHECKEXACT>()
                .Property(e => e.CHECKTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CHECKEXACT>()
                .Property(e => e.YUYIN)
                .IsUnicode(false);

            modelBuilder.Entity<CHECKEXACT>()
                .Property(e => e.MODIFYBY)
                .IsUnicode(false);

            modelBuilder.Entity<CHECKINOUT>()
                .Property(e => e.CHECKTYPE)
                .IsUnicode(false);

            modelBuilder.Entity<CHECKINOUT>()
                .Property(e => e.SENSORID)
                .IsUnicode(false);

            modelBuilder.Entity<CHECKINOUT>()
                .Property(e => e.Memoinfo)
                .IsUnicode(false);

            modelBuilder.Entity<CHECKINOUT>()
                .Property(e => e.sn)
                .IsUnicode(false);

            modelBuilder.Entity<devcmds>()
                .Property(e => e.CmdContent)
                .IsUnicode(false);

            modelBuilder.Entity<FingerVein>()
                .Property(e => e.UserCode)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveClass>()
                .Property(e => e.LeaveName)
                .IsUnicode(false);

            modelBuilder.Entity<LeaveClass>()
                .Property(e => e.ReportSymbol)
                .IsUnicode(false);

            modelBuilder.Entity<NUM_RUN>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<ReportField>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<ReportField>()
                .Property(e => e.FieldName)
                .IsUnicode(false);

            modelBuilder.Entity<ReportItem>()
                .Property(e => e.RIName)
                .IsUnicode(false);

            modelBuilder.Entity<ReportItem>()
                .Property(e => e.UnitName)
                .IsUnicode(false);

            modelBuilder.Entity<SchClass>()
                .Property(e => e.schName)
                .IsUnicode(false);

            modelBuilder.Entity<SchClass>()
                .Property(e => e.SensorID)
                .IsUnicode(false);

            modelBuilder.Entity<SECURITYDETAILS>()
                .Property(e => e.REPORT)
                .IsUnicode(false);

            modelBuilder.Entity<ServerLog>()
                .Property(e => e.EVENT)
                .IsUnicode(false);

            modelBuilder.Entity<ServerLog>()
                .Property(e => e.EnrollNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ServerLog>()
                .Property(e => e.SENSORID)
                .IsUnicode(false);

            modelBuilder.Entity<ServerLog>()
                .Property(e => e.OPERATOR)
                .IsUnicode(false);

            modelBuilder.Entity<SHIFT>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<SystemLog>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<SystemLog>()
                .Property(e => e.MachineAlias)
                .IsUnicode(false);

            modelBuilder.Entity<SystemLog>()
                .Property(e => e.LogDescr)
                .IsUnicode(false);

            modelBuilder.Entity<TBSMSALLOT>()
                .Property(e => e.GENTM)
                .IsUnicode(false);

            modelBuilder.Entity<TBSMSINFO>()
                .Property(e => e.SMSID)
                .IsUnicode(false);

            modelBuilder.Entity<TBSMSINFO>()
                .Property(e => e.SMSCONTENT)
                .IsUnicode(false);

            modelBuilder.Entity<TBSMSINFO>()
                .Property(e => e.SMSSTARTTM)
                .IsUnicode(false);

            modelBuilder.Entity<TBSMSINFO>()
                .Property(e => e.GENTM)
                .IsUnicode(false);

            modelBuilder.Entity<USER_SPEDAY>()
                .Property(e => e.YUANYING)
                .IsUnicode(false);

            modelBuilder.Entity<UserUpdates>()
                .Property(e => e.BadgeNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Zk_Autorizaciones>()
                .Property(e => e.DescripcionAutorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Zk_Autorizaciones>()
                .HasMany(e => e.Zk_MembresiasxSocio)
                .WithOptional(e => e.Zk_Autorizaciones)
                .HasForeignKey(e => e.AutorizacionesID);

            modelBuilder.Entity<Zk_FormaPago>()
                .Property(e => e.DescripcionFormaPago)
                .IsUnicode(false);

            modelBuilder.Entity<Zk_FormaPago>()
                .HasMany(e => e.Zk_PagosSocios)
                .WithOptional(e => e.Zk_FormaPago)
                .HasForeignKey(e => e.FormaPagoID);

            modelBuilder.Entity<Zk_Membresias>()
                .Property(e => e.Precio)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Zk_Membresias>()
                .HasMany(e => e.Zk_MembresiasxSocio)
                .WithRequired(e => e.Zk_Membresias)
                .HasForeignKey(e => e.MembresiasID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zk_MembresiasxSocio>()
                .Property(e => e.Precio)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Zk_MembresiasxSocio>()
                .Property(e => e.descuento)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Zk_MembresiasxSocio>()
                .Property(e => e.PrecioPactado)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Zk_MembresiasxSocio>()
                .Property(e => e.Saldo)
                .HasPrecision(12, 0);

            modelBuilder.Entity<Zk_MembresiasxSocio>()
                .HasMany(e => e.Zk_PagosSocios)
                .WithOptional(e => e.Zk_MembresiasxSocio)
                .HasForeignKey(e => e.MembresiasxSocioID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Zk_PagosSocios>()
                .Property(e => e.ImportePagado)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Zk_PagosSocios>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Zk_Periodos>()
                .Property(e => e.DescripcionPeriodo)
                .IsUnicode(false);

            modelBuilder.Entity<Zk_Turno>()
                .Property(e => e.DescripcionTurno)
                .IsUnicode(false);

            modelBuilder.Entity<Zk_Turno>()
                .HasMany(e => e.Zk_PagosSocios)
                .WithOptional(e => e.Zk_Turno)
                .HasForeignKey(e => e.TurnoID);

            modelBuilder.Entity<Zk_Usuario>()
                .Property(e => e.CodigoID)
                .IsUnicode(false);

            modelBuilder.Entity<Zk_Usuario>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Zk_Usuario>()
                .HasMany(e => e.Zk_PagosSocios)
                .WithOptional(e => e.Zk_Usuario)
                .HasForeignKey(e => e.UsuarioID);

            modelBuilder.Entity<Zk_Validaciones>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Zk_Validaciones>()
                .Property(e => e.Acciones)
                .IsUnicode(false);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.YingDao)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.ShiDao)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.ChiDao)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.ZaoTui)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.KuangGong)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.JiaBan)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.WaiChu)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.YinGongWaiChu)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.GongZuoShiJian)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.YingQian)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.QianDao)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.QianTui)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.WeiQianDao)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.WeiQianTui)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.QingJia)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.PingRi)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.ZhouMo)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.JieJiaRi)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.ChuQinShiJian)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.PingRiJiaBan)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.ZhouMoJiaBan)
                .HasPrecision(9, 1);

            modelBuilder.Entity<ZKAttendanceMonthStatistics>()
                .Property(e => e.JieJiaRiJiaBan)
                .HasPrecision(9, 1);

            modelBuilder.Entity<Zk_Genero>()
                .Property(e => e.DescripcionGenero)
                .IsUnicode(false);

            modelBuilder.Entity<Zk_TipodePago>()
                .Property(e => e.DescripcionTipodePago)
                .IsUnicode(false);

            modelBuilder.Entity<zz_membresiasxsocio>()
                .Property(e => e.Precio)
                .HasPrecision(12, 2);

            modelBuilder.Entity<zz_membresiasxsocio>()
                .Property(e => e.descuento)
                .HasPrecision(12, 2);

            modelBuilder.Entity<zz_membresiasxsocio>()
                .Property(e => e.PrecioPactado)
                .HasPrecision(12, 2);

            modelBuilder.Entity<zz_membresiasxsocio>()
                .Property(e => e.Saldo)
                .HasPrecision(12, 0);
        }
    }
}
