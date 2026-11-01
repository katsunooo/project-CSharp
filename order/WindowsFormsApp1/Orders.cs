namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        public int id { get; set; }

        public int? num { get; set; }

        public DateTime? date_order { get; set; }

        [StringLength(400)]
        public string fio { get; set; }

        [StringLength(100)]
        public string category { get; set; }

        [StringLength(400)]
        public string name_tovar { get; set; }

        [StringLength(400)]
        public string proizv { get; set; }

        public int? size { get; set; }

        public int? countt { get; set; }

        public int? price { get; set; }
    }
}
