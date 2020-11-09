namespace GigerSport.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            order = new HashSet<order>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int customerId { get; set; }

        [Required]
        [StringLength(20)]
        public string customerName { get; set; }

        [Required]
        [StringLength(20)]
        public string phone { get; set; }

        [Required]
        public string address { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(20)]
        public string texId { get; set; }

        [StringLength(20)]
        public string department { get; set; }

        [StringLength(20)]
        public string major { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> order { get; set; }
    }
}
