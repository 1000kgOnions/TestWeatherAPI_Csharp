﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWeatherAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BTL_APIEntities1 : DbContext
    {
        public BTL_APIEntities1()
            : base("name=BTL_APIEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BaiHoc> BaiHocs { get; set; }
        public virtual DbSet<ChitietThanhToan> ChitietThanhToans { get; set; }
        public virtual DbSet<CMT> CMTs { get; set; }
        public virtual DbSet<KhoaHoc> KhoaHocs { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<NguoiDungKhoaHoc> NguoiDungKhoaHocs { get; set; }
        public virtual DbSet<ThanhToan> ThanhToans { get; set; }
    }
}
