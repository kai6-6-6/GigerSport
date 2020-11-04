namespace GigerSport.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("numberFont")]
    public partial class numberFont
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public numberFont()
        {
            orderDetail = new HashSet<orderDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numberFontId { get; set; }

        [Column("numberFont")]
        [Required]
        [StringLength(10)]
        public string numberFont1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderDetail> orderDetail { get; set; }
    }
}
