namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("USERINFO")]
    public partial class USERINFO
    {
        [Key]
        public int USERID { get; set; }

        [StringLength(50)]
        public string Badgenumber { get; set; }

        [StringLength(20)]
        public string SSN { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(8)]
        public string Gender { get; set; }

        [StringLength(20)]
        public string TITLE { get; set; }

        [StringLength(20)]
        public string PAGER { get; set; }

        public DateTime? BIRTHDAY { get; set; }

        public DateTime? HIREDDAY { get; set; }

        [StringLength(80)]
        public string street { get; set; }

        [StringLength(50)]
        public string CITY { get; set; }

        [StringLength(50)]
        public string STATE { get; set; }

        [StringLength(50)]
        public string ZIP { get; set; }

        [StringLength(20)]
        public string OPHONE { get; set; }

        [StringLength(20)]
        public string FPHONE { get; set; }

        public short? VERIFICATIONMETHOD { get; set; }

        public int? DEFAULTDEPTID { get; set; }

        public short? SECURITYFLAGS { get; set; }

        public short ATT { get; set; }

        public short INLATE { get; set; }

        public short OUTEARLY { get; set; }

        public short OVERTIME { get; set; }

        public short SEP { get; set; }

        public short HOLIDAY { get; set; }

        [StringLength(8)]
        public string MINZU { get; set; }

        [StringLength(20)]
        public string PASSWORD { get; set; }

        public short? LUNCHDURATION { get; set; }

        [Column(TypeName = "image")]
        public byte[] PHOTO { get; set; }

        [StringLength(10)]
        public string mverifypass { get; set; }

        [Column(TypeName = "image")]
        public byte[] Notes { get; set; }

        public int? privilege { get; set; }

        public short? InheritDeptSch { get; set; }

        public short? InheritDeptSchClass { get; set; }

        public short? AutoSchPlan { get; set; }

        public int? MinAutoSchInterval { get; set; }

        public short? RegisterOT { get; set; }

        public short? InheritDeptRule { get; set; }

        public short? EMPRIVILEGE { get; set; }

        [StringLength(20)]
        public string CardNo { get; set; }

        [StringLength(50)]
        public string change_operator { get; set; }

        public DateTime? change_time { get; set; }

        [StringLength(50)]
        public string create_operator { get; set; }

        public DateTime? create_time { get; set; }

        [StringLength(50)]
        public string delete_operator { get; set; }

        public DateTime? delete_time { get; set; }

        public int? status { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        public int? AccGroup { get; set; }

        [StringLength(50)]
        public string TimeZones { get; set; }

        [StringLength(50)]
        public string identitycard { get; set; }

        public DateTime? UTime { get; set; }

        [StringLength(50)]
        public string Education { get; set; }

        public int? OffDuty { get; set; }

        public int? DelTag { get; set; }

        public int? morecard_group_id { get; set; }

        public bool? set_valid_time { get; set; }

        public DateTime? acc_startdate { get; set; }

        public DateTime? acc_enddate { get; set; }

        [StringLength(50)]
        public string birthplace { get; set; }

        [StringLength(50)]
        public string Political { get; set; }

        [StringLength(50)]
        public string contry { get; set; }

        public int? hiretype { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public DateTime? firedate { get; set; }

        public bool? isatt { get; set; }

        [StringLength(50)]
        public string homeaddress { get; set; }

        public int? emptype { get; set; }

        [StringLength(50)]
        public string bankcode1 { get; set; }

        [StringLength(50)]
        public string bankcode2 { get; set; }

        public int? isblacklist { get; set; }

        public int? Iuser1 { get; set; }

        public int? Iuser2 { get; set; }

        public int? Iuser3 { get; set; }

        public int? Iuser4 { get; set; }

        public int? Iuser5 { get; set; }

        [StringLength(50)]
        public string Cuser1 { get; set; }

        [StringLength(50)]
        public string Cuser2 { get; set; }

        [StringLength(50)]
        public string Cuser3 { get; set; }

        [StringLength(50)]
        public string Cuser4 { get; set; }

        [StringLength(50)]
        public string Cuser5 { get; set; }

        public DateTime? Duser1 { get; set; }

        public DateTime? Duser2 { get; set; }

        public DateTime? Duser3 { get; set; }

        public DateTime? Duser4 { get; set; }

        public DateTime? Duser5 { get; set; }

        public DateTime? OfflineBeginDate { get; set; }

        public DateTime? OfflineEndDate { get; set; }

        [StringLength(50)]
        public string carNo { get; set; }

        [StringLength(50)]
        public string carType { get; set; }

        [StringLength(50)]
        public string carBrand { get; set; }

        [StringLength(50)]
        public string carColor { get; set; }
    }
}
