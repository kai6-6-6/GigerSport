namespace GigerSport.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("size")]
    public partial class size
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public size()
        {
            player = new HashSet<player>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sizeId { get; set; }

        [Column("size")]
        [Required]
        [StringLength(5)]
        public string size1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<player> player { get; set; }
    }
}
