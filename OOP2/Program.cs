using OOP2;

internal class Program
{
    private static void Main(string[] args)
    {
        IndividualCustomer customer1 = new IndividualCustomer();
        customer1.Id = 1;
        customer1.Name = "Omer Faruk";
        customer1.LastName = "CAN";
        customer1.NationalId = "1241254125";

        CorporateCustomer customer2 = new CorporateCustomer();
        customer2.Id = 2;
        customer2.CustomerNo = "125412";
        customer2.CompanyName = "Kodlama";
        customer2.TextNo = "2151251";

        Customer customer3 = new IndividualCustomer();
        Customer customer4 = new CorporateCustomer();

        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(customer1);
        customerManager.Add(customer2);
    }
}