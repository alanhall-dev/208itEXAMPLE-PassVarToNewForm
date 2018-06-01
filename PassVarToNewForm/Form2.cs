using System;
using System.Windows.Forms;

namespace PassVarToNewForm
{
    public partial class Form2 : Form
    {
        public string myString = "";
        public Form2(string passedFromForm1)
        {
            InitializeComponent();
            myString = passedFromForm1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblRandom.Text = myString;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}