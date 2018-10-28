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

namespace SoundOffDrill.GUI
{
    public partial class DrillForm : Form
    {
        private Drill drill;

        public DrillForm(Drill drill)
        {
            InitializeComponent();

            this.drill = drill;
            wordTextBox.Text = drill.CurrentWord();
        }

        private void nextWordButton_Click(object sender, EventArgs e)
        {
            wordTextBox.Text = drill.NextWord();
        }

        private void prevWordButton_Click(object sender, EventArgs e)
        {
            wordTextBox.Text = drill.PrevWord();
        }

        private void PrevCard_Click(object sender, EventArgs e)
        {
            DeckPosition deckPos = (DeckPosition)Convert.ToInt32((sender as Button).Tag);
            drill.PrevCard(deckPos);
            wordTextBox.Text = drill.CurrentWord();
        }

        private void NextCard_Click(object sender, EventArgs e)
        {
            DeckPosition deckPos = (DeckPosition)Convert.ToInt32((sender as Button).Tag);
            drill.NextCard(deckPos);
            wordTextBox.Text = drill.CurrentWord();
        }
    }
}
