namespace GigerSport.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("player")]
    public partial class player
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int playerId { get; set; }

        [Required]
        [StringLength(10)]
        public string playerName { get; set; }

        [StringLength(10)]
        public string number { get; set; }

        public bool leader { get; set; }

        public int orderDetailId { get; set; }

        public int? size { get; set; }

        public virtual orderDetail orderDetail { get; set; }

        public virtual size size1 { get; set; }
    }
}
