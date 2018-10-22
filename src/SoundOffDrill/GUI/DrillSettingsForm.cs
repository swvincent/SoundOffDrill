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

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            SelectAllCards(cardsListBox, true);
        }

        private void selectNoneButton_Click(object sender, EventArgs e)
        {
            SelectAllCards(cardsListBox, false);
        }

        private void SelectAllCards(ListBox listBox, bool selected)
        {
            int count = listBox.Items.Count;

            if (count > 0)
            {
                // BeginUpdate/EndUpdate prevents redrawing on
                // select (so it's speedier)
                listBox.BeginUpdate();

                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    listBox.SetSelected(i, selected);
                }

                // Selecting all seems to cause it to scroll to bottom
                listBox.TopIndex = 0;

                listBox.EndUpdate();
            }
        }

        private void DrillSettingsForm_Shown(object sender, EventArgs e)
        {
            // Call this on Shown instead of Constructor
            // or the scroll to top doesn't work :-(
            SelectAllCards(cardsListBox, true);
        }
    }
}
