using System.Drawing;

namespace RapidMessage
{
    public partial class Software : RapidMessage.Mobile
    {
        public Software(Mainform main) : base(main)
        {
            InitializeComponent();
            Mainlabel.Text = "Szoftverrel kapcsolatos?";
            Themebutton.Image = Image.FromFile(@"\\KUNSHUFP001\Siteshare\IT\Icons\soft.png");
            button_MobileReq.Image = Image.FromFile(@"\\KUNSHUFP001\Siteshare\IT\Icons\addsoft.png");
            button_MobilIssue.Image = Image.FromFile(@"\\KUNSHUFP001\Siteshare\IT\Icons\wrongsoft.png");
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
