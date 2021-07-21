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
    public partial class Notification : Form
    {
        string item = Constants.EMPTY_STRING;
        string loc = Constants.EMPTY_STRING;
        string x = Constants.EMPTY_STRING;
        string y = Constants.EMPTY_STRING;

        public Notification(string itemNAme, string location, string xCoordinate, string yCoordinate)
        {
            InitializeComponent();
            this.item = itemNAme;
            this.loc = location;
            this.x = xCoordinate;
            this.y = yCoordinate;
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            notifItemName.Text = this.item;
            notifInformation.Text = this.loc + " - " + "X:" + this.x + " Y:" + this.y;

            // Set the notification on top of any other app
            this.TopMost = true;
            // Place the notification at bottom right of the screen
            Rectangle screen = Screen.GetWorkingArea(this);
            this.Location = new Point(
                screen.Right - Size.Width,
                screen.Bottom - Size.Height
            );

            // Once notification is shown, it has 10 seconds before it disappears automatically
            Timer tmr = new Timer();
            tmr.Tick += delegate
            {
                this.Close();
            };

            tmr.Interval = (int)TimeSpan.FromMilliseconds(10000).TotalMilliseconds;
            tmr.Start();

        }

        private void notifItemName_Click(object sender, EventArgs e)
        {

        }

        private void notifInformation_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
