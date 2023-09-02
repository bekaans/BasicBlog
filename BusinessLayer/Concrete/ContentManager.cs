using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Conctrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {
        IContentDAL _icontentdal;
     

        public ContentManager(IContentDAL contentDAL)
        {
            _icontentdal = contentDAL;
        }

        public void ContentAdd(Content content)
        {
           _icontentdal.Insert(content);
        }

        public void ContentRemove(Content content)
        {
           _icontentdal.Delete(content);
        }

        public void ContentUpdate(Content content)
        {
            _icontentdal.Update(content);
        }

        public Content GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeadingID(int id)
        {
           return _icontentdal.List(x => x.HeadingID == id);
        }

        public List<Content> GetListByWriter(int id)
        {
            return _icontentdal.List(x => x.WriterID == id);
        }
    }
}
