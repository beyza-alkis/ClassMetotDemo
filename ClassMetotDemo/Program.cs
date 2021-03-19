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
            customer1.CustomerBirthYear = 1990;
            customer1.CustomerId = 1;

            Customer customer2 = new Customer();
            customer2.CustomerName = "Homer";
            customer2.CustomerSurname = "Hickam";
            customer2.CustomerBirthYear = 1980;
            customer2.CustomerId = 2;

            Customer customer3 = new Customer();
            customer3.CustomerName = "Darwin";
            customer3.CustomerSurname = "Waterson";
            customer3.CustomerBirthYear = 2000;
            customer3.CustomerId = 3;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(customer3);
            musteriManager.Delete(customer2);
            musteriManager.List(customer1);
        }
    }
}
