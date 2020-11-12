namespace GigerSport.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("undonePlayer")]
    public partial class undonePlayer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int playerId { get; set; }

        [Required]
        [StringLength(50)]
        public string playerName { get; set; }

        [StringLength(10)]
        public string number { get; set; }

        public bool leader { get; set; }

        public int undoneorderDetailId { get; set; }

        public int size { get; set; }

        public virtual undoneOrder undoneOrder { get; set; }
    }
}
