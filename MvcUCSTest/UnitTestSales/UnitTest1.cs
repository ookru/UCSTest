using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MvcUCSTest.Models.Repositories;
using MvcUCSTest.Models;
using MvcUCSTest.Controllers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnitTestSales
{
    [TestClass]
    public class UnitTest1
    {

        
        [TestMethod]
        public void CanGroupDates()
        {
            // Arrange

            Mock<ISalesRepository> mock = new Mock<ISalesRepository>();
            mock.Setup(m => m.SalesData).Returns(new List<GetSalesData_Result> {
            new GetSalesData_Result {datesale=new DateTime(2015,1,10),id_good=1,summ=1000,quanity=1,name="1st",code=100},
            new GetSalesData_Result {datesale=new DateTime(2015,1,11),id_good=2,summ=500,quanity=2,name="2nd",code=102},
            new GetSalesData_Result {datesale=new DateTime(2015,1,11),id_good=3,summ=100,quanity=1,name="3rd",code=103}
            }.AsEnumerable());

            // Action

            int groupscount = (mock.Object.SalesData as IEnumerable<GetSalesData_Result>).GroupBy(x => x.datesale).Count();

            // Assert
            Assert.IsTrue(groupscount == 2);
        }
    }
}
