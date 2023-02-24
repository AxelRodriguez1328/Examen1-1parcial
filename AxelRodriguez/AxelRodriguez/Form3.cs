using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxelRodriguez
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox.Items.Add("Axel Rodriguez");
                }
                else if (i % 3 == 0)
                {
                    listBox.Items.Add("Axel");
                }
                else if (i % 5 == 0)
                {
                    listBox.Items.Add("Rodriguez");
                }
                else
                {
                    listBox.Items.Add(i);
                }

            }
        }
}
}

