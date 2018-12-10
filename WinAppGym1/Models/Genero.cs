namespace WinAppGym1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Genero")]
    public partial class Genero
    {
        [StringLength(8)]
        public string ID { get; set; }

        [StringLength(30)]
        public string Descripcion { get; set; }
    }
}
