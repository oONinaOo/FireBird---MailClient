using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit;
using MimeKit;
using System.Text.RegularExpressions;

namespace MailClient
{
 
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
            StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;

        }

        private void bunifuTileButton1_Click(object sender, EventArgs ev)
        {
            try
            {
                using (var client = new ImapClient())
                {

                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    client.Connect("imap.gmail.com", 993, true);

                    client.AuthenticationMechanisms.Remove("XOAUTH2");

                    client.Authenticate(emailText.Text, pwText.Text);

                    client.Disconnect(true);

                    try
                    {
                        FileHandler writeData = new FileHandler(emailText.Text, pwText.Text);
                        writeData.writeDataFile();
                        writeData.SavePassword();
                        
                    }

                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                    MainForm main = new MainForm(emailText.Text, pwText.Text);
                    main.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Wrong e-mail address and password combo. Try again");
            }
            




        }
        
        private void mail_Validated(object sender, EventArgs e)
        {
            error.SetError(emailText, "");
        }

        private void mail_Validating(object sender,
                 System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!validMail(emailText.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                emailText.Select(0, emailText.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.error.SetError(emailText, errorMsg);
            }
        }
        public bool validMail(string emailAddress, out string errorMessage)
        {
            // Confirm that the e-mail address string is not empty.
            if (emailAddress.Length == 0)
            {
                errorMessage = "e-mail address is required.";
                return false;
            }

            // Confirm that there is an "@" and a "." in the e-mail address, and in the correct order.
            if (Regex.IsMatch(emailAddress, @"^([a-zA-Z0-9_\-” +
        @”\.]+)@((\[[0-9]{1,3}" +
     @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
     @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
               
                    errorMessage = "";
                    return true;
                
            }

            errorMessage = "e-mail address must be valid e-mail address format.\n" +
               "For example 'someone@example.com' ";
            return false;
        }

        private void pwText_KeyDown(object sender, KeyEventArgs ew)
        {
            
            if (ew.KeyCode == Keys.Enter)
            {
                try
                {
                    using (var client = new ImapClient())
                    {

                        client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                        client.Connect("imap.gmail.com", 993, true);

                        client.AuthenticationMechanisms.Remove("XOAUTH2");

                        client.Authenticate(emailText.Text, pwText.Text);

                        client.Disconnect(true);

                        try
                        {
                            FileHandler writeData = new FileHandler(emailText.Text, pwText.Text);
                            writeData.writeDataFile();
                            writeData.SavePassword();

                        }

                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                        }
                        MainForm main = new MainForm(emailText.Text, pwText.Text);
                        main.Show();
                        this.Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("Wrong e-mail address and password combo. Try again");
                }
            }
        }
    }
}
