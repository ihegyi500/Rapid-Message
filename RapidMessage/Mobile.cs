using System;
using System.Windows.Forms;

namespace RapidMessage
{
    public partial class Mobile : Form
    {
        protected Mainform form1;
        public Mobile()
        {
            InitializeComponent();
        }

        public Mobile(Mainform main) : this()
        {
            form1 = main;
        }

        private void button_MobileReq_Click(object sender, EventArgs e)
        {
            this.RequestButtonChanger();
        }

        private void button_MobilIssue_Click(object sender, EventArgs e)
        {
            this.IssueButtonChanger();
        }

        protected virtual void IssueButtonChanger()
        {
            form1.MiddleButtonFunc("Céges telefonnal kapcsolatos probléma");
            this.Close();
        }

        protected virtual void RequestButtonChanger()
        {
            form1.MiddleButtonFunc("Új telefon igénylése");
            this.Close();
        }

    }
}
