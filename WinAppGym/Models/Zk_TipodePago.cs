namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_TipodePago
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string DescripcionTipodePago { get; set; }

        public bool? TarjetaCredito { get; set; }

        public bool? EstadoAnulado { get; set; }
    }
}
