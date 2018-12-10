namespace WinAppGym1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Membresias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Membresias()
        {
            MembresiasxSocio = new HashSet<MembresiasxSocio>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        public int? PeriodosID { get; set; }

        public bool? Limitado { get; set; }

        public decimal? Cantidad { get; set; }

        public decimal? Precio { get; set; }

        public bool? EstadoAnulado { get; set; }

        public bool? MembresiaGrupo { get; set; }

        public DateTime? InicioVigencia { get; set; }

        public DateTime? TerminoVigencia { get; set; }

        public virtual Periodos Periodos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MembresiasxSocio> MembresiasxSocio { get; set; }
    }
}
