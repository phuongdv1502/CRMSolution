namespace Model.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_log
    {
        public int id { get; set; }

        public DateTime? date { get; set; }

        [StringLength(50)]
        public string account { get; set; }

        [StringLength(50)]
        public string type { get; set; }

        [StringLength(150)]
        public string ipAddress { get; set; }

        [StringLength(150)]
        public string ipAddressName { get; set; }

        [StringLength(150)]
        public string moduleId { get; set; }

        [StringLength(150)]
        public string moduleName { get; set; }

        public bool? result { get; set; }

        [StringLength(150)]
        public string description { get; set; }

        public DateTime? creatorTime { get; set; }

        public int? creatorUserId { get; set; }
    }
}
