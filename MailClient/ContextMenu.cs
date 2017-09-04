using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit;
using MimeKit;
using System.IO;

namespace MailClient
{
    class ContextMenu
    {

        public ContextMenu()
        {
        }
        public ContextMenuStrip getContextMenu(ListView contentPanel, MouseEventArgs ep, int actualPage, IMailFolder type, Panel panel)
        {
            ContextMenuStrip rightClickMenu = new ContextMenuStrip();
            rightClickMenu.Items.Clear();

            rightClickMenu.Items.Add("Open").Name = "Open";
            int indexopen = rightClickMenu.Items.IndexOfKey("Open");
            rightClickMenu.Items[indexopen].Image = Properties.Resources.open_mail;
            rightClickMenu.Items[indexopen].Font = new Font(rightClickMenu.Font, FontStyle.Bold);

            rightClickMenu.Items.Add("Delete").Name = "Delete";
            int indexdelete = rightClickMenu.Items.IndexOfKey("Delete");
            rightClickMenu.Items[indexdelete].Image = Properties.Resources.delete_mail;

            rightClickMenu.ItemClicked += new ToolStripItemClickedEventHandler((sender, e) => item_Click(sender, e, ep, contentPanel, actualPage, type, panel));

            Point pt = contentPanel.PointToScreen(ep.Location);

            rightClickMenu.Show(pt);
            return rightClickMenu;
        }

        public void item_Click(Object sender, ToolStripItemClickedEventArgs e, MouseEventArgs ep, ListView list, int actualPage, IMailFolder type, Panel panel)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "Open":
                    buildMessage(getMessage(list, actualPage, type), panel);
                    break;

                case "Delete":   
                    break;
            }
        }
        public MimeMessage getMessage(ListView list, int page, IMailFolder type)
        {
            type.Open(FolderAccess.ReadWrite);
            int clicked = 0;

            foreach (ListViewItem item in list.SelectedItems)
            {
                clicked = item.Index;
            }
            int boxSize = type.Count;
            int getIndex = boxSize - ((page - 1) * 20) - clicked;

            var message = type.GetMessage(getIndex - 1);

            return message;
        }

        public void buildMessage(MimeMessage message, Panel panel)
        {
            PictureBox back = new PictureBox();
            back.Image = Properties.Resources.leftarrow_blue;
            back.Location = new Point(520, 23);
            back.Width = 35;
            back.Height = 35;
            back.Parent = panel;
            back.BackColor = Color.Transparent;
            back.Cursor = Cursors.Hand;
            back.Click += new EventHandler((sender, e) => backToMails(sender, e, panel));

            Label backLabel = new Label();
            backLabel.Text = "Back";
            backLabel.Location = new Point(550, 22);
            backLabel.ForeColor = Color.FromArgb(0, 174, 219); ;
            backLabel.Parent = panel;
            backLabel.Font = new Font("Arial", 16, FontStyle.Bold);

            Label from = new Label();
            from.ForeColor = Color.FromArgb(0, 174, 219);
            from.Font = new Font("Arial", 10, FontStyle.Bold);
            Label to = new Label();

            to.ForeColor = Color.FromArgb(0, 174, 219); 
            to.Font = new Font("Arial", 10, FontStyle.Bold);

            Label date = new Label();
            date.ForeColor = Color.FromArgb(0, 174, 219);
            date.Font = new Font("Arial", 10, FontStyle.Bold);

            Label subject = new Label();
            subject.ForeColor = Color.FromArgb(0, 174, 219);
            subject.Font = new Font("Arial", 10, FontStyle.Bold);

            Label mess = new Label();
            mess.ForeColor = Color.FromArgb(0, 174, 219);
            mess.Font = new Font("Arial", 10, FontStyle.Bold);


            Label att = new Label();
            att.ForeColor = Color.FromArgb(0, 174, 219);
            att.Font = new Font("Arial", 10, FontStyle.Bold);

            from.Parent = panel;
            from.Width = 500;
            from.Location = new Point(10, 20);
            from.Text = "From: " + message.From.ToString();

            to.Parent = panel;
            to.Width = 500;
            to.Location = new Point(10, 50);
            to.Text = "To: " + message.To.ToString();

            date.Parent = panel;
            date.Width = 500;
            date.Location = new Point(10, 80);
            date.Text = "Date: " + message.Date.ToString();

            subject.Parent = panel;
            subject.Width = 500;
            subject.Location = new Point(10, 110);
            subject.Text = "Subject: " + message.Subject;

            att.Parent = panel;
            att.Width = 500;
            att.Location = new Point(10, 530);
            var attachments = message.Attachments.ToList();
            int attCount = attachments.Count;
            att.Text = "Attachments: ";
            if (attCount == 0)
            {
                att.Text += "None";
            }
            else
            {
                att.Text += "\n";
                int attachHeight = 550;
                foreach (var attachment in attachments)
                {
                    string [] atttype = attachment.ContentType.ToString().Split('"');
                    Bunifu.Framework.UI.BunifuFlatButton attach = new Bunifu.Framework.UI.BunifuFlatButton();
                    attach.Text = atttype[1];
                    attach.Location = new Point(10, attachHeight);
                    attachHeight +=  20;
                    attach.Parent = panel;
                    attach.Activecolor = Color.FromArgb(0, 174, 219);
                    attach.Normalcolor = Color.FromArgb(0, 174, 219);
                    attach.OnHovercolor = Color.FromArgb(40, 200, 241);
                    attach.Click += new EventHandler((sender, e) => attachment_click(sender, e, message, atttype[1]));

                }
            }

            mess.Parent = panel;
            mess.Width = 500;
            mess.Location = new Point(10, 140);
            mess.Text = "Message:";

            if (message.HtmlBody == null)
            {
                TextBox readText = new TextBox();
                readText.Text = message.TextBody.ToString();
                readText.Multiline = true;
                readText.Width = 630;
                readText.Height = 350;
                readText.Parent = panel;
                readText.Location = new Point(10, 170);
                readText.ReadOnly = true;
            }
            else
            {
                WebBrowser read = new WebBrowser();
                read.Width = 630;
                read.Height = 350;
                read.Parent = panel;
                read.Location = new Point(10, 170);
                read.DocumentText = message.HtmlBody.ToString();
            }
            
            panel.Show();
        }

        private void attachment_click(object sender, EventArgs e, MimeMessage message, string name)
        {
            var attachments = message.Attachments.ToList();
            foreach(var attachment in attachments)
            {
                string[] atttype = attachment.ContentType.ToString().Split('"');
                if (atttype[1].Equals(name))
                {
                    string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                    string pathDownload = Path.Combine(pathUser, "Downloads\\" + atttype[1]);
                    using (var fileStream = File.Create(pathDownload))
                    {
                        if (attachment is MessagePart)
                        {
                            var part = (MessagePart)attachment;

                            part.Message.WriteTo(fileStream);
                        }
                        else
                        {
                            var part = (MimePart)attachment;

                            part.ContentObject.DecodeTo(fileStream);
                        }
                    }
                    MessageBox.Show("Downloaded successfully");
                }
            }
            
        }

        private void backToMails(object sender, EventArgs e, Panel panel)
        {
            panel.Hide();
            panel.Controls.Clear();
        }
    }
}
