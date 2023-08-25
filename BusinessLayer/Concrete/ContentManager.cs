using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
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

        public List<Content> GetList(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByID(int id)
        {
           return _icontentdal.List(x => x.HeadingID == id);
        }
    }
}
