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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TAdd(Products t)
        {
            _productDal.Add(t);
        }

        public Products TGetByID(int id)
        {
            return _productDal.GetByID(id); 
        }

        public List<Products> TGetList()
        {
            return _productDal.GetList();
        }

        public void TRemove(Products t)
        {
            _productDal.Delete(t);
        }

        public void TUpdate(Products t)
        {
            _productDal.Update(t);
        }
    }
}
