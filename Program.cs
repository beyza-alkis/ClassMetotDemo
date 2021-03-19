using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Ethan";
            customer1.CustomerSurname = "Hunt";
            customer1.Id = 1;

            Customer customer2 = new Customer();
            customer2.CustomerName = "Teddy";
            customer2.CustomerSurname = "Daniels";
            customer2.Id = 2;

            Customer customer3 = new Customer();
            customer3.CustomerName = "Homer";
            customer3.CustomerSurname = "Hickam";
            customer3.Id = 3;
        }
    }
}
