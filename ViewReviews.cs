using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DL;
using WindowsFormsApp1.BL;

namespace WindowsFormsApp1
{
    public partial class ViewReviews : Form
    {
       List<string> ReviewsList;
        public ViewReviews()
        {
            InitializeComponent();
          

        }

        private void ViewReviews_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            /*  ReviewsList = CostumerDL.getList();
              ReviewsList.Clear();
              CostumerDL.readReviews("D:\\2ndSemester\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\Reviews.txt");

              // Clear the existing columns and bindings
              dataGridView1.DataSource = ReviewsList;
              dataGridView1.Refresh();*/
            listBox1.Hide();
            ShowFeedBack();
        }
        private void ShowFeedBack()
        {
            listBox1.Show();
            listBox1.Items.Clear();
            string feedBack = CostumerDL.readReviews("D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\Reviews.txt");
            listBox1.Items.Add(feedBack);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
