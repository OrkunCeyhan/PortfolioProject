﻿using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntitiyFramework
{
    public class EfSkillDal : GenericRepository<Skill>, ISkillDal
    {
    }
}
