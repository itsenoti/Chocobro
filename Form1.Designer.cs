
namespace Chocobro
{
    partial class Form1
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
            this.btnAlarms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlarms
            // 
            this.btnAlarms.Location = new System.Drawing.Point(12, 12);
            this.btnAlarms.Name = "btnAlarms";
            this.btnAlarms.Size = new System.Drawing.Size(131, 40);
            this.btnAlarms.TabIndex = 0;
            this.btnAlarms.Text = "Alarms";
            this.btnAlarms.UseVisualStyleBackColor = true;
            this.btnAlarms.Click += new System.EventHandler(this.btnAlarms_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlarms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlarms;
    }
}

