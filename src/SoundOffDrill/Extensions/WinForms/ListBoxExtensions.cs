using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoundOffDrill.Extensions.WinForms
{
    public static class ListBoxExtensions
    {
        public static void SelectAll(this ListBox listBox, bool selected)
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
    }
}
