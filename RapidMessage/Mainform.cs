using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;


namespace RapidMessage
{
    public partial class Mainform : Form
    {
        //email és SMTP kliens objektum deklarálása
        public MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient();

        public Mainform()
        {
            InitializeComponent();
            //email és SMTP attribútumok inicializálása
            mail.From = new MailAddress(Properties.Settings.Default.Sender);
            mail.To.Add(Properties.Settings.Default.Receivers);
            mail.Body = "Kedves IT osztály!" + "<br>";
            mail.IsBodyHtml = true;
            SmtpServer.Host = Properties.Settings.Default.Server;
            SmtpServer.Port = Properties.Settings.Default.Serverport;
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
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
            if (workSpaceLabel.Text == "" || issueLabel.Text == "" || textBox_Name.Text == "")
            {
                if (workSpaceLabel.Text == "")
                    MessageBox.Show("Hiba! Probléma helyének megjelölése kötelező! (1-es lépés)\n" +
                                    "Error! Missing location! (Step 1)\n" +
                                    "Помилка! Відсутнє місце розташування! (Крок 1)\n", "Email küldés hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (issueLabel.Text == "")
                    MessageBox.Show("Hiba! Probléma megjelölése kötelező! (2-es lépés)\n" +
                                    "Error! Missing issue! (Step 2)\n" +
                                    "Помилка!Відсутнє питання!(Крок 2)", "Email küldés hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (textBox_Name.Text == "")
                    MessageBox.Show("Hiba! Név beírása kötelező! (3-as lépés)\n" +
                                    "Error! Missing name! (Step 3)\n" +
                                    "Помилка! Відсутнє ім'я! (Крок 3)", "Email küldés hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mail.Subject = workSpaceLabel.Text + " - " + issueLabel.Text.Replace("\n", " ");

                    mail.Body += "A feladatkörötökbe tartozó probléma/igénylés történt az alábbi helyen: " +
                                     workSpaceLabel.Text + "<br>" +
                                    "A hiba/igény típusa:<br>" + issueLabel.Text.Replace("\n", "<br>") + 
                                    "<br>Egyéb megjegyzés: " + DescrTextBox.Text +
                                    "<br><br>Üdvözlettel:" + "<br>" +
                                    textBox_Name.Text + "<br>" + textBox_Info.Text;
                    Cursor.Current = Cursors.WaitCursor;
                    SmtpServer.Send(mail);
                    MessageBox.Show("\t\tEmail sikeresen elküldve!\n" +
                                    "Az informatika osztály egy munkatársa hamarosan felveszi a kapcsolatot a bejelentővel!\n" +
                                    "\t\tEmail has been sent successfully!" +
                                    "\n\tAn IT colleague will soon have a contact with the applicant!\n" +
                                    "\t\tЕлектронну пошту успішно надіслано!\n" +
                                    "\tКолега ІТ скоро зв'яжеться з заявником!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba a levél elküldése során: " + ex.Message, "Email küldés hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ex.InnerException != null)
                        MessageBox.Show("Részletes probléma:   " + ex.InnerException);
                }
            }
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
    }
}
