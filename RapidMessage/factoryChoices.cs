using System;
using System.Windows.Forms;

namespace RapidMessage
{
    public partial class factoryChoices : Form
    {
        Mainform Form1;

        public factoryChoices(Mainform main)
        {
            InitializeComponent();
            Form1 = main;

        }

        private void button_C1_Click(object sender, EventArgs e)
        {
            Form1.workSpaceLabel.Text = "Cella 1";
            this.Close();
        }

        private void button_C2_Click(object sender, EventArgs e)
        {
            Form1.workSpaceLabel.Text = "Cella 2";
            this.Close();
        }

        private void button_C3_Click(object sender, EventArgs e)
        {
            Form1.workSpaceLabel.Text = "Cella 3";
            this.Close();
        }

        private void button_C4_Click(object sender, EventArgs e)
        {
            Form1.workSpaceLabel.Text = "Cella 4";
            this.Close();
        }

        private void button_C6_Click(object sender, EventArgs e)
        {
            Form1.workSpaceLabel.Text = "Cella 6";
            this.Close();
        }

        private void button_Log_Click(object sender, EventArgs e)
        {
            Form1.workSpaceLabel.Text = "Logisztika";
            this.Close();
        }

        private void button_Maint_Click(object sender, EventArgs e)
        {
            Form1.workSpaceLabel.Text = "Karbantartás";
            this.Close();
        }

        private void button_Lab_Click(object sender, EventArgs e)
        {
            Form1.workSpaceLabel.Text = "Labor";
            this.Close();
        }

        private void button_FinIns_Click(object sender, EventArgs e)
        {
            Form1.workSpaceLabel.Text = "Végellenőrzés";
            this.Close();
        }
    }
}
