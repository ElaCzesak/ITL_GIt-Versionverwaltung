using System;
using System.Drawing;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;

        }
    }
}
