using System.Drawing.Imaging;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;

namespace Projectปี1
{
    public partial class Form1 : Form
    {
        private Shop Shop;
        private Queue Queue;
        string empty = "ว่าง";
        public Form1()
        {
            InitializeComponent();
            Shop = new Shop("My Laundry Shop");
            Queue = new Queue();
            addwashing_machine();
        }

        private void เพิ่มลูกค้า_Click(object sender, EventArgs e)
        {
            string name = ชื่อลูกค้า.Text;
           
            int Time = (int)time_numericUpDown.Value;
            Customer newCustomer = new Customer(name, Time);
            Queue.EnqueueCustomer(newCustomer);
            UpdateQueueListBox();
        }
        private void UpdateQueueListBox()
        {
            Queue_listBox.Items.Clear();
            foreach (Customer customer in Queue.Customers)
            {
                Queue_listBox.Items.Add(customer);
            }
        }
        private void addwashing_machine()
        {
            washing_machine machine1 = new washing_machine("Machine 1");
            machine1.Status = status_machine1;
            Shop.AddMachine(machine1);

            washing_machine machine2 = new washing_machine("Machine 2");
            machine2.Status = status_machine2;
            Shop.AddMachine(machine2);

            washing_machine machine3 = new washing_machine("Machine 3");
            machine3.Status = status_machine3;
            Shop.AddMachine(machine3);

            washing_machine machine4 = new washing_machine("Machine 4");
            machine4.Status = status_machine4;
            Shop.AddMachine(machine4);

            washing_machine machine5 = new washing_machine("Machine 5");
            machine5.Status = status_machine5;
            Shop.AddMachine(machine5);

            washing_machine machine6 = new washing_machine("Machine 6");
            machine6.Status = status_machine6;
            Shop.AddMachine(machine6);
        }

        private void next_customer_Click(object sender, EventArgs e)
        {
            if (Queue.Customers.Count > 0)
            {
                Customer servedCustomer = Queue.DequeueCustomer();
                washing_machine availableMachine = Shop.GetAvailableMachine();
                if (availableMachine != null)
                {
                    availableMachine.ServeCustomer(servedCustomer);
                    MessageBox.Show($"Serving customer: {next_customer.Name}", "Clothes count: {servedCustomer.clothesCount} at {availableMachine.Name}");
                }
                else
                {
                    MessageBox.Show($"No available machines.");
                }
                UpdateQueueListBox();
            }
            else
            {
                MessageBox.Show("No customers in queue.");
            }
        }

        private void status_machine1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Queue.Customers.Clear();
            UpdateQueueListBox();
            Shop.ClearStatusOfMachines();
        }

        private void clear2_Click(object sender, EventArgs e)
        {
            Shop.ClearStatusOfMachine("Machine 2");
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            Shop.ClearStatusOfMachine("Machine 1");
        }

        private void clear3_Click(object sender, EventArgs e)
        {
            Shop.ClearStatusOfMachine("Machine 3");
        }

        private void clear4_Click(object sender, EventArgs e)
        {
            Shop.ClearStatusOfMachine("Machine 4");
        }

        private void clear5_Click(object sender, EventArgs e)
        {
            Shop.ClearStatusOfMachine("Machine 5");
        }

        private void clear6_Click(object sender, EventArgs e)
        {
            Shop.ClearStatusOfMachine("Machine 6");
        }
    }
}
