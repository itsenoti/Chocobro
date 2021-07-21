using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocobro
{
    public partial class Alarms : Form
    {
        public Alarms()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Alarms_Load(object sender, EventArgs e)
        {
            // Eorzean Time
            timer.Start();

            // Get alarms list
            getItemsFromTextFile();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblAlarmsEorzianTimeClock_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int eorzea_hh = int.Parse(DateTime.Now.getEorzeaTime().ToString("hh"));
            int eorzea_ss = int.Parse(DateTime.Now.getEorzeaTime().ToString("mm"));

            if (eorzea_ss == 60)
            {
                eorzea_ss = 00;
                eorzea_hh++;
            }

            if (eorzea_hh == 60)
            {
                eorzea_hh = 00;
            }

            string currentEorzeaTime = eorzea_hh.ToString() + ':' + eorzea_ss.ToString();

            lblAlarmsEorzianTimeClock.Text = eorzea_hh.ToString("D2") + ":" + eorzea_ss.ToString("D2");
        }

        private void showAlarm(string itemName, string location, string x, string y)
        {
            niAlarmNotif.BalloonTipTitle = itemName;
            niAlarmNotif.BalloonTipText = location + " - " + x + "-" +y;
            niAlarmNotif.BalloonTipIcon = ToolTipIcon.None;
            niAlarmNotif.ShowBalloonTip(30000);
        }

        private void btnAlarmsAddItem_Click(object sender, EventArgs e)
        {
            Notification notif = new Notification("Abalathian Mistletoe", "The Sea of Clouds", "33.1", "23.1");
            notif.Show();
        }

        private async void getItemsFromTextFile()
        {
            int counter = 0;
            string[] itemInfo = Constants.EMPTY_LIST;
            AlarmsListItems itemsList = new AlarmsListItems();
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@"..\..\ref\alarmslist.txt");
            while ((line = file.ReadLine()) != null)
            {
                itemInfo = line.Split(',');
                clbAlarmsListItems.Items.Add(itemInfo[0]);
            }

            file.Close();
        }
    }
}
