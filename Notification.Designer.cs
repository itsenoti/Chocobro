
namespace Chocobro
{
    partial class Notification
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
            this.notifItemName = new System.Windows.Forms.Label();
            this.notifInformation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifItemName
            // 
            this.notifItemName.AutoSize = true;
            this.notifItemName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifItemName.Location = new System.Drawing.Point(10, 36);
            this.notifItemName.Name = "notifItemName";
            this.notifItemName.Size = new System.Drawing.Size(285, 33);
            this.notifItemName.TabIndex = 0;
            this.notifItemName.Text = "Rarefied Woodsteak";
            this.notifItemName.Click += new System.EventHandler(this.notifItemName_Click);
            // 
            // notifInformation
            // 
            this.notifInformation.AutoSize = true;
            this.notifInformation.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifInformation.Location = new System.Drawing.Point(12, 81);
            this.notifInformation.Name = "notifInformation";
            this.notifInformation.Size = new System.Drawing.Size(311, 23);
            this.notifInformation.TabIndex = 1;
            this.notifInformation.Text = "Rhaktika Greatwood - 13.5, 18.45";
            this.notifInformation.Click += new System.EventHandler(this.notifInformation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(453, 149);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notifInformation);
            this.Controls.Add(this.notifItemName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notification";
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notifItemName;
        private System.Windows.Forms.Label notifInformation;
        private System.Windows.Forms.Label label1;
    }
}