﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace B21C.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class b21cEntities : DbContext
    {
        public b21cEntities()
            : base("name=b21cEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADDRESS_BOOK> ADDRESS_BOOK { get; set; }
        public virtual DbSet<BANNER> BANNERs { get; set; }
        public virtual DbSet<CATALOG> CATALOGs { get; set; }
        public virtual DbSet<EMAIL> EMAILs { get; set; }
        public virtual DbSet<EMAIL_SUBSCRIBER> EMAIL_SUBSCRIBER { get; set; }
        public virtual DbSet<ORDER> ORDERs { get; set; }
        public virtual DbSet<ORDER_PRODUCT> ORDER_PRODUCT { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTs { get; set; }
        public virtual DbSet<PRODUCT_IMAGE> PRODUCT_IMAGE { get; set; }
        public virtual DbSet<PRODUCT_STOCK_LOG> PRODUCT_STOCK_LOG { get; set; }
        public virtual DbSet<SHOPPING_CART> SHOPPING_CART { get; set; }
        public virtual DbSet<USER_BALANCE_TRX> USER_BALANCE_TRX { get; set; }
        public virtual DbSet<PRODUCT_TRENDING> PRODUCT_TRENDING { get; set; }
        public virtual DbSet<PRODUCT_STOCK_ACTIVITY> PRODUCT_STOCK_ACTIVITY { get; set; }
        public virtual DbSet<USER_BALANCE_TOPUP> USER_BALANCE_TOPUP { get; set; }
        public virtual DbSet<PRODUCT_ORDER_STATUS_RESET> PRODUCT_ORDER_STATUS_RESET { get; set; }
        public virtual DbSet<LOOKUP> LOOKUPs { get; set; }
        public virtual DbSet<SURVEY> SURVEYs { get; set; }
        public virtual DbSet<USER_SURVEY> USER_SURVEY { get; set; }
        public virtual DbSet<ROLE> ROLEs { get; set; }
        public virtual DbSet<USER> USERs { get; set; }
        public virtual DbSet<ROLE_ACCESS> ROLE_ACCESS { get; set; }
        public virtual DbSet<USER_STATUS> USER_STATUS { get; set; }
        public virtual DbSet<PRODUCT_CATEGORY> PRODUCT_CATEGORY { get; set; }
    }
}
