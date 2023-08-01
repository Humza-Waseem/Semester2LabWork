
namespace WindowsFormsApp1
{
    partial class GIF_FORM
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.CarWhiteGIF;
            this.pictureBox1.Location = new System.Drawing.Point(1, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 467);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(77, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 79);
            this.label1.TabIndex = 5;
            this.label1.Text = "CAR RENTAL SYSTEM";
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.BlueViolet;
            this.SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.Color.Black;
            this.SignIn.Location = new System.Drawing.Point(347, 170);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(111, 33);
            this.SignIn.TabIndex = 6;
            this.SignIn.Text = "SIGN IN";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.BlueViolet;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Black;
            this.Exit.Location = new System.Drawing.Point(567, 312);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(111, 33);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.BlueViolet;
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.Black;
            this.SignUp.Location = new System.Drawing.Point(567, 260);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(111, 33);
            this.SignUp.TabIndex = 8;
            this.SignUp.Text = "SIGN UP";
            this.SignUp.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(567, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "SIGN IN";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // GIF_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "GIF_FORM";
            this.Text = "GIF_FORM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Button button1;
    }
}