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
    public partial class SignInMenu : Form
    {
        DataTable table = new DataTable("table");
       
        private string userName;
        private string password;
        public SignInMenu()
        {
            InitializeComponent();
        }
        public string GetUserName()
        {
            return userName;
        }
        public string GetPassword()
        {
            return password;
        }
        private void SignInMenu_Load(object sender, EventArgs e)
        {
  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignInMenu signInForm = new SignInMenu();
      

            string username = txbName.Text;
            string password = txbPass.Text;

            PersonBL user = new PersonBL(username, password);

                string role = PersonBL.checkUserRole(username, password);
            bool check = PersonBL.isUserNameAvailable(username);

            if(check)
            {
                bool flag = PersonBL.SetUserRole(role, user);


                if (flag == true)
                {

                    AdminBL a = new AdminBL(role);
                    PersonBL n = new PersonBL(role);
                    CostumerBL c = new CostumerBL();

                    if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    

                    else if (role.Equals("Costumer", StringComparison.OrdinalIgnoreCase))
                    {
                        CostumerForm customerForm = new CostumerForm();
                        customerForm.Show();
                    }
                    else if (role.Equals("costumer", StringComparison.OrdinalIgnoreCase))
                    {
                        CostumerForm customerForm = new CostumerForm();
                        customerForm.Show();
                    }

                }

                else if (flag == false)
                {
                    MessageBox.Show("Invalid Role Type");
                }
                if (role == null)
                {
                    MessageBox.Show("Invalid Role ");
                }


                 

                
            }
            else
            {
                MessageBox.Show("UserName Is Not Available");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(txbName,txbPass);


        }
        private static void ClearTextBoxes(TextBox txbName,TextBox txbPass)
        {
            
            txbName.Text = " ";
            txbPass.Text = " ";
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            TextBox text = new TextBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Close();

          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
                if (checkBox1.Checked)
                {
               
                    button3.Visible = true;
                }
                else
                {
                   
                    button3.Visible = false;
                }
            

        }

      
    }
}
