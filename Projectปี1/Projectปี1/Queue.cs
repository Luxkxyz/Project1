using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectปี1
{
    public class Queue
    {
        private Queue<Customer> customers;

        public Queue()
        {
            customers = new Queue<Customer>();
        }

        public void EnqueueCustomer(Customer customer)
        {
            customers.Enqueue(customer);
        }

        public Customer DequeueCustomer()
        {
            return customers.Dequeue();
        }

        public Queue<Customer> Customers
        {
            get { return customers; }
        }
    }
}
