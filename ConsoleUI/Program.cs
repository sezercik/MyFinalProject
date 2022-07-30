using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

ProductManager productManager = new ProductManager(new InMemoryProductDal());

List<Product> products = productManager.GetAll();
foreach (Product product in products)
{
 Console.WriteLine(product.ProductName);   
}