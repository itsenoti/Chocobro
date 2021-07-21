
namespace Chocobro
{
    partial class Alarms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarms));
            this.btnAlarmsAddItem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAlarmsEorzianTimeClock = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.niAlarmNotif = new System.Windows.Forms.NotifyIcon(this.components);
            this.clbAlarmsListItems = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btnAlarmsAddItem
            // 
            this.btnAlarmsAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmsAddItem.Location = new System.Drawing.Point(15, 66);
            this.btnAlarmsAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlarmsAddItem.Name = "btnAlarmsAddItem";
            this.btnAlarmsAddItem.Size = new System.Drawing.Size(174, 58);
            this.btnAlarmsAddItem.TabIndex = 12;
            this.btnAlarmsAddItem.Text = "Refresh List";
            this.btnAlarmsAddItem.UseVisualStyleBackColor = true;
            this.btnAlarmsAddItem.Click += new System.EventHandler(this.btnAlarmsAddItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 35);
            this.label6.TabIndex = 13;
            this.label6.Text = "Eorzean Time";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblAlarmsEorzianTimeClock
            // 
            this.lblAlarmsEorzianTimeClock.AutoSize = true;
            this.lblAlarmsEorzianTimeClock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmsEorzianTimeClock.Location = new System.Drawing.Point(343, 8);
            this.lblAlarmsEorzianTimeClock.Name = "lblAlarmsEorzianTimeClock";
            this.lblAlarmsEorzianTimeClock.Size = new System.Drawing.Size(71, 37);
            this.lblAlarmsEorzianTimeClock.TabIndex = 14;
            this.lblAlarmsEorzianTimeClock.Text = "--:--";
            this.lblAlarmsEorzianTimeClock.Click += new System.EventHandler(this.lblAlarmsEorzianTimeClock_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 2900;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // niAlarmNotif
            // 
            this.niAlarmNotif.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niAlarmNotif.Icon = ((System.Drawing.Icon)(resources.GetObject("niAlarmNotif.Icon")));
            this.niAlarmNotif.Text = "notifyIcon1";
            this.niAlarmNotif.Visible = true;
            // 
            // clbAlarmsListItems
            // 
            this.clbAlarmsListItems.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAlarmsListItems.FormattingEnabled = true;
            this.clbAlarmsListItems.Location = new System.Drawing.Point(15, 157);
            this.clbAlarmsListItems.Name = "clbAlarmsListItems";
            this.clbAlarmsListItems.Size = new System.Drawing.Size(437, 556);
            this.clbAlarmsListItems.TabIndex = 15;
            // 
            // Alarms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 734);
            this.Controls.Add(this.clbAlarmsListItems);
            this.Controls.Add(this.lblAlarmsEorzianTimeClock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAlarmsAddItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Alarms";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Alarms";
            this.Load += new System.EventHandler(this.Alarms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAlarmsAddItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAlarmsEorzianTimeClock;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NotifyIcon niAlarmNotif;
        private System.Windows.Forms.CheckedListBox clbAlarmsListItems;
    }
}