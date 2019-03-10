using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            // create Queue of STRING type
            Queue<string> months = new Queue<string>();

            //insert elements to the Queue
            months.Enqueue("January");
            months.Enqueue("February");
            months.Enqueue("March");
            months.Enqueue("April");
            months.Enqueue("May");
            months.Enqueue("June");
            months.Enqueue("July");
            months.Enqueue("August");
            months.Enqueue("September");
            months.Enqueue("October");
            months.Enqueue("November");
            months.Enqueue("December");

            //return number of elements in Queue
            txtOUTPUT.Text = "The Number of Months in Queue: " + months.Count.ToString()+"\r\n";

            //return the top most elembent in Queue
            txtOUTPUT.Text += "Read the first in Month in the Queue: " + months.Peek().ToString() + "\r\n\r\n";

            //view items in Queue
            txtOUTPUT.Text += "Months in Queue: \r\n";

            foreach (string value in months)
                txtOUTPUT.Text += value + "\r\n";

            //remove an  element from Queue
            txtOUTPUT.Text += "Remove first in item from the Queue: " + months.Dequeue().ToString() + "\r\n\r\n";

            //check if element January is in the queue 
            if (!months.Contains("January")) txtOUTPUT.Text +="January is not in the Queue!!\r\n\r\n";
            //view the new top most element of the queue 
            txtOUTPUT.Text +="Read the first in item of Queue (after deletion): " + months.Peek().ToString();
            //empty the stack 
            months.Clear();
        }
    }
}
