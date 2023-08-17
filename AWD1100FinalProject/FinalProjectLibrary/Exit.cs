using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FinalProjectLibrary
{
    public class Exit
    {
        public static void ExitProgram()
        {
            DialogResult dialog = MessageBox.Show(
                "Do you really want to exit?",
                "Exit Now",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
