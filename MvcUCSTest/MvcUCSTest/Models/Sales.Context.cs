﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcUCSTest.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using MvcUCSTest.Models.Repositories;
    
    public partial class UCSTestEntities : DbContext //, ISalesDbContext

    {
        public UCSTestEntities()
            : base("name=UCSTestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<data_sales> data_sales { get; set; }
        public virtual DbSet<ref_goods> ref_goods { get; set; }
    
        public virtual ObjectResult<GetSalesData_Result> GetSalesData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSalesData_Result>("GetSalesData");
        }
    }
}
