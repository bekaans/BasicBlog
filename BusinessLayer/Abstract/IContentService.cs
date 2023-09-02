using EntityLayer.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListByWriter();
        void ContentAdd(Content content);
        Content GetById(int id);
        void ContentRemove(Content content);
        void ContentUpdate(Content content);
        List<Content> GetListByHeadingID(int id);
    }
}
