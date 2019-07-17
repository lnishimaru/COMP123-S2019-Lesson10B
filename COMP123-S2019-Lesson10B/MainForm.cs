using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson10B
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //ImperialUnitRadioButton.Checked
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           // try
           // {
           //     Application.Exit();
           // }
           // catch (Exception exception)
           // {
           //     Debug.WriteLine("Application Exception: " + exception.Message);
           // }
            
            BackButton_Click(sender, e);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.START_FORM].Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.END_FORM].Show();
            this.Hide();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
