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
    public partial class Form1 : Form
    {
        public static string reviewsPath = "D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\Reviews.txt";
        public static string carsPath = "D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\cars.txt";
        // string usersPath = "D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\Users.txt";
        public static string AdminsPath = "D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\Admins.txt";
        public static string CostumersPath = "D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\Costumers.txt";
        public static string NotificationsPath = "D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\notifications.txt";
        public static string promoPath = "D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\PromoCodes.txt";
        public static string rentedCarsPath = "D:\\OOP\\BusinessApplicationGUI\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\RentedCars.txt";
        public Form1()
        {
            InitializeComponent();
           // GIF_FORM g = new GIF_FORM();
           // g.Show();
            //  Here we can also use static polymorphism

            PersonDL.readFromFile(AdminsPath);
            PersonDL.readFromFile(CostumersPath);
            CarDL.readCarsFromFile(carsPath);  
            AdminDL.ReadNotificationsFromFile(NotificationsPath);
            AdminDL.ReadPromo(promoPath); 
            CostumerDL.ReadReviews(reviewsPath);
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
           
            

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            // Create an instance of the SignInForm
            SignInMenu signInForm = new SignInMenu();

            // Show the SignInForm as a dialog and wait for the result
            DialogResult result = signInForm.ShowDialog();

            /*   if (result == DialogResult.OK)
               {
                   // Retrieve the username and password from the SignInForm
                   string username = signInForm.GetUserName();
                   string password = signInForm.GetPassword();

                   PersonBL user = new PersonBL(username, password);

                   string role = PersonBL.checkUserRole(username,password);

                   bool flag = PersonBL.SetUserRole(role, user);

                   if (role == null)
                   {
                       MessageBox.Show("Invalid Role ");
                   }
                   if (flag == true)
                   {

                     /*  AdminBL a = new AdminBL(role);
                       PersonBL n = new PersonBL(role);
                       CostumerBL c = new CostumerBL();

                       // Check the role and open the appropriate form

                       if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                       {
                           AdminForm adminForm = new AdminForm();
                           adminForm.Show();
                           //this.Close();
                       }
                       if (role.Equals("admin", StringComparison.OrdinalIgnoreCase))
                       {
                           AdminForm adminForm = new AdminForm();
                           adminForm.Show();
                           //this.Close();
                       }

                       else if (role.Equals("Costumer", StringComparison.OrdinalIgnoreCase))
                       {
                           CostumerForm customerForm = new CostumerForm();
                           customerForm.Show();
                           //this.Close();
                       }
                       else if (role.Equals("costumer", StringComparison.OrdinalIgnoreCase))
                       {
                           CostumerForm customerForm = new CostumerForm();
                           customerForm.Show();
                           //this.Close();
                       }


                   }
                   else
                   {
                       MessageBox.Show("Invalid Role Type");
                   }
               }*/
        }

        private void SignUp_Click_1(object sender, EventArgs e)
        {
            SignUpMenu form = new SignUpMenu();
            Form1 form1 = new Form1();

            SignUpMenu signUpForm = new SignUpMenu();
            if (signUpForm.ShowDialog() == DialogResult.OK)
            {
                // PersonBL user = signUpForm.GetUser();
                // MUserBL.SignUp(user, path);
                MessageBox.Show("Sign Up Successful!!");
            }



            form.Show();
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
