using Oop2;

class Program
{
    static void Main(string[] args)
    {
        // Ben
        IndividualCustomer customer1 = new IndividualCustomer();
        customer1.Id = 1;   
        customer1.FirstName = "John";
        customer1.LastName = "Doe";
        customer1.CustomerNumber = "123456";
        customer1.TcNumber = "12345678910";




        // Orkide cicek
        CorporateCustomer customer2 = new CorporateCustomer();
        customer2.Id = 2;
        customer2.CustomerNumber = "33412";
        customer2.CompanyName = "OrkideCicek";
        customer2.TaxNumber = "11223344";


        // Gerçek - Tüzel
        // SOLID' in L si

        Customer customer3 = new IndividualCustomer();
        Customer customer4 = new CorporateCustomer();

        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(customer1);
        customerManager.Add(customer2);
        customerManager.Add(customer3);
        customerManager.Add(customer4);

    }
} 