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
        {                                                                           //EfProductDal
            ProductManager productManager = new ProductManager(new EfProductDal());//InMemoryProductDal

            foreach (var product in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
