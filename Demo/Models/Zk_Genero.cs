namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_Genero
    {
        [StringLength(8)]
        public string ID { get; set; }

        [StringLength(30)]
        public string Descripcion { get; set; }
    }
}
