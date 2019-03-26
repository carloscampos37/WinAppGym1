namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_FormaPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zk_FormaPago()
        {
            Zk_PagosSocios = new HashSet<Zk_PagosSocios>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string DescripcionFormaPago { get; set; }

        public bool? EstadoAnulado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zk_PagosSocios> Zk_PagosSocios { get; set; }
    }
}
