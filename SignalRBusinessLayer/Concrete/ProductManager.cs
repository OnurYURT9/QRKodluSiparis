using SignalRBusinessLayer.Abstract;
using SignalREntityLayer.Entities;
using SignaRDataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> TGetProductsWithCategories()
        {
            return _productDal.GetProductsWithCategories();
        }

        public void TAdd(Product entity)
        {
           _productDal.Add(entity);
        }

        public void TDelete(Product entity)
        {
           _productDal.Delete(entity);
        }

        public Product TGetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Product> TGetListAll()
        {
            return _productDal.GetListAll();    
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }

		public int TProductCount()
		{
            return _productDal.ProductCount();
		}

		public int TProductCountByCategoryNameHamburger()
		{
			return _productDal.ProductCountByCategoryNameHamburger();
		}

		public int TProductCountByCategoryDrink()
		{
            return _productDal.ProductCountByCategoryDrink();
		}

		public decimal TProductPriceAvg()
		{
			return _productDal.ProductPriceAvg();
		}

		public string TProductNameByMaxPrice()
		{
			return _productDal.ProductNameByMaxPrice();
		}

		public string TProductNameByMinPrice()
		{
            return _productDal.ProductNameByMinPrice();
		}

		
		public decimal TProductAvgPriceByHamburger()
		{
            return _productDal.ProductAvgPriceByHamburger();
		}
	}
}
