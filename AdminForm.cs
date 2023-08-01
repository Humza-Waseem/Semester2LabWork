using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp1.DL;
using WindowsFormsApp1.UI;
using WindowsFormsApp1.BL;


namespace WindowsFormsApp1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewReviews viewReviewsForm = new ViewReviews();
            viewReviewsForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewCostumers view = new ViewCostumers();
            view.Show();
        }

        private void ViewCarsButton_Click(object sender, EventArgs e)
        {
            ViewCars cars = new ViewCars();
            cars.Show();
        }

        private void VerifyUserButton_Click(object sender, EventArgs e)
        {
            verifyCostumer verify = new verifyCostumer();
            verify.Show();
            
        }

        private void RentedCarsButton_Click(object sender, EventArgs e)
        {
            RentedCarsMenu rent = new RentedCarsMenu();
            rent.Show();
        }

        private void AddCarsButton_Click(object sender, EventArgs e)
        {
            AddCarsForm addCars = new AddCarsForm();
            addCars.Show();
        }

        private void AvailabilityButton_Click(object sender, EventArgs e)
        {
            ViewAvailabilityOfCar a = new ViewAvailabilityOfCar();
            a.Show();
        }

        private void AddPromoButton_Click(object sender, EventArgs e)
        {
            AddPromo a = new AddPromo();
            a.Show();
        }

        private void RemoveCarButton_Click(object sender, EventArgs e)
        {
            RemoveCars remove = new RemoveCars();
            remove.Show();
        }

        private void NotifyButton_Click(object sender, EventArgs e)
        {
            NotifyAdmin n = new NotifyAdmin();
            n.Show();

        }

        private void ModifyCarButton_Click(object sender, EventArgs e)
        {
            ModifyCar car = new ModifyCar();
            car.Show();
        }

        private void SeeNotifications_Click(object sender, EventArgs e)
        {
            ShowNotifications showe = new ShowNotifications();
            showe.Show();

        }
    }
}
