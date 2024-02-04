using GameProject.Concrete;
using GameProject.Entities;

internal class Program
{
    public static void Main(string[] args)
    {
        User user1 = new User();
        user1.Id = 1;
        user1.FirstName = "Cem";
        user1.LastName = "Yilmaz";
        user1.DateOfBirth = new DateTime(2015, 12, 25);
        user1.NationalityId = "13489567815";

        User user2 = new User();
        user2.Id = 2;
        user2.FirstName = "Ahmet";
        user2.LastName = "Yıldız";
        user2.DateOfBirth = new DateTime(2015, 12, 25);
        user2.NationalityId = "78954632157";

        Discount discount1 = new Discount();
        discount1.Id = 1;
        discount1.Name = "Black Friday Discount";
        discount1.DiscountAmount = 0.25f;

        Game game1 = new Game();
        game1.Id = 1;
        game1.GameName = "Fifa 23";
        game1.Price = 600;

        UserManager userManager = new UserManager(new UserCheckManager());   
        userManager.Add(user1);
        userManager.Add(user2);

        SaleManager saleManager = new SaleManager();
        saleManager.Sell(user1, game1);

        saleManager.SellWithDiscount(user2, game1, discount1);

    }
}