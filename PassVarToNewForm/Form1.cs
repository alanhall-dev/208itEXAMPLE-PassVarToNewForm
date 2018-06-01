using System;
using System.Windows.Forms;

namespace PassVarToNewForm
{
    public partial class Form1 : Form
    {
        public string passToForm = "Sent From Form 1";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPressMe_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(passToForm);
            f2.Show();
            this.Hide();
        }
    }
}