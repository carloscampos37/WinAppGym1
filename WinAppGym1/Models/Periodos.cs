namespace WinAppGym1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Periodos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Periodos()
        {
            Membresias = new HashSet<Membresias>();
        }

        public int ID { get; set; }

        [StringLength(30)]
        public string Descripcion { get; set; }

        public decimal? CantidadMeses { get; set; }

        public bool? EstadoAnulado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Membresias> Membresias { get; set; }
    }
}