namespace GigerSport.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("orderDetail")]
    public partial class orderDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orderDetail()
        {
            player = new HashSet<player>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int orderDetailId { get; set; }

        public int orderNumber { get; set; }

        public int styleId { get; set; }

        [StringLength(50)]
        public string frontWord { get; set; }

        public int? frontWordSize { get; set; }

        [StringLength(50)]
        public string backWord { get; set; }

        public int? backWordSize { get; set; }

        public int? chineseFontId { get; set; }

        public int? englishFontId { get; set; }

        public int? numberFontId { get; set; }

        public int fontColorId { get; set; }

        public int quantity { get; set; }

        public double? discount { get; set; }

        [Column(TypeName = "money")]
        public decimal amount { get; set; }

        public string img { get; set; }

        public bool playerName { get; set; }

        public virtual chineseFont chineseFont { get; set; }

        public virtual engilshFont engilshFont { get; set; }

        public virtual fontColor fontColor { get; set; }

        public virtual numberFont numberFont { get; set; }

        public virtual order order { get; set; }

        public virtual style style { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<player> player { get; set; }
    }
}
