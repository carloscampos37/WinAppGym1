namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_Periodos
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string DescripcionPeriodo { get; set; }

        public int? Meses { get; set; }

        public bool? EstadoAnulado { get; set; }

        public int? Dias { get; set; }
    }
}
