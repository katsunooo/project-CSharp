namespace entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user
    {
        public int id { get; set; }

        [StringLength(40)]
        public string login { get; set; }

        [StringLength(100)]
        public string password { get; set; }

        public int? roleid { get; set; }

        public virtual role role { get; set; }
    }
}
