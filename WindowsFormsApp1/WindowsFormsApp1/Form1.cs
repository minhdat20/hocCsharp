using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
int i = 1;
        private void Form1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Bạn đã click " + i + " lần");
            i++;
        }
    }
}
