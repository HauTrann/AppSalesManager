﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppSalesManager.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AppSalesManagerEntities1 : DbContext
    {
        public AppSalesManagerEntities1()
            : base("name=AppSalesManagerEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<MaterialGood> MaterialGoods { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RSInward> RSInwards { get; set; }
        public DbSet<RSInwardDetail> RSInwardDetails { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserView> UserViews { get; set; }
    }
}
