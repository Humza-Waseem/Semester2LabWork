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
using WindowsFormsApp1.UI;

namespace WindowsFormsApp1
{
    public partial class CostumerForm : Form
    {
        public CostumerForm()
        {
            InitializeComponent();
        }

        private void CostumerForm_Load(object sender, EventArgs e)
        {

        }

        private void AddCarsButton_Click(object sender, EventArgs e)
        {
            RentACarForm form = new RentACarForm();
            form.Show();
        }

        private void AvailabilityCheck_Click(object sender, EventArgs e)
        {
            AvailabiltyMenu a = new AvailabiltyMenu();
            a.Show();

        }

        private void ViewCars_Click(object sender, EventArgs e)
        {
            ViewCars view = new ViewCars();
            view.Show();
        }

        private void CheckPrice_Click(object sender, EventArgs e)
        {
            CheckPrice c = new CheckPrice();
            c.Show();
        }

        private void GiveFeedbacks_Click(object sender, EventArgs e)
        {
            GiveFeedBack give = new GiveFeedBack();
            give.Show();

        }

        private void NotificationCheck_Click(object sender, EventArgs e)
        {
            ShowNotifications showe = new ShowNotifications();
            showe.Show();
                
        }

        /*   private void iDrive_TextChanged(object sender, EventArgs e)
           {

           }

           /*    private void Idrive_TextChanged(object sender, EventArgs e)
               {
                   // Create a new instance of the ImageForm
                   ImageForm imageForm = new ImageForm();

                   // Set the image in the ImageForm
                   imageForm.SetImage(((PictureBox)sender).Image);

                   // Display the ImageForm
                   imageForm.Show();
               }*/
    }
}
