﻿using EntityLayer.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList(string search);
        List<Content> GetListByWriter(int id);
        void ContentAdd(Content content);
        Content GetById(int id);
        void ContentRemove(Content content);
        void ContentUpdate(Content content);
        List<Content> GetListByHeadingID(int id);
    }
}
