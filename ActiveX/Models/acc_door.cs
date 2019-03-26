namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_door
    {
        public int id { get; set; }

        [StringLength(50)]
        public string change_operator { get; set; }

        public DateTime? change_time { get; set; }

        [StringLength(50)]
        public string create_operator { get; set; }

        public DateTime? create_time { get; set; }

        [StringLength(50)]
        public string delete_operator { get; set; }

        public DateTime? delete_time { get; set; }

        public int status { get; set; }

        public int? device_id { get; set; }

        public short? door_no { get; set; }

        [StringLength(30)]
        public string door_name { get; set; }

        public int? lock_delay { get; set; }

        public bool back_lock { get; set; }

        public int? sensor_delay { get; set; }

        public int? opendoor_type { get; set; }

        public int? inout_state { get; set; }

        public int? lock_active_id { get; set; }

        public int? long_open_id { get; set; }

        public int? wiegand_fmt_id { get; set; }

        public int? card_intervaltime { get; set; }

        public int? reader_type { get; set; }

        public bool is_att { get; set; }

        [StringLength(100)]
        public string force_pwd { get; set; }

        [StringLength(100)]
        public string supper_pwd { get; set; }

        public int? door_sensor_status { get; set; }

        public int? map_id { get; set; }

        public int? duration_apb { get; set; }

        public int? reader_io_state { get; set; }

        public int? open_door_delay { get; set; }

        public bool? door_normal_open { get; set; }

        public bool? enable_normal_open { get; set; }

        public bool? disenable_normal_open { get; set; }

        public short? wiegandInType { get; set; }

        public short? wiegandOutType { get; set; }

        public short? wiegand_fmt_out_id { get; set; }

        public short? SRBOn { get; set; }

        public int? ManualCtlMode { get; set; }

        public int? ErrTimes { get; set; }

        public int? SensorAlarmTime { get; set; }

        public int? InTimeAPB { get; set; }
    }
}
