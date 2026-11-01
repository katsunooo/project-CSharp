namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class users
    {
        public int id { get; set; }

        [StringLength(40)]
        public string login { get; set; }

        [StringLength(100)]
        public string password { get; set; }

        public int? roleid { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(100)]
        public string last_name { get; set; }

        public virtual roles roles { get; set; }
    }
}
