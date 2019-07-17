using System;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson10B
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine("NextButtonClick");
            Program.Forms[FormName.MAIN_FORM].Show();
            this.Hide();
        }
    }
}
