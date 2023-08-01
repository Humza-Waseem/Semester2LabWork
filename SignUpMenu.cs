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
namespace WindowsFormsApp1
{
    public partial class SignUpMenu : Form
    {
        DataTable table = new DataTable("table");
        public SignUpMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(txbName, txbPass,txbRole, txbReEnteredPass);
        }
        private static void ClearTextBoxes(TextBox txbName, TextBox txbPass, TextBox txbRole,TextBox txbReEnteredPass)
        {

            txbName.Text = " ";
            txbPass.Text = " ";
            txbRole.Text = " ";
            txbReEnteredPass.Text = " ";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txbRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpMenu_Load(object sender, EventArgs e)
        {
            table.Columns.Add("UserName", Type.GetType("System.String"));
            table.Columns.Add("Password", Type.GetType("System.String"));
            table.Columns.Add("Role", Type.GetType("System.String"));

        //    checkAvailabilityOfUser(UserName, Password, Role);
            


            //table.Columns.Add("ID", Type.GetType("System.Int32"));
            // dataGridView1.DataSource = table;
        }
        // public static checkAvailabilityOfUserName()

        private  PersonBL checkAvailabilityOfUser()
        {

            if (PersonDL.persons.Count > 0)
            {
                bool flag = PersonBL.isUserNameAvailable(txbName.Text);


                if (flag == true)
                {
                    MessageBox.Show("UserName is  Already Available");

                    
                      return null;
                }
                if(txbPass.Text !=txbReEnteredPass.Text)
                {
                    MessageBox.Show("Passwords do not Match");
                }
                else if (txbName.Text != null && txbPass.Text != null && txbPass.Text != null && txbPass.Text == txbReEnteredPass.Text && (txbRole.Text == "costumer" || txbRole.Text == "Costumer" || txbRole.Text == "COSTUMER" || txbRole.Text == "customer"  || txbRole.Text == "Customer"))
                {
                    PersonBL person = new PersonBL(txbName.Text, txbPass.Text, txbRole.Text);
                    MessageBox.Show("User Created SuccessFully. You Can Sign In Now");
                    PersonDL.AddIntoPersonList(person);

                    PersonDL.storeIntoFile("D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\Costumers.txt", person);
                   // MessageBox.Show("added into File and List");
                    return person;

                }
                else if (txbRole.Text != "costumer" && txbRole.Text != "Costumer")
                {
                    MessageBox.Show("INVALID ROLE TYPE !!!!");
                    MessageBox.Show("Consider Changing the role !!!");



                }

            }
            return null;

        }




     

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           PersonBL check =  checkAvailabilityOfUser();
            if(check == null )
            {
                MessageBox.Show("Invalid Input ");
            }


        }
    }
}
