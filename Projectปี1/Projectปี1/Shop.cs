using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectปี1
{
    public class Shop
    {
        public Queue<Customer> CustomersQueue { get; private set; }
        public List<washing_machine> Machines { get; private set; }


        public string Name { get; }
        private List<washing_machine> machines;

        public Shop(string name)
        {
            Name = name;
            machines = new List<washing_machine>();
            CustomersQueue = new Queue<Customer>();
            Machines = new List<washing_machine>();
        }

        public void AddMachine(washing_machine machine)
        {
            machines.Add(machine);
        }

        public washing_machine GetAvailableMachine()
        {
            foreach (var machine in machines)
            {
                if (machine.Available)
                {
                    return machine;
                }
            }
            return null;
        }
        public void ClearStatusOfMachines()
        {
            foreach (var machine in machines)
            {
                machine.Available = true;
                if (machine.Status != null)
                {
                    machine.Status.Text = "ว่าง";
                }
            }
        }
        public void ClearStatusOfMachine(string machineName)
        {
            var machine = machines.FirstOrDefault(m => m.Name == machineName);
            if (machine != null)
            {
                machine.Available = true;
                if (machine.Status != null)
                {
                    machine.Status.Text = "ว่าง";
                }
            }
        }
    }
}
