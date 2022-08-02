using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetAllByUnitPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();
        Product GetById(int productID);
        IResult Add(Product product);
    }
}
