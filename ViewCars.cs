using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BL;
using WindowsFormsApp1.DL;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class ViewCars : Form
    {
        public ViewCars()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\cars.txt";
            PopulateDataGridView(filePath);
        }
        private void PopulateDataGridView(string filePath)
        {
            // Read the data from the file
            string[] lines = File.ReadAllLines(filePath);

            // Create a DataTable to hold the data
            DataTable dataTable = new DataTable();

            // Assume the data is comma-separated
            string[] headers = lines[0].Split(',');
            foreach (string header in headers)
            {
                dataTable.Columns.Add(header);
            }

            // Skip the first line (headers) and populate the DataTable
            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');
                dataTable.Rows.Add(data);
            }

            // Bind the DataTable to the DataGridView
            CarsDataGridView.DataSource = dataTable;
            CarsDataGridView.Visible = true;
            label1.Visible = false;
            button2.Visible = false;
            EXit.Visible = true;
        }

        private void EXit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewCars_Load(object sender, EventArgs e)
        {

        }
    }
}
