using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcUCSTest.Models.Repositories
{
    public class EFSalesRepository:ISalesRepository
    {
        private UCSTestEntities context = new UCSTestEntities();
        public IEnumerable<GetSalesData_Result> SalesData
        {
            get { return context.GetSalesData().AsEnumerable<GetSalesData_Result>(); }
        }
    }
}