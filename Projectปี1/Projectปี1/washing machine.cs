using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectปี1
{
    public class washing_machine
    {
    
        public string Name { get; }
        public bool Available { get; set; }
        public Label Status { get; set; }
        

        public washing_machine(string name)
        {
            Name = name;
            Available = true;
            
        }

        public void ServeCustomer(Customer customer)
        {
            if (!Available)
            {
                MessageBox.Show($"Machine {Name} is full. Sending customer to the next machine.");
                return;
            }

            Available = false;

            if (Status != null)
            {
                Status.Text = "occupid";
                
            }
        }
    }
  }

