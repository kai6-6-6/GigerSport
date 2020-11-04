namespace GigerSport.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("engilshFont")]
    public partial class engilshFont
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public engilshFont()
        {
            orderDetail = new HashSet<orderDetail>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int engilshFontId { get; set; }

        [Column("engilshFont")]
        [Required]
        [StringLength(10)]
        public string engilshFont1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderDetail> orderDetail { get; set; }
    }
}
