using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace RapidMessage
{
    class MessageHandler
    {
        Mainform form;
        //email és SMTP kliens oszályok példányosítása
        MailMessage mail = new MailMessage();
        SmtpClient SmtpServer = new SmtpClient();

        public MessageHandler(Mainform form)
        {
            this.form = form;
            //email és SMTP attribútumok inicializálása
            mail.From = new MailAddress(Properties.Settings.Default.Sender);
            mail.To.Add(Properties.Settings.Default.Receivers);
            mail.IsBodyHtml = true;
            SmtpServer.Host = Properties.Settings.Default.Server;
            SmtpServer.Port = Properties.Settings.Default.Serverport;
            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            mail.Body = "Kedves IT osztály!" + "<br>";

            if (form.getLoc() == "" || form.getType() == "" || form.getName() == "")
            {
                string errMsg = "Hiba!\n";
                if (form.getLoc() == "")
                    errMsg += "Probléma helyének megjelölése kötelező!(1-es lépés)\n" +
                                    "Error! Missing location! (Step 1)\n" +
                                    "Помилка! Відсутнє місце розташування! (Крок 1)\n\n";
                if (form.getType() == "")
                    errMsg += "Probléma megjelölése kötelező! (2-es lépés)\n" +
                                "Error! Missing issue! (Step 2)\n" +
                                "Помилка!Відсутнє питання!(Крок 2)\n\n";
                if (form.getName() == "")
                    errMsg += "Név beírása kötelező! (3-as lépés)\n" +
                                   "Error! Missing name! (Step 3)\n" +
                                   "Помилка! Відсутнє ім'я! (Крок 3)";
                MessageBox.Show(errMsg, "Email küldés hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    mail.Subject = form.getLoc() + " - " + form.getType().Replace("\n", " ");

                    mail.Body += "A feladatkörötökbe tartozó probléma/igénylés történt az alábbi helyen: " +
                                     form.getLoc() + "<br>" +
                                    "A hiba/igény típusa:<br>" + form.getType().Replace("\n", "<br>") +
                                    "<br>Egyéb megjegyzés: " + form.getDesc() +
                                    "<br><br>Üdvözlettel:" + "<br>" +
                                    form.getName() + "<br>" + form.getInfo();
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
    }
}
