using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace day_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addbutton1_Click(object sender, EventArgs e)
        {
            int firstnumber = int.Parse(op1.Text);
            int secondnumber = int.Parse(op2.Text);
            int result = firstnumber + secondnumber;
            anslabel.Text = result.ToString();
        }

     
    }
}
