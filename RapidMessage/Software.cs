using System.Drawing;

namespace RapidMessage
{
    public partial class Software : Mobile
    {
        public Software(Mainform main) : base(main)
        {
            InitializeComponent();
            Mainlabel.Text = "Szoftverrel kapcsolatos?";
        }

        protected override void IssueButtonChanger()
        {
            form1.MiddleButtonFunc("Szoftverrel kapcsolatos probléma");
            this.Close();
        }

        protected override void RequestButtonChanger()
        {
            form1.MiddleButtonFunc("Új szoftver igénylése");
            this.Close();
        }
    }
}
