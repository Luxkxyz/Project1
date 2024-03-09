using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;


namespace Projectปี1
{
    public class washing_machine
    {
    
        public string Name { get; }
        public bool Available { get; set; }
        public Label Status { get; set; }

        public int Time { get; private set; }
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
                    Status.Text = "occupied";
                }
            SaveResultToCSV(customer.Name, Name, customer.Time);
        }
        private void SaveResultToCSV(string customerName, string machineName, int clothesCount)
        {
            var records = new List<ResultDATA>
    {
        new ResultDATA { CustomerName = customerName, Time = Time }
    };

            using (var writer = new StreamWriter("results.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
        }
    }
  }

