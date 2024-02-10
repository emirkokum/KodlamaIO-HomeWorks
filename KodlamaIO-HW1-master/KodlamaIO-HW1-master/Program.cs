using ClassMethodDemo;

class Program
{
    private static void Main(string[] args)
    {
        Customer customer1 = new Customer();    
        customer1.customerID = 1;
        customer1.customerFirstName = "Ali";
        customer1.customerLastName = "Yildiz";
        customer1.customerPhoneNum = "+905111111111";

        Customer customer2 = new Customer();
        customer2.customerID = 1;
        customer2.customerFirstName = "Ayse";
        customer2.customerLastName = "Yildiz";
        customer2.customerPhoneNum = "+905222222222";

        CustomerManager customerManager = new CustomerManager();

        customerManager.AddCustomer(customer1);
        customerManager.AddCustomer(customer2);

        customerManager.GetCustomerList();

        customerManager.RemoveCustomer(customer2);
        customerManager.GetCustomerList();
    }
}