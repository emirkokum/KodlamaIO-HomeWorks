using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public abstract class BaseDiscountManager
    {
        public void Add(Discount discount)
        {
            Console.WriteLine($"{discount.Name} added to the system with {discount.DiscountAmount}");
        }
        public void Delete(Discount discount) 
        {
            Console.WriteLine($"{discount.Name} deleted from to the system");
        }        
        public void Update(Discount discount)
        {
            Console.WriteLine($"{discount.Name} Updated.");
        }
    }
}
