using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager:IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //business codes
            if(product.ProductName.Length > 2)
            {
                return new ErrorResult("Ürün ismi min 2 karakter olmalıdır");
            }
            _productDal.Add(product);
            return new Result(true,"Ürün Eklendi");
        }

        public List<Product> GetAll()
        {
            //iş kodları
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(product => product.CategoryId == id);
        }

        public List<Product> GetAllByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public Product GetById(int productID)
        {
            return _productDal.Get(p => p.ProductId == productID);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
