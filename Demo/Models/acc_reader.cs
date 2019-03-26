namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_reader
    {
        public long id { get; set; }

        public int? door_id { get; set; }

        public int? reader_no { get; set; }

        [StringLength(50)]
        public string reader_name { get; set; }

        public int? reader_state { get; set; }
    }
}
