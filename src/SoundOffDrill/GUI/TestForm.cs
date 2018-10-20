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
using SoundOffDrill.Data;
using SoundOffDrill.Biz;

namespace SoundOffDrill.GUI
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

            var mapper = new JsonMapper("Cards.json");

            var outerCards = mapper.RetrieveList<OuterCard>("OuterCards");
            string outerCardsText = string.Join(Environment.NewLine, outerCards.Select(c => c.CardText));

            var innerCards = mapper.RetrieveList<Card>("InnerCards");
            string innerCardsText = string.Join(Environment.NewLine, innerCards.Select(c => c.CardText));

            textBox1.Text = outerCardsText + innerCardsText;
        }
    }
}
