using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class CategoryManager : ICategoryService
    {
        ICategoriDal _categoriDal;

        public CategoryManager(ICategoriDal categoriDal)
        {
            _categoriDal = categoriDal;
        }

        public void TAdd(Categories t)
        {
            _categoriDal.Add(t);
        }

        public Categories TGetByID(int id)
        {
            return _categoriDal.GetByID(id);
        }

        public List<Categories> TGetList()
        {
            return _categoriDal.GetList();
        }

        public void TRemove(Categories t)
        {
            _categoriDal.Delete(t);
        }

        public void TUpdate(Categories t)
        {
            _categoriDal.Update(t);
        }
    }
}
