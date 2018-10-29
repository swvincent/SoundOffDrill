# region LICENSE
///////////////////////////////////////////////////////////////////////////////
// MIT License
//
// Copyright 2018 Scott W. Vincent
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
///////////////////////////////////////////////////////////////////////////////
#endregion LICENSE

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
using SoundOffDrill.Util.WinFormsExtensions;

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

            wordTextBox.AutoSize = false;
        }

        #region Buttons

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

        #endregion Buttons
        
        private void wordTextBox_SizeChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            tb.FontAutoResize("1234567890");
        }
    }
}
