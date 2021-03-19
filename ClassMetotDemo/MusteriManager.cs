using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Users Added : " + customer.CustomerName + " " + customer.CustomerSurname + " " + customer.CustomerBirthYear + " " + customer.CustomerId);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Users Deleted : " + customer.CustomerName + " " + customer.CustomerSurname + " " + customer.CustomerBirthYear + " " + customer.CustomerId);
        }
        public void List(Customer customer)
        {
            Console.WriteLine("Users Listed : " + customer.CustomerName + " " + customer.CustomerSurname + " " + customer.CustomerBirthYear + " " + customer.CustomerId);
        }
    }
}
