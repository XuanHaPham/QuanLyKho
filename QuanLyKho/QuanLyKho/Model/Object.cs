namespace QuanLyKho.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Object")]
    public partial class Object
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Object()
        {
            InputInfoes = new HashSet<InputInfo>();
            OutputInfoes = new HashSet<OutputInfo>();
        }

        public string Id { get; set; }

        public string DisplayName { get; set; }

        public int IdUnit { get; set; }

        public int IdSuplier { get; set; }

        public string QRCode { get; set; }

        public string BarCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InputInfo> InputInfoes { get; set; }

        public virtual Unit Unit { get; set; }

        public virtual Suplier Suplier { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutputInfo> OutputInfoes { get; set; }
    }
}
