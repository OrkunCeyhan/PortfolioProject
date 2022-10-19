using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProjectService
    {
        List<Project> GetList();
        void ProjectAdd(Project project);
        Project GetByID(int id); 
        void ProjectDelete(Project project);
        void ProjectUpdate(Project project);
    }
}
