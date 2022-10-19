using BusinessLayer.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal _servicedal;

        public ServiceManager(IServiceDal servicedal)
        {
            _servicedal = servicedal;
        }

        public Service GetByID(int id)
        {
            return _servicedal.Get(x => x.ServiceID == id);
        }

        public List<Service> GetList()
        {
            return _servicedal.List();
        }

        public void ServiceAdd(Service service)
        {
            _servicedal.Insert(service);
        }

        public void ServiceDelete(Service service)
        {
            _servicedal.Delete(service);
        }

        public void ServiceUpdate(Service service)
        {
            _servicedal.Update(service);
        }
    }
}
