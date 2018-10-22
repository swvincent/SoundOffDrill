using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundOffDrill.GUI
{
    public partial class DrillForm : Form
    {
        public DrillForm()
        {
            InitializeComponent();
        }

        private void drillSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new DrillSettingsForm();
            f.Show();
        }
    }
}
