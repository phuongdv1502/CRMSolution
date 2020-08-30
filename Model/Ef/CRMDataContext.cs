namespace Model.Ef
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CRMDataContext : DbContext
    {
        public CRMDataContext()
            : base("name=CRMDataContext")
        {
        }

        public virtual DbSet<call_appointment> call_appointment { get; set; }
        public virtual DbSet<sale_appointment> sale_appointment { get; set; }
        public virtual DbSet<sale_customer> sale_customer { get; set; }
        public virtual DbSet<sale_customer_bill> sale_customer_bill { get; set; }
        public virtual DbSet<sale_customer_bill_detail> sale_customer_bill_detail { get; set; }
        public virtual DbSet<sale_customer_bill_method> sale_customer_bill_method { get; set; }
        public virtual DbSet<sale_customer_staff> sale_customer_staff { get; set; }
        public virtual DbSet<sale_product> sale_product { get; set; }
        public virtual DbSet<sale_product_detail> sale_product_detail { get; set; }
        public virtual DbSet<service_appointment> service_appointment { get; set; }
        public virtual DbSet<sys_card> sys_card { get; set; }
        public virtual DbSet<sys_center> sys_center { get; set; }
        public virtual DbSet<sys_data_source> sys_data_source { get; set; }
        public virtual DbSet<sys_data_type> sys_data_type { get; set; }
        public virtual DbSet<sys_department> sys_department { get; set; }
        public virtual DbSet<sys_frame> sys_frame { get; set; }
        public virtual DbSet<sys_log> sys_log { get; set; }
        public virtual DbSet<sys_menu> sys_menu { get; set; }
        public virtual DbSet<sys_param> sys_param { get; set; }
        public virtual DbSet<sys_role> sys_role { get; set; }
        public virtual DbSet<sys_room_treatment> sys_room_treatment { get; set; }
        public virtual DbSet<sys_user> sys_user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<call_appointment>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<call_appointment>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sale_appointment>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sale_appointment>()
                .Property(e => e.extend)
                .IsUnicode(false);

            modelBuilder.Entity<sale_appointment>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sale_customer>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sale_customer>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sale_customer>()
                .Property(e => e.mobile_orther)
                .IsUnicode(false);

            modelBuilder.Entity<sale_product>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sale_product_detail>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<service_appointment>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sys_card>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sys_card>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<sys_center>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sys_center>()
                .Property(e => e.brandname)
                .IsUnicode(false);

            modelBuilder.Entity<sys_center>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sys_center>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<sys_center>()
                .Property(e => e.update_by)
                .IsUnicode(false);

            modelBuilder.Entity<sys_data_source>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sys_data_type>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sys_department>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sys_frame>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sys_menu>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sys_param>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sys_role>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sys_user>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<sys_user>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<sys_user>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<sys_user>()
                .Property(e => e.extend)
                .IsUnicode(false);
        }
    }
}
