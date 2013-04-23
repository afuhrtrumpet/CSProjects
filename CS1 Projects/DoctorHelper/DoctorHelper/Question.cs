using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoctorHelper
{
    class Question
    {
        public static bool Ask(string question, string caption)
        {
            DialogResult result = MessageBox.Show(question, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) return true;
            return false;
        }
    }
}
