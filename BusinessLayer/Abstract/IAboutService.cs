using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList(); // veritabanındakı tum aboutları listeler
        void AboutAdd(About about);
        About GetByID(int id); // id ye gore tek bır about getır.
        void AboutDelete(About about);
        void AboutUpdate(About about);
    }
}
