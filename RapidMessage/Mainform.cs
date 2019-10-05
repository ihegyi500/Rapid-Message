using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;


namespace RapidMessage
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        //Kilépés gomb
        private void Button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Quality gomb
        private void Button_maint_Click(object sender, EventArgs e)
        {
            UpperButtonFunc(button_Quality, "Quality iroda");
        }

        //Engineering gomb
        private void Button_Engineering_Click(object sender, EventArgs e)
        {
            UpperButtonFunc(button_Engineering, "Mérnökség iroda");
        }

        //Pénzügy gomb
        private void Button_Finance_Click(object sender, EventArgs e)
        {
            UpperButtonFunc(button_Finance, "Pénzügy iroda");
        }

        //HR gomb
        private void Button_hr_Click(object sender, EventArgs e)
        {
            UpperButtonFunc(button_HR, "HR iroda");
        }

        //Gyár gomb
        private void Button_Factory_Click(object sender, EventArgs e)
        {
            UpperButtonFunc(button_Factory, "");
            factoryChoices choices = new factoryChoices(this);
            choices.Show();
        }

        //NPI gomb
        private void Button_NPI_Click(object sender, EventArgs e)
        {
            UpperButtonFunc(button_NPI, "NPI iroda");
        }

        //Porta gomb
        private void Button_Reception_Click(object sender, EventArgs e)
        {
            UpperButtonFunc(button_Reception, "Porta");
        }

        //A függvény, amit mindegyik felső gomb meghív
        private void UpperButtonFunc(Button actbutton, string labeltext)
        {
            workSpaceLabel.Text = labeltext;                        //Kiírja a gomb lenyomása után az aktuális munkakört
            paneljob.Left = actbutton.Left;                         //A kis panel oldalát a gomb oldalához igazítja
            paneljob.Top = actbutton.Bottom - paneljob.Height;      //A kis panel magasságát a gomb aljához igazítja
            paneljob.Width = actbutton.Width;                       //A kis panel szélességét a gomb szélességére állítja
        }
        //A függvény, amit mindegyik középső gomb meghív
        public void MiddleButtonFunc(string labeltext)
        {
            if (!issueLabel.Text.Contains(labeltext + "\n"))        //Ha nincs hibaüzenet, hozzáadja és bekékíti a gombot
            {
                this.ActiveControl.BackColor = Color.SteelBlue;
                issueLabel.Text += labeltext + "\n";
            }
            else                                                    //Ha van, akkor kitörli, és kivilágosítja a gombot
            {
                this.ActiveControl.BackColor = Color.WhiteSmoke;
                issueLabel.Text = issueLabel.Text.Replace(labeltext + "\n", "");
            }

        }

        //Küldés gomb
        private void Button_send_Click(object sender, EventArgs e)
        {
            MessageHandler msh = new MessageHandler(this);
           
        }

        //Szkenner gomb
        private void Button_Barcode_Click(object sender, EventArgs e)
        {
            MiddleButtonFunc("Vonalkódolvasóval kapcsolatos probléma");
        }

        //Nyomtató gomb
        private void Button_Printer_Click(object sender, EventArgs e)
        {
            MiddleButtonFunc("Nyomtatóval kapcsolatos probléma");
        }

        //WiFi gomb
        private void Button_Network_Click(object sender, EventArgs e)
        {
            MiddleButtonFunc("Hálózati probléma");
        }

        //Konnektor gomb
        private void Button_Connector_Click(object sender, EventArgs e)
        {
            MiddleButtonFunc("Elektronikai probléma");
        }

        //Telefon gomb
        private void button_Mobile_Click(object sender, EventArgs e)
        {
            Mobile choices = new Mobile(this);
            choices.Show();
        }

        //Szoftver gomb
        private void button_Software_Click(object sender, EventArgs e)
        {
            Software choices = new Software(this);
            choices.Show();
        }

        //PC gomb
        private void button_PC_Click(object sender, EventArgs e)
        {
            PC choices = new PC(this);
            choices.Show();
        }

        //Törlő gomb
        private void button_delete_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //Esc-re kilépés
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        public string getLoc() { return workSpaceLabel.Text; }
        public string getType() { return issueLabel.Text; }
        public string getDesc() { return DescrTextBox.Text; }
        public string getName() { return textBox_Name.Text; }
        public string getInfo() { return textBox_Info.Text; }
        public void setLoc(string loc) { workSpaceLabel.Text = loc; }
    }
}
