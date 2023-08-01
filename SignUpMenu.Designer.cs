
namespace WindowsFormsApp1
{
    partial class SignUpMenu
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbReEnteredPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(179, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Welcome New User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(167, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "UserName";
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbName.Location = new System.Drawing.Point(254, 145);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(198, 20);
            this.txbName.TabIndex = 12;
            // 
            // txbRole
            // 
            this.txbRole.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRole.Location = new System.Drawing.Point(254, 282);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(198, 20);
            this.txbRole.TabIndex = 13;
            this.txbRole.TextChanged += new System.EventHandler(this.txbRole_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(153, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter Password:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(116, 335);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Prove You Are Human";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearButton.Location = new System.Drawing.Point(320, 373);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(424, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Register";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(64, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 39);
            this.button2.TabIndex = 18;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbPass
            // 
            this.txbPass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPass.Location = new System.Drawing.Point(254, 192);
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(198, 20);
            this.txbPass.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(153, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Enter Role:";
            // 
            // txbReEnteredPass
            // 
            this.txbReEnteredPass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txbReEnteredPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbReEnteredPass.Location = new System.Drawing.Point(254, 236);
            this.txbReEnteredPass.Name = "txbReEnteredPass";
            this.txbReEnteredPass.Size = new System.Drawing.Size(198, 20);
            this.txbReEnteredPass.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(139, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Re-Enter Password";
            // 
            // SignUpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.neon1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbReEnteredPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbRole);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Name = "SignUpMenu";
            this.Text = "SignUpMenu";
            this.Load += new System.EventHandler(this.SignUpMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbReEnteredPass;
        private System.Windows.Forms.Label label5;
    }
}