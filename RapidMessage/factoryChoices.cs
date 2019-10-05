using System;
using System.Windows.Forms;

namespace RapidMessage
{
    public partial class factoryChoices : Form
    {
        Mainform main;

        public factoryChoices(Mainform main)
        {
            InitializeComponent();
            this.main = main;

        }

        private void button_C1_Click(object sender, EventArgs e)
        {
            main.setLoc("Cella 1");
            this.Close();
        }

        private void button_C2_Click(object sender, EventArgs e)
        {
            main.setLoc("Cella 2");
            this.Close();
        }

        private void button_C3_Click(object sender, EventArgs e)
        {
            main.setLoc("Cella 3");
            this.Close();
        }

        private void button_C4_Click(object sender, EventArgs e)
        {
            main.setLoc("Cella 4");
            this.Close();
        }

        private void button_C6_Click(object sender, EventArgs e)
        {
            main.setLoc("Cella 6");
            this.Close();
        }

        private void button_Log_Click(object sender, EventArgs e)
        {
            main.setLoc("Logisztika");
            this.Close();
        }

        private void button_Maint_Click(object sender, EventArgs e)
        {
            main.setLoc("Karbantartás");
            this.Close();
        }

        private void button_Lab_Click(object sender, EventArgs e)
        {
            main.setLoc("Labor");
            this.Close();
        }

        private void button_FinIns_Click(object sender, EventArgs e)
        {
            main.setLoc("Végellenőrzés");
            this.Close();
        }
    }
}
