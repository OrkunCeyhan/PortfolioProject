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
    public class ProjectManager : IProjectService
    {
        IProjectDal _projectdal;

        public ProjectManager(IProjectDal projectdal)
        {
            _projectdal = projectdal;
        }

        public Project GetByID(int id)
        {
            return _projectdal.Get(x=>x.ProjectID == id);   
        }

        public List<Project> GetList()
        {
            return _projectdal.List();
        }

        public void ProjectAdd(Project project)
        {
            _projectdal.Insert(project);
        }

        public void ProjectDelete(Project project)
        {
            _projectdal.Delete(project);
        }

        public void ProjectUpdate(Project project)
        {
            _projectdal.Update(project);
        }
    }
}
