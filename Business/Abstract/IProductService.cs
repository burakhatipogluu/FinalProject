﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id); // categoryId ye göre getir
        List<Product> GetByUnitPrice(decimal min, decimal max);  // iki değer arasında
    }
}
