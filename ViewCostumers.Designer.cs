
namespace WindowsFormsApp1
{
    partial class ViewCostumers
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
            this.dataGridViewCostumers = new System.Windows.Forms.DataGridView();
            this.buttonToViewCostumers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostumers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCostumers
            // 
            this.dataGridViewCostumers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCostumers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewCostumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCostumers.Location = new System.Drawing.Point(27, 12);
            this.dataGridViewCostumers.Name = "dataGridViewCostumers";
            this.dataGridViewCostumers.Size = new System.Drawing.Size(751, 426);
            this.dataGridViewCostumers.TabIndex = 1;
            this.dataGridViewCostumers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCostumers_CellContentClick);
            // 
            // buttonToViewCostumers
            // 
            this.buttonToViewCostumers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonToViewCostumers.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToViewCostumers.ForeColor = System.Drawing.Color.White;
            this.buttonToViewCostumers.Location = new System.Drawing.Point(285, 373);
            this.buttonToViewCostumers.Name = "buttonToViewCostumers";
            this.buttonToViewCostumers.Size = new System.Drawing.Size(264, 52);
            this.buttonToViewCostumers.TabIndex = 2;
            this.buttonToViewCostumers.Text = "Click To View Costumers";
            this.buttonToViewCostumers.UseVisualStyleBackColor = false;
            this.buttonToViewCostumers.Click += new System.EventHandler(this.buttonToViewCostumers_Click);
            // 
            // ViewCostumers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonToViewCostumers);
            this.Controls.Add(this.dataGridViewCostumers);
            this.Name = "ViewCostumers";
            this.Text = "ViewCostumers";
            this.Load += new System.EventHandler(this.ViewCostumers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCostumers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCostumers;
        private System.Windows.Forms.Button buttonToViewCostumers;
    }
}