namespace GigerSport.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chineseFont")]
    public partial class chineseFont
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public chineseFont()
        {
            orderDetail = new HashSet<orderDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int chineseFontId { get; set; }

        [Column("chineseFont")]
        [Required]
        [StringLength(10)]
        public string chineseFont1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderDetail> orderDetail { get; set; }
    }
}
