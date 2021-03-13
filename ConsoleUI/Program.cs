using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using DataAccess.Concrete;
using DataAccess.Concrete.EntitiyFramework;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Prenciple : Yeni bir özellik ekilyorsan mevcut hiçbir koda dokunma
    class Program
    {
        static void Main(string[] args)
        {   
            


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
            ProductManager productManager = new ProductManager(new EfProductDal());//InMemoryProductDal

            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in productManager.GetProductDetails().Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

           
        }
    }
}
