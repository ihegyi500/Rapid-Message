using System.Drawing;

namespace RapidMessage
{
    public partial class PC : RapidMessage.Mobile
    {
        public PC(Mainform main) : base(main)
        {
            InitializeComponent();
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
