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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void btnAlarms_Click(object sender, EventArgs e)
        {
            Alarms alarm = new Alarms();
            alarm.ShowDialog();
        }
    }
}
