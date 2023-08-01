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
    public partial class ViewCostumers : Form
    {
      //  public static DataTable dataTable = new DataTable();
        List<PersonBL> persons;

        public ViewCostumers()
        {
            InitializeComponent();


            persons = PersonDL.getList();
            persons.Clear();
                
            PersonDL.readFromFile("D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\Costumers.txt");
            
            // Clear the existing columns and bindings
            dataGridViewCostumers.DataSource = persons;
            //  dataGridViewCostumers.Refresh();
            dataGridViewCostumers.Visible = true;
           // dataGridViewCostumers.Show();
            
        }

        private void ViewCostumers_Load(object sender, EventArgs e)
        {

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
            dataGridViewCostumers.DataSource = dataTable;
        }

        private void dataGridViewCostumers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonToViewCostumers_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\Costumers.txt";
            PopulateDataGridView(filePath);
        }
    }
}
