using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using System.Web.Mvc;
using Moq;
using MRP.Domain.Interfaces;
using MRP.Domain.DBConnection;

namespace MRP.NinjectDI
{
    public class NinjectDep_cyResolver : IDependencyResolver
    {
        private IKernel kernel;
       // private IKernel kernel2;
        public NinjectDep_cyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
           // kernel2 = kernel2Param;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IRoomsRepo>().To<EFRooms>();
            kernel.Bind<IReservationsRepo>().To<EFReservations>();
           
        }
    }
}