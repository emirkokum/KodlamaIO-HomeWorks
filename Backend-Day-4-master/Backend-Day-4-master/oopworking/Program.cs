﻿using OOP1;

class Program
{
    static void Main(string[] args)
    {

        Product product1 = new Product();
        product1.Id = 1;
        product1.CategoryId = 2;
        product1.ProductName = "Desk";
        product1.UnitPrice = 500;
        product1.UnitsInStock = 10;

        Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Pencil", UnitPrice = 10};

        //PascalCase   //camelCase
        ProductManager productManager = new ProductManager();
        productManager.Add(product1);
        

    }
}