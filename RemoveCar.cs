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
    public partial class RemoveCar : Form
    {
        public RemoveCar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(textBox1, textBox4);


        }
        private static void ClearTextBoxes(TextBox txb1, TextBox txb4)
        {

            txb1.Text = " ";
            txb4.Text = " ";
        }
    }
    }

