using Moq;
using MvcUCSTest.Models;
using MvcUCSTest.Models.Repositories;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcUCSTest.Infrastructure
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            // создание контейнера
            ninjectKernel = new StandardKernel();
            AddBindings();
        }
        protected override IController GetControllerInstance(RequestContext requestContext,
        Type controllerType)
        {
            // получение объекта контроллера из контейнера
            // используя его тип
            return controllerType == null
            ? null
            : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            //ninjectKernel.Bind<ISalesRepository>().To<SalesRepository>();
            //ninjectKernel.Bind<ISalesDbContext>().To<UCSTestEntities>();

            //Для теста
            //Mock<ISalesRepository> mock = new Mock<ISalesRepository>();
            //mock.Setup(m => m.SalesData).Returns(new List<GetSalesData_Result> {
            //new GetSalesData_Result {datesale=new DateTime(2015,1,10),id_good=1,summ=1000,quanity=1,name="1st",code=100},
            //new GetSalesData_Result {datesale=new DateTime(2015,1,11),id_good=2,summ=500,quanity=2,name="2nd",code=102},
            //new GetSalesData_Result {datesale=new DateTime(2015,1,11),id_good=3,summ=100,quanity=1,name="3rd",code=103}
            //}.AsEnumerable());
            //ninjectKernel.Bind<ISalesRepository>().ToConstant(mock.Object);

            ninjectKernel.Bind<ISalesRepository>().To<EFSalesRepository>();
        }
    }
}