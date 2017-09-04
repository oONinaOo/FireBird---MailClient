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
using System.IO;
using System.Threading;

namespace MailClient
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private string mail;
        private string password;
        private int pageNumber;
        private string lastOpen = "inbox";
        ContextMenu menu = new ContextMenu();

        public MainForm(string MailAddress, string password)
        {
            InitializeComponent();
            content.MouseClick += content_MouseClick;
            content.Parent = contentPanel;
            this.mail = MailAddress;
            this.password = password;
            userText.Text = mail;
            pageNumber = 1;
            this.StyleManager = Style;
            ListViewColoring.colorListViewHeader(ref content, Color.FromArgb(0, 174, 219), Color.Black);

        }

        /*private void MyFormUsingBase_LoadCompleted()
        {
            Timer.Start();
            getInbox(accessMailBox(mail, password), 1);
            mailPages.selectedIndex = pageNumber - 1;
        }*/

        private void menuBtn_Click(object sender, EventArgs e)
        {
            if (sidemenu.Width == 60)
            {
                menuBtn.Location = new Point(228, 12);
                sidemenu.Visible = false;
                sidemenu.Width = 280;
                userText.Show();
                separator.Width = 242;
                panelAnimator.ShowSync(sidemenu);
            }
            else
            {
                menuBtn.Location = new Point(12, 12);
                sidemenu.Visible = false;
                sidemenu.Width = 60;
                userText.Hide();
                separator.Width = 22;
                panelAnimator.ShowSync(sidemenu);
            }
        }


        private void searchText_Enter(object sender, EventArgs e)
        {
            searchText.Text = "";
            searchText.ForeColor = Color.White;
        }

        private ImapClient accessMailBox(string mailAddress, string pw)
        {
            var client = new ImapClient();
            client.ServerCertificateValidationCallback = (s, c, h, e) => true;

            client.Connect("imap.gmail.com", 993, true);
            client.AuthenticationMechanisms.Remove("XOAUTH2");

            client.Authenticate(mailAddress, pw);

                return client;
            
        }


        private void setMailPages(IMailFolder type)
        {
            mailPages.Clear();

            int maxPages = type.Count / 20;
            if (type.Count % 20 > 0)
            {
                maxPages++;
            }
            for (int i = 0; i < maxPages; i++)
            {
                mailPages.AddItem((i + 1).ToString());
            }
        }

        private void setMailContent(ImapClient client, int pagenumber, IMailFolder type)
        {
            int maxPage = type.Count / 20;
            if (type.Count % 20 != 0)
            {
                maxPage++;
            }
            else
            {
                maxPage = 0;
            }


            if (type.Count > 20)
            {
                for (int i = type.Count - ((pagenumber - 1) * 20) - 1; i >= type.Count - (pagenumber * 20); i--)
                {
                    var message = type.GetMessage(i);
                    
                    var info = type.Fetch(new[] { i }, MessageSummaryItems.Flags | MessageSummaryItems.GMailLabels);


                    ListViewItem item = new ListViewItem();

                    if (info[0].Flags.Value.HasFlag(MessageFlags.Seen))
                    {
                        item.ForeColor = Color.FromArgb(0, 174, 219);
                    }


                    string[] getFrom = message.From.ToString().Split('"');
                    if (getFrom.Length == 1)
                    {
                        item.Text = message.From.ToString();
                    }
                    else
                    {
                        item.Text = getFrom[1];
                    }

                    if (message.Subject == "")
                    {
                        item.SubItems.Add("[no subject]");
                    }
                    else
                    {
                        item.SubItems.Add(message.Subject);
                    }
                    item.SubItems.Add(message.Date.ToString());
                    content.Items.Add(item);

                }

                client.Disconnect(true);
                pageNumber = pagenumber;
                mailPages.selectedIndex = pageNumber - 1;
                if (pagenumber == 1)
                {
                    changePageMinus.Hide();
                    changePagePlus.Show();
                }
                if (pagenumber == maxPage)
                {
                    changePagePlus.Hide();
                    changePageMinus.Show();
                }
                if (pagenumber > 1 && pagenumber < maxPage)
                {
                    changePagePlus.Show();
                    changePageMinus.Show();
                }
            }
            if (type.Count == 0)
            {
                
                ListViewItem item = new ListViewItem();
                item.Text = "No mail in this box.";
                content.Items.Add(item);
                changePageMinus.Hide();
                changePagePlus.Hide();
            }

            else
            {
                for (int i = type.Count - 1; i >= 0; i--)
                {
                    var message = type.GetMessage(i);
                    var info = type.Fetch(new[] {i}, MessageSummaryItems.Flags | MessageSummaryItems.GMailLabels);


                    ListViewItem item = new ListViewItem();

                    if (info[0].Flags.Value.HasFlag(MessageFlags.Seen))
                    {
                        item.ForeColor = Color.FromArgb(0, 174, 219);
                    }

                    string [] getFrom = message.From.ToString().Split('"');
                    if (getFrom.Length == 1)
                    {
                        item.Text = message.From.ToString();
                    }
                    else
                    {
                        item.Text = getFrom[1];
                    }

                    if (message.Subject == "")
                    {
                        item.SubItems.Add("[no subject]");
                    }
                    else
                    {
                        item.SubItems.Add(message.Subject);
                    }
                    item.SubItems.Add(message.Date.ToString());
                    content.Items.Add(item);
                }

                client.Disconnect(true);
                pageNumber = pagenumber;
                mailPages.selectedIndex = pageNumber - 1;
            }

            if (pagenumber == maxPage)
            {
                changePagePlus.Hide();
                changePageMinus.Show();
            }

            if (pagenumber == 1)
            {
                changePageMinus.Hide();
                changePagePlus.Show();
            }
            if (maxPage == 1 || maxPage == 0)
            {
                changePageMinus.Hide();
                changePagePlus.Hide();
            }
        }


        private void getInbox(ImapClient client, int pagenumber)
        {
            try
            {
                var inbox = client.Inbox;

                inbox.Open(FolderAccess.ReadWrite);

                setMailPages(inbox);
                setMailContent(client, pagenumber, inbox);
            }
            catch
            {
            }
            
        }

        private void getSent(ImapClient client, int pagenumber)
        {
            if ((client.Capabilities & (ImapCapabilities.SpecialUse | ImapCapabilities.XList)) != 0)
            {
                var sent = client.GetFolder(SpecialFolder.Sent);
                sent.Open(FolderAccess.ReadWrite);

                setMailPages(sent);
                setMailContent(client, pagenumber, sent);
            }
        }

        private void getDraft(ImapClient client, int pagenumber)
        {
            if ((client.Capabilities & (ImapCapabilities.SpecialUse | ImapCapabilities.XList)) != 0)
            {
                var draft = client.GetFolder(SpecialFolder.Drafts);
                draft.Open(FolderAccess.ReadWrite);

                setMailPages(draft);
                setMailContent(client, pagenumber, draft);
            }
        }

        private void getSpam(ImapClient client, int pagenumber)
        {
            if ((client.Capabilities & (ImapCapabilities.SpecialUse | ImapCapabilities.XList)) != 0)
            {
                var spam = client.GetFolder(SpecialFolder.Junk);
                spam.Open(FolderAccess.ReadWrite);

                setMailPages(spam);
                setMailContent(client, pagenumber, spam);
            }
        }

        private void getTrash(ImapClient client, int pagenumber)
        {
            if ((client.Capabilities & (ImapCapabilities.SpecialUse | ImapCapabilities.XList)) != 0)
            {
                var trash = client.GetFolder(SpecialFolder.Trash);
                trash.Open(FolderAccess.ReadWrite);

                setMailPages(trash);
                setMailContent(client, pagenumber, trash);
            }
        }

        private void inbox_Click(object sender, EventArgs ev)
        {
            getFirstPage();
            Loadings();
            var inbox = new Thread(openInboxFirst);
            inbox.Start();
            lastOpen = "inbox";

        }

        private void sent_Click(object sender, EventArgs e)
        {
            getFirstPage();
            Loadings();
            var sent = new Thread(openSentFirst);
            sent.Start();
            lastOpen = "sent";
        }

        private void draft_Click(object sender, EventArgs e)
        {
            getFirstPage();
            Loadings();
            var draft = new Thread(openDraftFirst);
            draft.Start();
            lastOpen = "draft";
        }

        private void spam_Click(object sender, EventArgs e)
        {
            getFirstPage();
            Loadings();
            var spam = new Thread(openSpamFirst);
            spam.Start();
            lastOpen = "spam";
        }

        private void trash_Click(object sender, EventArgs e)
        {
            getFirstPage();
            Loadings();
            var trash = new Thread(openTrashFirst);
            trash.Start();
            lastOpen = "trash";
        }

        private void getFirstPage()
        {
            pageNumber = 1;
            content.Hide();
            foreach (ListViewItem item in content.Items)
            {
                content.Items.Remove(item);
            }
        }


        private void newMail_Click(object sender, EventArgs e)
        {
            Write writer = new Write(mail, password, Style.Theme);
            writer.Show();
        }

        private void mailPages_onItemSelected(object sender, EventArgs e)
        {
            if (pageNumber != mailPages.selectedIndex + 1)
            {
                content.Hide();
                foreach (ListViewItem item in content.Items)
                {
                    content.Items.Remove(item);
                }


                switch (lastOpen)
                {
                    case "inbox":
                        Loadings();
                        var inbox = new Thread(openInbox);
                        inbox.Start();
                        break;
                    case "sent":
                        Loadings();
                        var sent = new Thread(openSent);
                        sent.Start();                    
                        break;
                    case "draft":
                        Loadings();
                        var draft = new Thread(openDraft);
                        draft.Start();
                        break;
                    case "spam":
                        Loadings();
                        var spam = new Thread(openSpam);
                        spam.Start();
                        break;
                    case "trash":
                        Loadings();
                        var trash = new Thread(openTrash);
                        trash.Start();
                        break;
                    case "search":
                        Loadings();
                        var search = new Thread(openSearch);
                        search.Start();
                        break;
                }
                content.Show();
            }

        }

        private void changePageMinus_Click(object sender, EventArgs e)
        {
            mailPages.selectedIndex -= 1;
        }

        private void changePagePlus_Click(object sender, EventArgs e)
        {
            mailPages.selectedIndex += 1;
        }

        private void switchTheme_OnValueChange(object sender, EventArgs e)
        {
            if (switchTheme.Value == true) //then dark 
            {
                Style.Theme = MetroFramework.MetroThemeStyle.Dark;
                sidemenu.BackColor = Color.FromArgb(23, 23, 23);
                inbox.BackColor = Color.FromArgb(23, 23, 23);
                inbox.Normalcolor = Color.FromArgb(23, 23, 23);
                inbox.OnHovercolor = Color.FromArgb(26, 26, 26);
                inbox.Activecolor = Color.FromArgb(26, 26, 26);
                sent.BackColor = Color.FromArgb(23, 23, 23);
                sent.Normalcolor = Color.FromArgb(23, 23, 23);
                sent.OnHovercolor = Color.FromArgb(26, 26, 26);
                sent.Activecolor = Color.FromArgb(26, 26, 26);
                spam.BackColor = Color.FromArgb(23, 23, 23);
                spam.Normalcolor = Color.FromArgb(23, 23, 23);
                spam.OnHovercolor = Color.FromArgb(26, 26, 26);
                spam.Activecolor = Color.FromArgb(26, 26, 26);
                trash.BackColor = Color.FromArgb(23, 23, 23);
                trash.Normalcolor = Color.FromArgb(23, 23, 23);
                trash.OnHovercolor = Color.FromArgb(26, 26, 26);
                trash.Activecolor = Color.FromArgb(26, 26, 26);
                draft.BackColor = Color.FromArgb(23, 23, 23);
                draft.Normalcolor = Color.FromArgb(23, 23, 23);
                draft.OnHovercolor = Color.FromArgb(26, 26, 26);
                draft.Activecolor = Color.FromArgb(26, 26, 26);
                logout.BackColor = Color.FromArgb(23, 23, 23);
                logout.Normalcolor = Color.FromArgb(23, 23, 23);
                logout.OnHovercolor = Color.FromArgb(26, 26, 26);
                logout.Activecolor = Color.FromArgb(26, 26, 26);
                title.ForeColor = Color.White;
                searchBg.BackColor = Color.FromArgb(25, 25, 25);
                searchText.BackColor = Color.FromArgb(25, 25, 25);
                searchIcon.BackColor = Color.FromArgb(25, 25, 25);
                searchText.LineMouseHoverColor = Color.White;
                content.BackColor = Color.FromArgb(17, 17, 17);
                content.ForeColor = Color.White;
                mailPages.NomalColor = Color.FromArgb(23, 23, 23);
                mailPages.onHoverColor = Color.FromArgb(23, 23, 23);
                changePageMinus.Image = Properties.Resources.leftarrow;
                changePagePlus.Image = Properties.Resources.rightarrow;
                newMail.Image = Properties.Resources.newmail;
            }
            else
            {
                Style.Theme = MetroFramework.MetroThemeStyle.Light;
                sidemenu.BackColor = Color.FromArgb(0, 174, 219);
                inbox.BackColor = Color.FromArgb(0, 174, 219);
                inbox.Normalcolor = Color.FromArgb(0, 174, 219);
                inbox.OnHovercolor = Color.FromArgb(40, 200, 241);
                inbox.Activecolor = Color.FromArgb(40, 200, 241);
                sent.BackColor = Color.FromArgb(0, 174, 219);
                sent.Normalcolor = Color.FromArgb(0, 174, 219);
                sent.OnHovercolor = Color.FromArgb(40, 200, 241);
                sent.Activecolor = Color.FromArgb(40, 200, 241);
                spam.BackColor = Color.FromArgb(0, 174, 219);
                spam.Normalcolor = Color.FromArgb(0, 174, 219);
                spam.OnHovercolor = Color.FromArgb(40, 200, 241);
                spam.Activecolor = Color.FromArgb(40, 200, 241);
                trash.BackColor = Color.FromArgb(0, 174, 219);
                trash.Normalcolor = Color.FromArgb(0, 174, 219);
                trash.OnHovercolor = Color.FromArgb(40, 200, 241);
                trash.Activecolor = Color.FromArgb(40, 200, 241);
                draft.BackColor = Color.FromArgb(0, 174, 219);
                draft.Normalcolor = Color.FromArgb(0, 174, 219);
                draft.OnHovercolor = Color.FromArgb(40, 200, 241);
                draft.Activecolor = Color.FromArgb(40, 200, 241);
                logout.BackColor = Color.FromArgb(0, 174, 219);
                logout.Normalcolor = Color.FromArgb(0, 174, 219);
                logout.OnHovercolor = Color.FromArgb(40, 200, 241);
                logout.Activecolor = Color.FromArgb(40, 200, 241);
                title.ForeColor = Color.Black;
                searchBg.BackColor = Color.FromArgb(0, 174, 219);
                searchText.BackColor = Color.FromArgb(0, 174, 219);
                searchText.LineMouseHoverColor = Color.Black;
                searchIcon.BackColor = Color.FromArgb(0, 174, 219);
                content.BackColor = Color.White;
                content.ForeColor = Color.Black;
                mailPages.NomalColor = Color.FromArgb(0, 174, 219);
                mailPages.onHoverColor = Color.FromArgb(0, 174, 219);
                changePageMinus.Image = Properties.Resources.leftarrow_blue;
                changePagePlus.Image = Properties.Resources.rightarrow_blue;
                newMail.Image = Properties.Resources.new_blue;
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            string path = @"C:\BirdCool\accountInf.dat";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            login.Show();

        }


        private MimeMessage[] search(ImapClient client, string pattern)
        {
            int index = 0;
            var query = SearchQuery.SubjectContains(pattern).Or(SearchQuery.BodyContains(pattern));
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadWrite);

            int founded = inbox.Search(query).Count;
            MimeMessage[] foundMessages = new MimeMessage[founded];


            foreach (var uid in inbox.Search(query))
            {
                var message = inbox.GetMessage(uid);
                foundMessages[index] = message;
                index++;
            }

            return foundMessages;
        }


        private void setSearchPages(MimeMessage [] founded)
        {
            mailPages.Clear();

            int maxPages = founded.Length / 20;
            if (founded.Length % 20 > 0)
            {
                maxPages++;
            }
            for (int i = 0; i < maxPages; i++)
            {
                mailPages.AddItem((i + 1).ToString());

            }
        }

        private void searchIcon_Click(object sender, EventArgs e)
        {
            getFirstPage();
            Loadings();
            var search = new Thread(openSearchFirst);
            search.Start();
            lastOpen = "search";
        }

        private void getSearch(ImapClient client, int pagenumber, MimeMessage [] founded)
        {
            setSearchPages(founded);
            searchContent(client, pagenumber,founded);

        }
        private void searchContent(ImapClient client, int pagenumber, MimeMessage[] founded)
        {

            int maxPage = founded.Length / 20;
            if (founded.Length % 20 != 0)
            {
                maxPage++;
            }
            else
            {
                maxPage = 0;
            }

            if (founded.Length > 20)
            {
                for (int i = founded.Length - ((pagenumber - 1) * 20) - 1; i >= founded.Length - (pagenumber * 20); i--)
                {
                    MimeMessage message = founded[i];

                    ListViewItem item = new ListViewItem();

                    string[] getFrom = message.From.ToString().Split('"');
                    if (getFrom.Length == 1)
                    {
                        item.Text = message.From.ToString();
                    }
                    else
                    {
                        item.Text = getFrom[1];
                    }

                    if (message.Subject == "")
                    {
                        item.SubItems.Add("[no subject]");
                    }
                    else
                    {
                        item.SubItems.Add(message.Subject);
                    }
                    item.SubItems.Add(message.Date.ToString());
                    content.Items.Add(item);

                }

                client.Disconnect(true);
                pageNumber = pagenumber;
                mailPages.selectedIndex = pageNumber - 1;

                if (pagenumber == 1)
                {
                    changePageMinus.Hide();
                    changePagePlus.Show();
                }
                if (pagenumber == maxPage)
                {
                    changePagePlus.Hide();
                    changePageMinus.Show();
                }
                if (pagenumber > 1 && pagenumber < maxPage)
                {
                    changePagePlus.Show();
                    changePageMinus.Show();
                }
            }
            if (founded.Length == 0)
            {

                ListViewItem item = new ListViewItem();
                item.Text = "No result for the search";
                content.Items.Add(item);
                changePageMinus.Hide();
                changePagePlus.Hide();
            }

            if (founded.Length <= 20)
            {
                for (int i = founded.Length - 1; i >= 0; i--)
                {
                    MimeMessage message = founded[i];
                    
                    ListViewItem item = new ListViewItem();

                    string[] getFrom = message.From.ToString().Split('"');
                    if (getFrom.Length == 1)
                    {
                        item.Text = message.From.ToString();
                    }
                    else
                    {
                        item.Text = getFrom[1];
                    }

                    if (message.Subject == "")
                    {
                        item.SubItems.Add("[no subject]");
                    }
                    else
                    {
                        item.SubItems.Add(message.Subject);
                    }
                    item.SubItems.Add(message.Date.ToString());
                    content.Items.Add(item);

                }

                client.Disconnect(true);
                pageNumber = pagenumber;
                mailPages.selectedIndex = pageNumber - 1;

            }

            if (pagenumber == maxPage)
            {
                changePagePlus.Hide();
                changePageMinus.Show();
            }

            if (pagenumber == 1)
            {
                changePageMinus.Hide();
                changePagePlus.Show();
            }
            if (maxPage == 1 || maxPage == 0)
            {
                changePageMinus.Hide();
                changePagePlus.Hide();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (LoadingBar.Value < 100)
            {
                LoadingBar.Value++;
            }
            else
            {
                Thread.Sleep(500);
                Loading.Visible = false;
                content.Hide();
                Timer.Stop();
                LoadingBar.Hide();
                Loading.Hide();
                loadingText.Hide();
                mailAnimator.ShowSync(content);
                               
            }
            

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Application.DoEvents();
            Timer.Start();
            var th = new Thread(openStartup);
            th.Start();
        }

        private void openStartup()
        {
            getInbox(accessMailBox(mail, password), 1);
            mailPages.selectedIndex = pageNumber - 1;
        }

        private void Loadings()
        {
            LoadingBar.Value = 0;
            Loading.Show();
            LoadingBar.Show();
            loadingText.Show();
            Timer.Start();
        }

        private void openInbox()
        {
            getInbox(accessMailBox(mail, password), mailPages.selectedIndex + 1);
        }

        private void openSent()
        {
            getSent(accessMailBox(mail, password), mailPages.selectedIndex + 1);
        }

        private void openDraft()
        {
            getDraft(accessMailBox(mail, password), mailPages.selectedIndex + 1);
        }
        private void openSpam()
        {
            getSpam(accessMailBox(mail, password), mailPages.selectedIndex + 1);
        }
        private void openTrash()
        {
            getTrash(accessMailBox(mail, password), mailPages.selectedIndex + 1);
        }
        private void openSearch()
        {
            getSearch(accessMailBox(mail, password), mailPages.selectedIndex + 1, search(accessMailBox(mail, password), searchText.Text));
        }

        private void openInboxFirst()
        {
            getInbox(accessMailBox(mail, password), 1);
        }

        private void openSentFirst()
        {
            getSent(accessMailBox(mail, password), 1);
        }

        private void openDraftFirst()
        {
            getDraft(accessMailBox(mail, password), 1);
        }
        private void openSpamFirst()
        {
            getSpam(accessMailBox(mail, password), 1);
        }
        private void openTrashFirst()
        {
            getTrash(accessMailBox(mail, password), 1);
        }
        private void openSearchFirst()
        {
            getSearch(accessMailBox(mail, password), 1, search(accessMailBox(mail, password), searchText.Text));
        }

        private void content_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                menu.getContextMenu(content, e, mailPages.selectedIndex + 1, decideImapFolder(accessMailBox(mail, password), lastOpen), ReadMailPanel);
            }
        }

        private IMailFolder decideImapFolder(ImapClient client, string lastOpen)
        {
            switch (lastOpen)
            {
                case "inbox":
                    var inbox = client.Inbox;
                    return inbox;
                case "sent":
                    var sent = client.GetFolder(SpecialFolder.Sent);
                    return sent;
                case "draft":
                    var draft = client.GetFolder(SpecialFolder.Drafts);
                    return draft;
                case "spam":
                    var spam = client.GetFolder(SpecialFolder.Junk);
                    return spam;
                case "trash":
                    var trash = client.GetFolder(SpecialFolder.Trash);
                    return trash;
                case "search":
                    return null;

            }
            return null;
        }
    }
}