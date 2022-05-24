using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OOPS");

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            var point = new Point(random.Next(0, 388), random.Next(0, 249));
            button1.Location = point;

        }
    }
}
