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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int undoneOrderId { get; set; }

        public int orderNumber { get; set; }

        [Required]
        public string orderInfo { get; set; }

        public virtual order order { get; set; }
    }
}
