using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Object_oriented_Programming_
{
    public class Order
    {
        public string? OrderNo { get; set; }
        public string? OrderType { get; set; }

        public string? OrderCountry { get; set; }

        public void CreateOrder()
        {
            Console.WriteLine("Order Created");
        }

        public void UpdateOrder()
        {
            Console.WriteLine("Order Updated");
        }

        public void DeleteOrder()
        {
            Console.WriteLine("Order Deleted");
        }

        public void CreateOrder1()
        {
            UpdateOrder1();
            DeleteOrder1();
            Console.WriteLine("Order Created");
        }

        private void UpdateOrder1()
        {
            Console.WriteLine("Order Updated");
        }

        private void DeleteOrder1()
        {
            Console.WriteLine("Order Deleted");
        }


    }
}
