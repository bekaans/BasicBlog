﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFHeadingDAL : GenericRepository<Heading>,IHeadingDAL
    {
    }
}
