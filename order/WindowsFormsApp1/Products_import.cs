namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products_import
    {
        [StringLength(255)]
        public string category { get; set; }

        [StringLength(255)]
        public string podcategory { get; set; }

        [StringLength(255)]
        public string img { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string prod { get; set; }

        [StringLength(255)]
        public string descript { get; set; }

        [StringLength(255)]
        public string sostav { get; set; }

        public double? price { get; set; }

        public int id { get; set; }
    }
}
