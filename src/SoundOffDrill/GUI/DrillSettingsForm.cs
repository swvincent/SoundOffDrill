using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoundOffDrill.Biz;
using SoundOffDrill.Data;

namespace SoundOffDrill.GUI
{
    public partial class DrillSettingsForm : Form
    {
        public DrillSettingsForm()
        {
            InitializeComponent();

            var mapper = new JsonMapper("Cards.json");
            var cards = mapper.RetrieveList<Card>("Cards");

            cardsListBox.DataSource = cards;
        }
    }
}
