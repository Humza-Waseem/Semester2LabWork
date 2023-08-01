
namespace WindowsFormsApp1
{
    partial class CostumerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RentACar = new System.Windows.Forms.Button();
            this.AvailabilityCheck = new System.Windows.Forms.Button();
            this.ViewCars = new System.Windows.Forms.Button();
            this.CheckPrice = new System.Windows.Forms.Button();
            this.GiveFeedbacks = new System.Windows.Forms.Button();
            this.NotificationCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RentACar
            // 
            this.RentACar.BackColor = System.Drawing.Color.Silver;
            this.RentACar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentACar.ForeColor = System.Drawing.Color.DarkCyan;
            this.RentACar.Location = new System.Drawing.Point(27, 126);
            this.RentACar.Name = "RentACar";
            this.RentACar.Size = new System.Drawing.Size(170, 34);
            this.RentACar.TabIndex = 4;
            this.RentACar.Text = "RENT A CAR";
            this.RentACar.UseVisualStyleBackColor = false;
            this.RentACar.Click += new System.EventHandler(this.AddCarsButton_Click);
            // 
            // AvailabilityCheck
            // 
            this.AvailabilityCheck.BackColor = System.Drawing.Color.Silver;
            this.AvailabilityCheck.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailabilityCheck.ForeColor = System.Drawing.Color.DarkCyan;
            this.AvailabilityCheck.Location = new System.Drawing.Point(27, 180);
            this.AvailabilityCheck.Name = "AvailabilityCheck";
            this.AvailabilityCheck.Size = new System.Drawing.Size(170, 34);
            this.AvailabilityCheck.TabIndex = 5;
            this.AvailabilityCheck.Text = "AVAILABILITY";
            this.AvailabilityCheck.UseVisualStyleBackColor = false;
            this.AvailabilityCheck.Click += new System.EventHandler(this.AvailabilityCheck_Click);
            // 
            // ViewCars
            // 
            this.ViewCars.BackColor = System.Drawing.Color.Silver;
            this.ViewCars.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCars.ForeColor = System.Drawing.Color.DarkCyan;
            this.ViewCars.Location = new System.Drawing.Point(27, 231);
            this.ViewCars.Name = "ViewCars";
            this.ViewCars.Size = new System.Drawing.Size(170, 34);
            this.ViewCars.TabIndex = 6;
            this.ViewCars.Text = "VIEW CARS";
            this.ViewCars.UseVisualStyleBackColor = false;
            this.ViewCars.Click += new System.EventHandler(this.ViewCars_Click);
            // 
            // CheckPrice
            // 
            this.CheckPrice.BackColor = System.Drawing.Color.Silver;
            this.CheckPrice.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckPrice.ForeColor = System.Drawing.Color.DarkCyan;
            this.CheckPrice.Location = new System.Drawing.Point(27, 285);
            this.CheckPrice.Name = "CheckPrice";
            this.CheckPrice.Size = new System.Drawing.Size(170, 34);
            this.CheckPrice.TabIndex = 7;
            this.CheckPrice.Text = "CHECK PRICE";
            this.CheckPrice.UseVisualStyleBackColor = false;
            this.CheckPrice.Click += new System.EventHandler(this.CheckPrice_Click);
            // 
            // GiveFeedbacks
            // 
            this.GiveFeedbacks.BackColor = System.Drawing.Color.Silver;
            this.GiveFeedbacks.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiveFeedbacks.ForeColor = System.Drawing.Color.DarkCyan;
            this.GiveFeedbacks.Location = new System.Drawing.Point(27, 338);
            this.GiveFeedbacks.Name = "GiveFeedbacks";
            this.GiveFeedbacks.Size = new System.Drawing.Size(170, 34);
            this.GiveFeedbacks.TabIndex = 8;
            this.GiveFeedbacks.Text = "GIVE FEEDBACKS";
            this.GiveFeedbacks.UseVisualStyleBackColor = false;
            this.GiveFeedbacks.Click += new System.EventHandler(this.GiveFeedbacks_Click);
            // 
            // NotificationCheck
            // 
            this.NotificationCheck.BackColor = System.Drawing.Color.Silver;
            this.NotificationCheck.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationCheck.ForeColor = System.Drawing.Color.DarkCyan;
            this.NotificationCheck.Location = new System.Drawing.Point(27, 390);
            this.NotificationCheck.Name = "NotificationCheck";
            this.NotificationCheck.Size = new System.Drawing.Size(170, 34);
            this.NotificationCheck.TabIndex = 9;
            this.NotificationCheck.Text = "NOTIFICATIONS";
            this.NotificationCheck.UseVisualStyleBackColor = false;
            this.NotificationCheck.Click += new System.EventHandler(this.NotificationCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 79);
            this.label1.TabIndex = 12;
            this.label1.Text = "Costumer Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.SALE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(466, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 380);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // CostumerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wowCar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NotificationCheck);
            this.Controls.Add(this.GiveFeedbacks);
            this.Controls.Add(this.CheckPrice);
            this.Controls.Add(this.ViewCars);
            this.Controls.Add(this.AvailabilityCheck);
            this.Controls.Add(this.RentACar);
            this.DoubleBuffered = true;
            this.Name = "CostumerForm";
            this.Text = "CostumerForm";
            this.Load += new System.EventHandler(this.CostumerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RentACar;
        private System.Windows.Forms.Button AvailabilityCheck;
        private System.Windows.Forms.Button ViewCars;
        private System.Windows.Forms.Button CheckPrice;
        private System.Windows.Forms.Button GiveFeedbacks;
        private System.Windows.Forms.Button NotificationCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}