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

        public int style { get; set; }

        [StringLength(10)]
        public string frontWord { get; set; }

        public int? frontWordSize { get; set; }

        [StringLength(10)]
        public string backWord { get; set; }

        public int? backWordSize { get; set; }

        public int? chineseFont { get; set; }

        public int? englishFont { get; set; }

        public int? numberFont { get; set; }

        public int fontColor { get; set; }

        public int quantity { get; set; }

        public double? discount { get; set; }

        [Column(TypeName = "money")]
        public decimal amount { get; set; }

        public string img { get; set; }

        public bool playerName { get; set; }

        public virtual chineseFont chineseFont1 { get; set; }

        public virtual engilshFont engilshFont { get; set; }

        public virtual fontColor fontColor1 { get; set; }

        public virtual numberFont numberFont1 { get; set; }

        public virtual order order { get; set; }

        public virtual style style1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<player> player { get; set; }
    }
}
