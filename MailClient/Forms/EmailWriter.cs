using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using MimeKit;
using System.IO;

namespace MailClient
{
    public partial class Write : MetroFramework.Forms.MetroForm
    {
        private string address;
        private string pw;
        Timer t = new Timer();
        private string path= "";
        //private MetroFramework.Components.MetroStyleManager Style;


        public Write(string MailAddress, string password, MetroFramework.MetroThemeStyle style)
        {
            InitializeComponent();
            this.address = MailAddress;
            this.pw = password;
            this.StyleManager = Style;
            Style.Theme = style;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);
            t.Start();


            tileDate.Text = DateTime.Now.ToLongDateString();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            lblTime.Text = time;
        }

        void sendMail(string from, string pass, string to, string cc, string subject, string body)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(address, pw);

            MailMessage mm = new MailMessage(address, to, subject, body);

            if (path != "")
            {
                var getAttachment = new Attachment(path);
                mm.Attachments.Add(getAttachment);
            }
            
            
            if (cc != null && cc != "")
            {
                MailAddress ma = new MailAddress(cc);
                mm.CC.Add(ma);
            }
            mm.Body = body;
            mm.IsBodyHtml = true;

            //mm.BodyEncoding = Encoding.Unicode;
            
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            string subject, body, cc, to, from, pass;
            subject = txtboxSubject.Text;
            body = txtboxMessage.Text;
            cc = txtboxCC.Text;
            to = txtboxEmail.Text;
            from = "";
            pass = "";
            if (subject == null)
            {
                subject = "";
            }
            if (cc == null)
            {
                cc = "";
            }
            try
            {
                sendMail(from, pass, to, cc, subject, body);
                MessageBox.Show("E-mail sent successfully");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Please fill the neccesary data");
            }

        }

        private void tileEmail_Click(object sender, EventArgs e)
        {
            tileEmail.Visible = false;
            tileEmail.Height = 45;
            tileEmail.Width = 824;
            tileEmail.Location = new Point(27, 80);
            txtboxEmail.Location = new Point(111, 13);
            txtboxEmail.Height = 23;
            txtboxEmail.Width = 698;
            bunifuTransition1.ShowSync(tileEmail);
        }

        private void tileCC_Click(object sender, EventArgs e)
        {
            tileCC.Visible = false;
            tileCC.Height = 45;
            tileCC.Width = 824;
            tileCC.Location = new Point(27, 131);
            txtboxCC.Location = new Point(111, 13);
            txtboxCC.Height = 23;
            txtboxCC.Width = 698;
            bunifuTransition1.ShowSync(tileCC);
        }

        private void tileSubject_Click(object sender, EventArgs e)
        {
            tileSubject.Visible = false;
            tileSubject.Height = 45;
            tileSubject.Width = 824;
            tileSubject.Location = new Point(27, 182);
            txtboxSubject.Location = new Point(111, 13);
            txtboxSubject.Height = 23;
            txtboxSubject.Width = 698;
            bunifuTransition1.ShowSync(tileSubject);
        }

        private void tileMessage_Click(object sender, EventArgs e)
        {
            tileMessage.Visible = false;
            tileMessage.Height = 252;
            tileMessage.Width = 824;
            tileMessage.Location = new Point(27, 233);
            txtboxMessage.Location = new Point(111, 15);
            txtboxMessage.Height = 222;
            txtboxMessage.Width = 698;
            bunifuTransition1.ShowSync(tileMessage);

            tileSend.Visible = false;
            tileSend.Height = 45;
            tileSend.Width = 824;
            tileSend.Location = new Point(27, 491);
            btnSend.Location = new Point(111, 13);
            btnSend.Height = 19;
            btnSend.Width = 698;
            bunifuTransition1.ShowSync(tileSend);
        }

        private void attachment_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fbd = new OpenFileDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    path = fbd.FileName;
                }
            }
        }
    }
}