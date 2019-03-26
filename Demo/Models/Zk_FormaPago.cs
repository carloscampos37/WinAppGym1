namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_FormaPago
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string DescripcionFormaPago { get; set; }

        public bool? EstadoAnulado { get; set; }
    }
}
