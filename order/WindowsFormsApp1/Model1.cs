using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products_import> Products_import { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<roles>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<roles>()
                .HasMany(e => e.users)
                .WithOptional(e => e.roles)
                .HasForeignKey(e => e.roleid);

            modelBuilder.Entity<users>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.password)
                .IsUnicode(false);
        }
    }
}
