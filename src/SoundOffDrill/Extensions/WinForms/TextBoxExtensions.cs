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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SoundOffDrill.Extensions.WinForms
{
    public static class TextBoxExtensions
    {
        /// <summary>
        /// Automatically resize font in single line textbox based on
        /// textbox size and length of sample string
        /// </summary>
        /// <remarks>
        /// Based on https://stackoverflow.com/a/38932706 but fixed/simplified.
        /// Must set AutoSize = false on textbox and anchor it to container
        /// so it resizes. A bit of a hack, but it works.
        /// </remarks>
        /// <param name="tb">Textbox</param>
        /// <param name="s">String to use as reference for width</param>
        public static void FontAutoResize(this System.Windows.Forms.TextBox tb, string s)
        {
            if (s.Length > 0)
            { 
                SizeF stringSize;

                using (Graphics gfx = tb.CreateGraphics())
                {
                    // Get the size given the string and the font
                    stringSize = gfx.MeasureString(s, tb.Font);

                    double areaAvailable = tb.Height * tb.Width;
                    double areaRequired = stringSize.Width * stringSize.Height * 1.1;

                    if (areaAvailable / areaRequired > 1.2)
                    {
                        while (areaAvailable / areaRequired > 1.2)
                        {
                            tb.Font = new Font(tb.Font.FontFamily, tb.Font.Size * 1.1F);
                            stringSize = gfx.MeasureString(s, tb.Font);
                            areaRequired = stringSize.Width * stringSize.Height * 1.1;
                        }
                    }
                    else
                    {
                        while (areaRequired * 1.2 > areaAvailable)
                        {
                            tb.Font = new Font(tb.Font.FontFamily, tb.Font.Size / 1.1F);
                            stringSize = gfx.MeasureString(s, tb.Font);
                            areaRequired = stringSize.Width * stringSize.Height * 1.1;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Automatically resize font in single line textbox based on
        /// textbox size and current text
        /// </summary>
        /// <remarks>
        /// Based on https://stackoverflow.com/a/38932706 but fixed/simplified.
        /// Must set AutoSize = false on textbox and anchor it to container
        /// so it resizes. A bit of a hack, but it works.
        /// </remarks>
        /// <param name="tb">Textbox</param>
        public static void FontAutoResize(this System.Windows.Forms.TextBox tb)
        {
            FontAutoResize(tb, tb.Text);
        }
    }
}
