namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zk_Usuario()
        {
            Zk_PagosSocios = new HashSet<Zk_PagosSocios>();
        }

        public int ID { get; set; }

        [StringLength(10)]
        public string CodigoID { get; set; }

        [StringLength(30)]
        public string Descripcion { get; set; }

        public int? NivelUsuario { get; set; }

        public bool? EstadoAnulado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zk_PagosSocios> Zk_PagosSocios { get; set; }
    }
}
