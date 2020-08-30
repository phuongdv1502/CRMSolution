namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_card
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        [StringLength(50)]
        public string code_front { get; set; }

        [StringLength(50)]
        public string code_back { get; set; }

        [StringLength(50)]
        public string type { get; set; }
    }
}
