namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_linkageio
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

        [StringLength(50)]
        public string delete_time { get; set; }

        public int? status { get; set; }

        [StringLength(50)]
        public string linkage_name { get; set; }

        public int? device_id { get; set; }

        public int? trigger_opt { get; set; }

        public int? in_address_hide { get; set; }

        public int? in_address { get; set; }

        public int? out_type_hide { get; set; }

        public int? out_address_hide { get; set; }

        public int? out_address { get; set; }

        public int? action_type { get; set; }

        public int? delay_time { get; set; }

        public int? video_linkageio_id { get; set; }

        public int? lchannel_num { get; set; }
    }
}
