using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcUCSTest.Models.Repositories
{
    public interface ISalesRepository
    {
        IEnumerable<GetSalesData_Result> SalesData{get;}
    }

    //public interface ISalesDbContext
    //{
    //      DbSet<data_sales> data_sales { get; set; }
    //      DbSet<ref_goods> ref_goods { get; set; }

    //      ObjectResult<GetSalesData_Result> GetSalesData();
    //}

    //public interface ISalesRepository
    //{
    //    ISalesDbContext db;
    //}
    //public class SalesRepository : ISalesRepository
    //{
        
    //    //ISalesDbContext db;
    //    //public SalesRepository(ISalesDbContext _db)
    //    //{
    //    //    db = _db;
    //    //}
    //}
}