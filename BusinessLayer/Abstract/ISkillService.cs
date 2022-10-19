using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISkillService
    {
        List<Skill> GetList();
        void SkillAdd(Skill skill);
        Skill GetByID(int id); // id yi getir categorinin şartı
        void SkillDelete(Skill skill);
        void SkillUpdate(Skill skill);
    }
}
