namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_Validaciones
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string Acciones { get; set; }
    }
}
