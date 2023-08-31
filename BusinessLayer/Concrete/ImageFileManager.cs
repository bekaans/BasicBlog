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
    public class ImageFileManager : IImageFileService
    {
        IImageFileDAL _imagefiledal;

        public ImageFileManager(IImageFileDAL imagefiledal)
        {
            _imagefiledal = imagefiledal;
        }

        public List<ImageFile> GetList()
        {
            return _imagefiledal.List();
        }
    }
}
