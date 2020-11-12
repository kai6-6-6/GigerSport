namespace GigerSport.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("undoneOrder")]
    public partial class undoneOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public undoneOrder()
        {
            undonePlayer = new HashSet<undonePlayer>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int undoneOrderId { get; set; }

        [Required]
        [StringLength(20)]
        public string customerName { get; set; }

        [Required]
        [StringLength(20)]
        public string phone { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(20)]
        public string department { get; set; }

        [StringLength(20)]
        public string major { get; set; }

        public int orderNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string address { get; set; }

        [StringLength(20)]
        public string texId { get; set; }

        public int styleId { get; set; }

        [StringLength(50)]
        public string frontWord { get; set; }

        [StringLength(50)]
        public string backWord { get; set; }

        public int? chineseFontId { get; set; }

        public int? englishFontId { get; set; }

        public int? numberFontId { get; set; }

        public int? fontColorId { get; set; }

        public int quantity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<undonePlayer> undonePlayer { get; set; }
    }
}
