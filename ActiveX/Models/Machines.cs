namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Machines
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string MachineAlias { get; set; }

        public int? ConnectType { get; set; }

        [StringLength(20)]
        public string IP { get; set; }

        public int? SerialPort { get; set; }

        public int? Port { get; set; }

        public int? Baudrate { get; set; }

        public int MachineNumber { get; set; }

        public bool IsHost { get; set; }

        public bool Enabled { get; set; }

        [StringLength(12)]
        public string CommPassword { get; set; }

        public short? UILanguage { get; set; }

        public short? DateFormat { get; set; }

        public short? InOutRecordWarn { get; set; }

        public short? Idle { get; set; }

        public short? Voice { get; set; }

        public short? managercount { get; set; }

        public short? usercount { get; set; }

        public short? fingercount { get; set; }

        public short? SecretCount { get; set; }

        [StringLength(50)]
        public string FirmwareVersion { get; set; }

        [StringLength(20)]
        public string ProductType { get; set; }

        public short? LockControl { get; set; }

        public short? Purpose { get; set; }

        public int? ProduceKind { get; set; }

        [StringLength(20)]
        public string sn { get; set; }

        [StringLength(20)]
        public string PhotoStamp { get; set; }

        public int? IsIfChangeConfigServer2 { get; set; }

        public int? pushver { get; set; }

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

        public int? device_type { get; set; }

        public DateTime? last_activity { get; set; }

        [StringLength(50)]
        public string trans_times { get; set; }

        public int? TransInterval { get; set; }

        [StringLength(50)]
        public string log_stamp { get; set; }

        [Column(TypeName = "image")]
        public byte[] oplog_stamp { get; set; }

        [Column(TypeName = "image")]
        public byte[] photo_stamp { get; set; }

        [StringLength(50)]
        public string UpdateDB { get; set; }

        [StringLength(50)]
        public string device_name { get; set; }

        public int? transaction_count { get; set; }

        [StringLength(50)]
        public string main_time { get; set; }

        public int? max_user_count { get; set; }

        public int? max_finger_count { get; set; }

        public int? max_attlog_count { get; set; }

        [StringLength(50)]
        public string alg_ver { get; set; }

        [StringLength(50)]
        public string flash_size { get; set; }

        [StringLength(50)]
        public string free_flash_size { get; set; }

        [StringLength(50)]
        public string language { get; set; }

        [StringLength(50)]
        public string lng_encode { get; set; }

        [StringLength(50)]
        public string volume { get; set; }

        [StringLength(50)]
        public string is_tft { get; set; }

        [StringLength(50)]
        public string platform { get; set; }

        [StringLength(50)]
        public string brightness { get; set; }

        [StringLength(50)]
        public string oem_vendor { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        public int? AccFun { get; set; }

        public int? TZAdj { get; set; }

        public int? comm_type { get; set; }

        [StringLength(50)]
        public string agent_ipaddress { get; set; }

        [StringLength(50)]
        public string subnet_mask { get; set; }

        [StringLength(50)]
        public string gateway { get; set; }

        public int? area_id { get; set; }

        public int? acpanel_type { get; set; }

        public bool sync_time { get; set; }

        public bool four_to_two { get; set; }

        [StringLength(50)]
        public string video_login { get; set; }

        public int? fp_mthreshold { get; set; }

        public int? Fpversion { get; set; }

        public int? max_comm_size { get; set; }

        public int? max_comm_count { get; set; }

        public bool realtime { get; set; }

        public int? delay { get; set; }

        public bool encrypt { get; set; }

        public int? dstime_id { get; set; }

        public int? door_count { get; set; }

        public int? reader_count { get; set; }

        public int? aux_in_count { get; set; }

        public int? aux_out_count { get; set; }

        public int? IsOnlyRFMachine { get; set; }

        [StringLength(50)]
        public string alias { get; set; }

        [StringLength(50)]
        public string ipaddress { get; set; }

        public short? com_port { get; set; }

        public short? com_address { get; set; }

        public int? SimpleEventType { get; set; }

        public int? FvFunOn { get; set; }

        public short? fvcount { get; set; }

        [Column(TypeName = "image")]
        public byte[] deviceOption { get; set; }

        public int? DevSDKType { get; set; }

        [Column(TypeName = "image")]
        public byte[] UTableDesc { get; set; }

        public bool? IsTFTMachine { get; set; }

        public int? PinWidth { get; set; }

        public int? UserExtFmt { get; set; }

        public int? FP1_NThreshold { get; set; }

        public int? FP1_1Threshold { get; set; }

        public int? Face1_NThreshold { get; set; }

        public int? Face1_1Threshold { get; set; }

        public int? Only1_1Mode { get; set; }

        public int? OnlyCheckCard { get; set; }

        public int? MifireMustRegistered { get; set; }

        public int? RFCardOn { get; set; }

        public int? Mifire { get; set; }

        public int? MifireId { get; set; }

        public int? NetOn { get; set; }

        public int? RS232On { get; set; }

        public int? RS485On { get; set; }

        public int? FreeType { get; set; }

        public int? FreeTime { get; set; }

        public int? NoDisplayFun { get; set; }

        public int? VoiceTipsOn { get; set; }

        public int? TOMenu { get; set; }

        public int? StdVolume { get; set; }

        public int? VRYVH { get; set; }

        public int? KeyPadBeep { get; set; }

        public int? BatchUpdate { get; set; }

        public int? CardFun { get; set; }

        public int? FaceFunOn { get; set; }

        public int? FaceCount { get; set; }

        public int? TimeAPBFunOn { get; set; }

        [StringLength(5)]
        public string FingerFunOn { get; set; }

        [StringLength(5)]
        public string CompatOldFirmware { get; set; }

        [Column(TypeName = "image")]
        public byte[] ParamValues { get; set; }
    }
}
