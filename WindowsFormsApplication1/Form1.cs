using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Random rnd = new Random();
            int number;
            int count = 0;

            for (int index = 0; index < 10; index++)
            {
                number = -100 + rnd.Next(200);
                listBox1.Items.Add(number);
            }

            for (int index = 1; index < 9; index += 2)
            {
                if (((int)listBox1.Items[index] > (int)listBox1.Items[index + 1]) && ((int)listBox1.Items[index] > (int)listBox1.Items[index - 1]))
                    count++;
            }
            MessageBox.Show(count.ToString());
        }
    }
}

