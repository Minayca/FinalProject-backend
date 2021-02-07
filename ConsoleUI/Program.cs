using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle : Yaptığın yazılıma yeni bir özellik ekliyorsan mevcuttaki hiçbir koduna dokunmamalısın.
    class Program
    {
        static void Main(string[] args)
        {
            //DTO: Data Transformation Object
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine("{0} / {1}", product.ProductName, product.CategoryName);
            }
        }
    }
}
