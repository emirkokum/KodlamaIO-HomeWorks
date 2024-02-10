using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager // CRUD => Create , Read , Update , Delete
    {
        //encapsulation => farklı farklı propertyleri yollamaktansa o proplara sahip olan bir objecti methoda yollamak 
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");       
        }

    }
}
