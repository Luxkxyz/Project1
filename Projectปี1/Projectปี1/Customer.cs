using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectปี1
{
    public class Customer
    {
        public string Name { get; }
    

        public int Time { get; private set; }

        public Customer(string name, int time)
        {
            Name = name;
           
            Time = time;
        }

        public override string ToString()
        {
            return $"Customer: {Name},  time {Time}";
        }
    }

}