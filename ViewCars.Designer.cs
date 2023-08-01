
namespace WindowsFormsApp1
{
    partial class ViewCars
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CarsDataGridView = new System.Windows.Forms.DataGridView();
            this.EXit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Location = new System.Drawing.Point(272, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "ENTER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(286, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Press Enter to View All Cars";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(252, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 117);
            this.label3.TabIndex = 15;
            this.label3.Text = "CARS";
            // 
            // CarsDataGridView
            // 
            this.CarsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CarsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.CarsDataGridView.BackgroundColor = System.Drawing.Color.Maroon;
            this.CarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsDataGridView.Location = new System.Drawing.Point(99, 247);
            this.CarsDataGridView.Name = "CarsDataGridView";
            this.CarsDataGridView.Size = new System.Drawing.Size(583, 278);
            this.CarsDataGridView.TabIndex = 16;
            this.CarsDataGridView.Visible = false;
            // 
            // EXit
            // 
            this.EXit.BackColor = System.Drawing.Color.DarkRed;
            this.EXit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.EXit.Location = new System.Drawing.Point(677, 12);
            this.EXit.Name = "EXit";
            this.EXit.Size = new System.Drawing.Size(111, 23);
            this.EXit.TabIndex = 17;
            this.EXit.Text = "EXIT";
            this.EXit.UseVisualStyleBackColor = false;
            this.EXit.Click += new System.EventHandler(this.EXit_Click);
            // 
            // ViewCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EXit);
            this.Controls.Add(this.CarsDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Name = "ViewCars";
            this.Text = "ViewCars";
            this.Load += new System.EventHandler(this.ViewCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView CarsDataGridView;
        private System.Windows.Forms.Button EXit;
    }
}