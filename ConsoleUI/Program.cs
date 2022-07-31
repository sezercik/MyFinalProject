using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


//SOLID
//Open Closed principle
ProductManager productManager = new ProductManager(new EfProductDal());

//List<Product> products = productManager.GetAll();
//foreach (Product product in products)
//{
// Console.WriteLine(product.ProductName);   
//}

foreach (Product product in productManager.GetAllByCategoryId(1))
{
 Console.WriteLine(product.ProductName);
}