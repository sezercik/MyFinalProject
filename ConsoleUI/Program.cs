﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;


//SOLID
//Open Closed principle
ProductTest();
//CategoryTest();


void ProductTest()
{
 ProductManager productManager = new ProductManager(new EfProductDal());

//List<Product> products = productManager.GetAll();
//foreach (Product product in products)
//{
// Console.WriteLine(product.ProductName);   
//}

 foreach (var product in productManager.GetProductDetails())
 {
  Console.WriteLine(product.ProductName + " / " + product.CategoryName);
 }
}

void CategoryTest()
{
 CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
 foreach (Category category in categoryManager.GetAll())
 {
  Console.WriteLine(category.CategoryName);
 }
}