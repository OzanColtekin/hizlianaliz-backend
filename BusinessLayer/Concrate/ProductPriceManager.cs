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
    public class ProductPriceManager : IProductPriceService
    {
        IProductPriceDal _productPriceDal;

        public ProductPriceManager(IProductPriceDal productPriceDal)
        {
            _productPriceDal = productPriceDal;
        }

        public void TAdd(ProductPrices t)
        {
            _productPriceDal.Add(t);
        }

        public ProductPrices TGetByID(int id)
        {
            return _productPriceDal.GetByID(id);    
        }

        public List<ProductPrices> TGetList()
        {
            return _productPriceDal.GetList();
        }

        public void TRemove(ProductPrices t)
        {
            _productPriceDal.Delete(t);
        }

        public void TUpdate(ProductPrices t)
        {
            _productPriceDal.Update(t);
        }
    }
}
