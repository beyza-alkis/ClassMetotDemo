using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("User Added : " + customer.CustomerName + " " + customer.CustomerSurname + " " + customer.Id);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("User Deleted : " + customer.CustomerName + " " + customer.CustomerSurname + " " + customer.Id);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("User Updated : " + customer.CustomerName + " " + customer.CustomerSurname + " " + customer.Id);
        }
        public void List(Customer customer)
        {
            Console.WriteLine("Users Listed : " + customer.CustomerName + " " + customer.CustomerSurname + " " + customer.Id);
        }
    }
}
