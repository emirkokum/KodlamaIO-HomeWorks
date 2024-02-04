using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public abstract class BaseSaleManager
    {
        public void Sell(User user,Game game) 
        {
            Console.WriteLine(game.GameName + " selled to " + user.FirstName + " " + user.LastName);
        }

        public void SellWithDiscount(User user,Game game,Discount discount)
        { 
            Console.WriteLine($"{game.GameName} selled to {user.FirstName + " " + user.LastName} with this price : {game.Price - (game.Price * discount.DiscountAmount)} ");
        }

    }
}
