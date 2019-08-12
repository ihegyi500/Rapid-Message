using System.Drawing;

namespace RapidMessage
{
    public partial class PC : RapidMessage.Mobile
    {
        public PC(Mainform main) : base(main)
        {
            InitializeComponent();
            Mainlabel.Text = "PC-vel/laptoppal kapcsolatos?";
            Themebutton.Image = Image.FromFile(@"\\KUNSHUFP001\Siteshare\IT\Icons\PCs.png");
            button_MobileReq.Image = Image.FromFile(@"\\KUNSHUFP001\Siteshare\IT\Icons\addPClaptop.png");
            button_MobilIssue.Image = Image.FromFile(@"\\KUNSHUFP001\Siteshare\IT\Icons\wrongPClaptop.png");
        }

        protected override void IssueButtonChanger()
        {
            form1.MiddleButtonFunc("PC-vel/laptoppal kapcsolatos probléma");
            this.Close();
        }

        protected override void RequestButtonChanger()
        {
            form1.MiddleButtonFunc("Új PC/laptop igénylése");
            this.Close();
        }
    }
}
