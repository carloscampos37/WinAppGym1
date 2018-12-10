namespace WinAppGym1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Correlativos")]
    public partial class Correlativos
    {
                public int ID { get; set; }
        public int Codigo { get; set; }
        public int Grupo { get; set; }
    }
}
