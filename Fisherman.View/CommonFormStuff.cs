using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fisherman.Forms
{
    class CommonFormStuff
    {
        public static void ShowMessage(string text)
        {
            MessageBox.Show(text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool WarnUser(string text)
        {
            if (MessageBox.Show(text, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }

        public static void ShowErrorMessage(string text)
        {
            MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
