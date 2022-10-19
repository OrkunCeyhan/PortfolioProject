using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IServiceService
    {
        List<Service> GetList();
        void ServiceAdd(Service service);
        Service GetByID(int id); // id yi getir categorinin şartı
        void ServiceDelete(Service service);
        void ServiceUpdate(Service service);
    }
}
