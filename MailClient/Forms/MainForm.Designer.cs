namespace MailClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation10 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BunifuAnimatorNS.Animation animation11 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation12 = new BunifuAnimatorNS.Animation();
            this.sidemenu = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.dark = new Bunifu.Framework.UI.BunifuImageButton();
            this.logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.switchTheme = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.trash = new Bunifu.Framework.UI.BunifuFlatButton();
            this.spam = new Bunifu.Framework.UI.BunifuFlatButton();
            this.draft = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sent = new Bunifu.Framework.UI.BunifuFlatButton();
            this.inbox = new Bunifu.Framework.UI.BunifuFlatButton();
            this.separator = new System.Windows.Forms.PictureBox();
            this.menuBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.userText = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.contentPanel = new System.Windows.Forms.Panel();
            this.ReadMailPanel = new System.Windows.Forms.Panel();
            this.loadingText = new System.Windows.Forms.Label();
            this.LoadingBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.Loading = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.changePageMinus = new Bunifu.Framework.UI.BunifuImageButton();
            this.changePagePlus = new Bunifu.Framework.UI.BunifuImageButton();
            this.mailPages = new Bunifu.Framework.UI.BunifuDropdown();
            this.newMail = new Bunifu.Framework.UI.BunifuImageButton();
            this.content = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.searchBg = new System.Windows.Forms.PictureBox();
            this.headerIcon = new System.Windows.Forms.PictureBox();
            this.searchCorner = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.mailAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Style = new MetroFramework.Components.MetroStyleManager(this.components);
            this.changecolor = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.sidemenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loading)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changePageMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePagePlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMail)).BeginInit();
            this.searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Style)).BeginInit();
            this.SuspendLayout();
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.sidemenu.Controls.Add(this.bunifuImageButton1);
            this.sidemenu.Controls.Add(this.dark);
            this.sidemenu.Controls.Add(this.logout);
            this.sidemenu.Controls.Add(this.switchTheme);
            this.sidemenu.Controls.Add(this.trash);
            this.sidemenu.Controls.Add(this.spam);
            this.sidemenu.Controls.Add(this.draft);
            this.sidemenu.Controls.Add(this.sent);
            this.sidemenu.Controls.Add(this.inbox);
            this.sidemenu.Controls.Add(this.separator);
            this.sidemenu.Controls.Add(this.menuBtn);
            this.sidemenu.Controls.Add(this.userText);
            this.sidemenu.Controls.Add(this.user);
            this.panelAnimator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(20, 60);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(280, 650);
            this.sidemenu.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = global::MailClient.Properties.Resources.light;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(78, 572);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(51, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // dark
            // 
            this.dark.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator.SetDecoration(this.dark, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.dark, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this.dark, BunifuAnimatorNS.DecorationType.None);
            this.dark.Image = global::MailClient.Properties.Resources.dark;
            this.dark.ImageActive = null;
            this.dark.Location = new System.Drawing.Point(212, 572);
            this.dark.Name = "dark";
            this.dark.Size = new System.Drawing.Size(51, 40);
            this.dark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dark.TabIndex = 6;
            this.dark.TabStop = false;
            this.dark.Zoom = 10;
            // 
            // logout
            // 
            this.logout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout.BorderRadius = 0;
            this.logout.ButtonText = "       Logout";
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changecolor.SetDecoration(this.logout, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.logout, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.logout, BunifuAnimatorNS.DecorationType.None);
            this.logout.DisabledColor = System.Drawing.Color.Gray;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Iconcolor = System.Drawing.Color.Transparent;
            this.logout.Iconimage = global::MailClient.Properties.Resources.logout;
            this.logout.Iconimage_right = null;
            this.logout.Iconimage_right_Selected = null;
            this.logout.Iconimage_Selected = null;
            this.logout.IconMarginLeft = 0;
            this.logout.IconMarginRight = 0;
            this.logout.IconRightVisible = true;
            this.logout.IconRightZoom = 0D;
            this.logout.IconVisible = true;
            this.logout.IconZoom = 50D;
            this.logout.IsTab = false;
            this.logout.Location = new System.Drawing.Point(0, 506);
            this.logout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logout.Name = "logout";
            this.logout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.logout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.logout.OnHoverTextColor = System.Drawing.Color.White;
            this.logout.selected = false;
            this.logout.Size = new System.Drawing.Size(280, 59);
            this.logout.TabIndex = 9;
            this.logout.Text = "       Logout";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Textcolor = System.Drawing.Color.White;
            this.logout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // switchTheme
            // 
            this.switchTheme.BackColor = System.Drawing.Color.Transparent;
            this.switchTheme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchTheme.BackgroundImage")));
            this.switchTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAnimator.SetDecoration(this.switchTheme, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.switchTheme, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this.switchTheme, BunifuAnimatorNS.DecorationType.None);
            this.switchTheme.ForeColor = System.Drawing.Color.Black;
            this.switchTheme.Location = new System.Drawing.Point(153, 584);
            this.switchTheme.Name = "switchTheme";
            this.switchTheme.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.switchTheme.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.switchTheme.Size = new System.Drawing.Size(35, 20);
            this.switchTheme.TabIndex = 6;
            this.switchTheme.Value = true;
            this.switchTheme.OnValueChange += new System.EventHandler(this.switchTheme_OnValueChange);
            // 
            // trash
            // 
            this.trash.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.trash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.trash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trash.BorderRadius = 0;
            this.trash.ButtonText = "       Trash";
            this.trash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changecolor.SetDecoration(this.trash, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.trash, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.trash, BunifuAnimatorNS.DecorationType.None);
            this.trash.DisabledColor = System.Drawing.Color.Gray;
            this.trash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trash.ForeColor = System.Drawing.Color.White;
            this.trash.Iconcolor = System.Drawing.Color.Transparent;
            this.trash.Iconimage = global::MailClient.Properties.Resources.dustbin;
            this.trash.Iconimage_right = null;
            this.trash.Iconimage_right_Selected = null;
            this.trash.Iconimage_Selected = null;
            this.trash.IconMarginLeft = 0;
            this.trash.IconMarginRight = 0;
            this.trash.IconRightVisible = true;
            this.trash.IconRightZoom = 0D;
            this.trash.IconVisible = true;
            this.trash.IconZoom = 50D;
            this.trash.IsTab = false;
            this.trash.Location = new System.Drawing.Point(0, 439);
            this.trash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trash.Name = "trash";
            this.trash.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.trash.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.trash.OnHoverTextColor = System.Drawing.Color.White;
            this.trash.selected = false;
            this.trash.Size = new System.Drawing.Size(280, 59);
            this.trash.TabIndex = 8;
            this.trash.Text = "       Trash";
            this.trash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trash.Textcolor = System.Drawing.Color.White;
            this.trash.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trash.Click += new System.EventHandler(this.trash_Click);
            // 
            // spam
            // 
            this.spam.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.spam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.spam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spam.BorderRadius = 0;
            this.spam.ButtonText = "       Spam";
            this.spam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changecolor.SetDecoration(this.spam, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.spam, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.spam, BunifuAnimatorNS.DecorationType.None);
            this.spam.DisabledColor = System.Drawing.Color.Gray;
            this.spam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spam.ForeColor = System.Drawing.Color.White;
            this.spam.Iconcolor = System.Drawing.Color.Transparent;
            this.spam.Iconimage = global::MailClient.Properties.Resources.spam;
            this.spam.Iconimage_right = null;
            this.spam.Iconimage_right_Selected = null;
            this.spam.Iconimage_Selected = null;
            this.spam.IconMarginLeft = 0;
            this.spam.IconMarginRight = 0;
            this.spam.IconRightVisible = true;
            this.spam.IconRightZoom = 0D;
            this.spam.IconVisible = true;
            this.spam.IconZoom = 50D;
            this.spam.IsTab = false;
            this.spam.Location = new System.Drawing.Point(0, 372);
            this.spam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spam.Name = "spam";
            this.spam.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.spam.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.spam.OnHoverTextColor = System.Drawing.Color.White;
            this.spam.selected = false;
            this.spam.Size = new System.Drawing.Size(280, 59);
            this.spam.TabIndex = 7;
            this.spam.Text = "       Spam";
            this.spam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spam.Textcolor = System.Drawing.Color.White;
            this.spam.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spam.Click += new System.EventHandler(this.spam_Click);
            // 
            // draft
            // 
            this.draft.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.draft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.draft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.draft.BorderRadius = 0;
            this.draft.ButtonText = "       Draft";
            this.draft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changecolor.SetDecoration(this.draft, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.draft, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.draft, BunifuAnimatorNS.DecorationType.None);
            this.draft.DisabledColor = System.Drawing.Color.Gray;
            this.draft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.draft.ForeColor = System.Drawing.Color.White;
            this.draft.Iconcolor = System.Drawing.Color.Transparent;
            this.draft.Iconimage = global::MailClient.Properties.Resources.draft;
            this.draft.Iconimage_right = null;
            this.draft.Iconimage_right_Selected = null;
            this.draft.Iconimage_Selected = null;
            this.draft.IconMarginLeft = 0;
            this.draft.IconMarginRight = 0;
            this.draft.IconRightVisible = true;
            this.draft.IconRightZoom = 0D;
            this.draft.IconVisible = true;
            this.draft.IconZoom = 50D;
            this.draft.IsTab = false;
            this.draft.Location = new System.Drawing.Point(0, 305);
            this.draft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.draft.Name = "draft";
            this.draft.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.draft.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.draft.OnHoverTextColor = System.Drawing.Color.White;
            this.draft.selected = false;
            this.draft.Size = new System.Drawing.Size(280, 59);
            this.draft.TabIndex = 6;
            this.draft.Text = "       Draft";
            this.draft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.draft.Textcolor = System.Drawing.Color.White;
            this.draft.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draft.Click += new System.EventHandler(this.draft_Click);
            // 
            // sent
            // 
            this.sent.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.sent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.sent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sent.BorderRadius = 0;
            this.sent.ButtonText = "       Sent";
            this.sent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changecolor.SetDecoration(this.sent, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.sent, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.sent, BunifuAnimatorNS.DecorationType.None);
            this.sent.DisabledColor = System.Drawing.Color.Gray;
            this.sent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sent.ForeColor = System.Drawing.Color.White;
            this.sent.Iconcolor = System.Drawing.Color.Transparent;
            this.sent.Iconimage = global::MailClient.Properties.Resources.sent;
            this.sent.Iconimage_right = null;
            this.sent.Iconimage_right_Selected = null;
            this.sent.Iconimage_Selected = null;
            this.sent.IconMarginLeft = 0;
            this.sent.IconMarginRight = 0;
            this.sent.IconRightVisible = true;
            this.sent.IconRightZoom = 0D;
            this.sent.IconVisible = true;
            this.sent.IconZoom = 50D;
            this.sent.IsTab = false;
            this.sent.Location = new System.Drawing.Point(0, 238);
            this.sent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sent.Name = "sent";
            this.sent.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.sent.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.sent.OnHoverTextColor = System.Drawing.Color.White;
            this.sent.selected = false;
            this.sent.Size = new System.Drawing.Size(280, 59);
            this.sent.TabIndex = 5;
            this.sent.Text = "       Sent";
            this.sent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sent.Textcolor = System.Drawing.Color.White;
            this.sent.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sent.Click += new System.EventHandler(this.sent_Click);
            // 
            // inbox
            // 
            this.inbox.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.inbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.inbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inbox.BorderRadius = 0;
            this.inbox.ButtonText = "       Inbox";
            this.inbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changecolor.SetDecoration(this.inbox, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.inbox, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.inbox, BunifuAnimatorNS.DecorationType.None);
            this.inbox.DisabledColor = System.Drawing.Color.Gray;
            this.inbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inbox.ForeColor = System.Drawing.Color.White;
            this.inbox.Iconcolor = System.Drawing.Color.Transparent;
            this.inbox.Iconimage = global::MailClient.Properties.Resources.inbox;
            this.inbox.Iconimage_right = null;
            this.inbox.Iconimage_right_Selected = null;
            this.inbox.Iconimage_Selected = null;
            this.inbox.IconMarginLeft = 0;
            this.inbox.IconMarginRight = 0;
            this.inbox.IconRightVisible = true;
            this.inbox.IconRightZoom = 0D;
            this.inbox.IconVisible = true;
            this.inbox.IconZoom = 50D;
            this.inbox.IsTab = false;
            this.inbox.Location = new System.Drawing.Point(0, 171);
            this.inbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inbox.Name = "inbox";
            this.inbox.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.inbox.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.inbox.OnHoverTextColor = System.Drawing.Color.White;
            this.inbox.selected = false;
            this.inbox.Size = new System.Drawing.Size(280, 59);
            this.inbox.TabIndex = 4;
            this.inbox.Text = "       Inbox";
            this.inbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inbox.Textcolor = System.Drawing.Color.White;
            this.inbox.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inbox.Click += new System.EventHandler(this.inbox_Click);
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.White;
            this.changecolor.SetDecoration(this.separator, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.separator, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.separator, BunifuAnimatorNS.DecorationType.None);
            this.separator.Location = new System.Drawing.Point(21, 141);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(242, 1);
            this.separator.TabIndex = 3;
            this.separator.TabStop = false;
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator.SetDecoration(this.menuBtn, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.menuBtn, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this.menuBtn, BunifuAnimatorNS.DecorationType.None);
            this.menuBtn.Image = global::MailClient.Properties.Resources.text;
            this.menuBtn.ImageActive = null;
            this.menuBtn.Location = new System.Drawing.Point(228, 12);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(35, 35);
            this.menuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuBtn.TabIndex = 2;
            this.menuBtn.TabStop = false;
            this.menuBtn.Zoom = 10;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // userText
            // 
            this.changecolor.SetDecoration(this.userText, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.userText, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.userText, BunifuAnimatorNS.DecorationType.None);
            this.userText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.userText.ForeColor = System.Drawing.Color.White;
            this.userText.Location = new System.Drawing.Point(18, 111);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(248, 16);
            this.userText.TabIndex = 1;
            this.userText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user
            // 
            this.changecolor.SetDecoration(this.user, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.user, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.user, BunifuAnimatorNS.DecorationType.None);
            this.user.Image = global::MailClient.Properties.Resources.mail;
            this.user.Location = new System.Drawing.Point(109, 58);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(65, 50);
            this.user.TabIndex = 0;
            this.user.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.changecolor.SetDecoration(this.title, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.title, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.title, BunifuAnimatorNS.DecorationType.None);
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(77, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(106, 24);
            this.title.TabIndex = 1;
            this.title.Text = "Birdcool™";
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.panelAnimator.Cursor = null;
            animation10.AnimateOnlyDifferences = true;
            animation10.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.BlindCoeff")));
            animation10.LeafCoeff = 1F;
            animation10.MaxTime = 1F;
            animation10.MinTime = 0F;
            animation10.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicCoeff")));
            animation10.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicShift")));
            animation10.MosaicSize = 0;
            animation10.Padding = new System.Windows.Forms.Padding(0);
            animation10.RotateCoeff = 0F;
            animation10.RotateLimit = 0F;
            animation10.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.ScaleCoeff")));
            animation10.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.SlideCoeff")));
            animation10.TimeCoeff = 0F;
            animation10.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation10;
            this.panelAnimator.Interval = 30;
            this.panelAnimator.MaxAnimationTime = 5000;
            // 
            // contentPanel
            // 
            this.contentPanel.AutoSize = true;
            this.contentPanel.Controls.Add(this.ReadMailPanel);
            this.contentPanel.Controls.Add(this.loadingText);
            this.contentPanel.Controls.Add(this.LoadingBar);
            this.contentPanel.Controls.Add(this.Loading);
            this.contentPanel.Controls.Add(this.bottomPanel);
            this.contentPanel.Controls.Add(this.content);
            this.contentPanel.Controls.Add(this.searchPanel);
            this.panelAnimator.SetDecoration(this.contentPanel, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.contentPanel, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this.contentPanel, BunifuAnimatorNS.DecorationType.None);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(300, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(680, 650);
            this.contentPanel.TabIndex = 3;
            // 
            // ReadMailPanel
            // 
            this.ReadMailPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAnimator.SetDecoration(this.ReadMailPanel, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.ReadMailPanel, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this.ReadMailPanel, BunifuAnimatorNS.DecorationType.None);
            this.ReadMailPanel.Location = new System.Drawing.Point(7, 53);
            this.ReadMailPanel.Name = "ReadMailPanel";
            this.ReadMailPanel.Size = new System.Drawing.Size(682, 597);
            this.ReadMailPanel.TabIndex = 9;
            this.ReadMailPanel.Visible = false;
            // 
            // loadingText
            // 
            this.loadingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingText.AutoSize = true;
            this.changecolor.SetDecoration(this.loadingText, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.loadingText, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.loadingText, BunifuAnimatorNS.DecorationType.None);
            this.loadingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadingText.ForeColor = System.Drawing.Color.DimGray;
            this.loadingText.Location = new System.Drawing.Point(281, 207);
            this.loadingText.Name = "loadingText";
            this.loadingText.Size = new System.Drawing.Size(153, 18);
            this.loadingText.TabIndex = 8;
            this.loadingText.Text = "Loading content ... ";
            // 
            // LoadingBar
            // 
            this.LoadingBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadingBar.animated = true;
            this.LoadingBar.animationIterval = 1;
            this.LoadingBar.animationSpeed = 1;
            this.LoadingBar.BackColor = System.Drawing.Color.Transparent;
            this.LoadingBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadingBar.BackgroundImage")));
            this.panelAnimator.SetDecoration(this.LoadingBar, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.LoadingBar, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this.LoadingBar, BunifuAnimatorNS.DecorationType.None);
            this.LoadingBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadingBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.LoadingBar.LabelVisible = true;
            this.LoadingBar.LineProgressThickness = 10;
            this.LoadingBar.LineThickness = 5;
            this.LoadingBar.Location = new System.Drawing.Point(284, 65);
            this.LoadingBar.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.LoadingBar.MaxValue = 100;
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.ProgressBackColor = System.Drawing.Color.DimGray;
            this.LoadingBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.LoadingBar.Size = new System.Drawing.Size(134, 134);
            this.LoadingBar.TabIndex = 7;
            this.LoadingBar.Value = 0;
            // 
            // Loading
            // 
            this.Loading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changecolor.SetDecoration(this.Loading, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.Loading, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.Loading, BunifuAnimatorNS.DecorationType.None);
            this.Loading.Location = new System.Drawing.Point(3, 53);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(686, 597);
            this.Loading.TabIndex = 6;
            this.Loading.TabStop = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.changePageMinus);
            this.bottomPanel.Controls.Add(this.changePagePlus);
            this.bottomPanel.Controls.Add(this.mailPages);
            this.bottomPanel.Controls.Add(this.newMail);
            this.panelAnimator.SetDecoration(this.bottomPanel, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.bottomPanel, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this.bottomPanel, BunifuAnimatorNS.DecorationType.None);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 607);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(680, 43);
            this.bottomPanel.TabIndex = 5;
            // 
            // changePageMinus
            // 
            this.changePageMinus.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator.SetDecoration(this.changePageMinus, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.changePageMinus, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this.changePageMinus, BunifuAnimatorNS.DecorationType.None);
            this.changePageMinus.Image = global::MailClient.Properties.Resources.leftarrow;
            this.changePageMinus.ImageActive = null;
            this.changePageMinus.Location = new System.Drawing.Point(255, 7);
            this.changePageMinus.Name = "changePageMinus";
            this.changePageMinus.Size = new System.Drawing.Size(30, 30);
            this.changePageMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.changePageMinus.TabIndex = 8;
            this.changePageMinus.TabStop = false;
            this.changePageMinus.Zoom = 10;
            this.changePageMinus.Click += new System.EventHandler(this.changePageMinus_Click);
            // 
            // changePagePlus
            // 
            this.changePagePlus.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator.SetDecoration(this.changePagePlus, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.changePagePlus, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this.changePagePlus, BunifuAnimatorNS.DecorationType.None);
            this.changePagePlus.Image = global::MailClient.Properties.Resources.rightarrow;
            this.changePagePlus.ImageActive = null;
            this.changePagePlus.Location = new System.Drawing.Point(416, 7);
            this.changePagePlus.Name = "changePagePlus";
            this.changePagePlus.Size = new System.Drawing.Size(30, 30);
            this.changePagePlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.changePagePlus.TabIndex = 7;
            this.changePagePlus.TabStop = false;
            this.changePagePlus.Zoom = 10;
            this.changePagePlus.Click += new System.EventHandler(this.changePagePlus_Click);
            // 
            // mailPages
            // 
            this.mailPages.BackColor = System.Drawing.Color.Transparent;
            this.mailPages.BorderRadius = 3;
            this.changecolor.SetDecoration(this.mailPages, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.mailPages, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.mailPages, BunifuAnimatorNS.DecorationType.None);
            this.mailPages.DisabledColor = System.Drawing.Color.Gray;
            this.mailPages.ForeColor = System.Drawing.Color.White;
            this.mailPages.Items = new string[0];
            this.mailPages.Location = new System.Drawing.Point(301, 5);
            this.mailPages.Name = "mailPages";
            this.mailPages.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.mailPages.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.mailPages.selectedIndex = -1;
            this.mailPages.Size = new System.Drawing.Size(101, 35);
            this.mailPages.TabIndex = 6;
            this.mailPages.onItemSelected += new System.EventHandler(this.mailPages_onItemSelected);
            // 
            // newMail
            // 
            this.newMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newMail.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator.SetDecoration(this.newMail, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.newMail, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this.newMail, BunifuAnimatorNS.DecorationType.None);
            this.newMail.Image = global::MailClient.Properties.Resources.newmail;
            this.newMail.ImageActive = null;
            this.newMail.Location = new System.Drawing.Point(636, 2);
            this.newMail.Name = "newMail";
            this.newMail.Size = new System.Drawing.Size(40, 40);
            this.newMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newMail.TabIndex = 4;
            this.newMail.TabStop = false;
            this.newMail.Zoom = 15;
            this.newMail.Click += new System.EventHandler(this.newMail_Click);
            // 
            // content
            // 
            this.content.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.content.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.panelAnimator.SetDecoration(this.content, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.content, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this.content, BunifuAnimatorNS.DecorationType.None);
            this.content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.content.ForeColor = System.Drawing.Color.White;
            this.content.Location = new System.Drawing.Point(15, 55);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(674, 595);
            this.content.TabIndex = 1;
            this.content.UseCompatibleStateImageBehavior = false;
            this.content.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "From";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 350;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 160;
            // 
            // searchPanel
            // 
            this.searchPanel.AutoSize = true;
            this.searchPanel.Controls.Add(this.searchText);
            this.searchPanel.Controls.Add(this.searchIcon);
            this.searchPanel.Controls.Add(this.searchBg);
            this.panelAnimator.SetDecoration(this.searchPanel, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.searchPanel, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this.searchPanel, BunifuAnimatorNS.DecorationType.None);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(680, 51);
            this.searchPanel.TabIndex = 0;
            // 
            // searchText
            // 
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.searchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelAnimator.SetDecoration(this.searchText, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.searchText, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this.searchText, BunifuAnimatorNS.DecorationType.None);
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.searchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchText.HintForeColor = System.Drawing.Color.Empty;
            this.searchText.HintText = "";
            this.searchText.isPassword = false;
            this.searchText.LineFocusedColor = System.Drawing.Color.White;
            this.searchText.LineIdleColor = System.Drawing.Color.Gray;
            this.searchText.LineMouseHoverColor = System.Drawing.Color.White;
            this.searchText.LineThickness = 3;
            this.searchText.Location = new System.Drawing.Point(55, 15);
            this.searchText.Margin = new System.Windows.Forms.Padding(4);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(606, 32);
            this.searchText.TabIndex = 3;
            this.searchText.Text = "Click for search ... ";
            this.searchText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchText.Enter += new System.EventHandler(this.searchText_Enter);
            // 
            // searchIcon
            // 
            this.searchIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.changecolor.SetDecoration(this.searchIcon, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.searchIcon, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.searchIcon, BunifuAnimatorNS.DecorationType.None);
            this.searchIcon.Image = global::MailClient.Properties.Resources.search;
            this.searchIcon.Location = new System.Drawing.Point(15, 16);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(28, 28);
            this.searchIcon.TabIndex = 2;
            this.searchIcon.TabStop = false;
            this.searchIcon.Click += new System.EventHandler(this.searchIcon_Click);
            // 
            // searchBg
            // 
            this.searchBg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.changecolor.SetDecoration(this.searchBg, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.searchBg, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.searchBg, BunifuAnimatorNS.DecorationType.None);
            this.searchBg.Location = new System.Drawing.Point(3, 12);
            this.searchBg.Name = "searchBg";
            this.searchBg.Size = new System.Drawing.Size(671, 35);
            this.searchBg.TabIndex = 0;
            this.searchBg.TabStop = false;
            // 
            // headerIcon
            // 
            this.changecolor.SetDecoration(this.headerIcon, BunifuAnimatorNS.DecorationType.None);
            this.mailAnimator.SetDecoration(this.headerIcon, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.headerIcon, BunifuAnimatorNS.DecorationType.None);
            this.headerIcon.Image = global::MailClient.Properties.Resources.mini;
            this.headerIcon.Location = new System.Drawing.Point(10, 5);
            this.headerIcon.Name = "headerIcon";
            this.headerIcon.Size = new System.Drawing.Size(61, 51);
            this.headerIcon.TabIndex = 2;
            this.headerIcon.TabStop = false;
            // 
            // searchCorner
            // 
            this.searchCorner.ElipseRadius = 35;
            this.searchCorner.TargetControl = this.searchBg;
            // 
            // mailAnimator
            // 
            this.mailAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.mailAnimator.Cursor = null;
            animation11.AnimateOnlyDifferences = true;
            animation11.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.BlindCoeff")));
            animation11.LeafCoeff = 0F;
            animation11.MaxTime = 1F;
            animation11.MinTime = 0F;
            animation11.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicCoeff")));
            animation11.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicShift")));
            animation11.MosaicSize = 0;
            animation11.Padding = new System.Windows.Forms.Padding(0);
            animation11.RotateCoeff = 0F;
            animation11.RotateLimit = 0F;
            animation11.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.ScaleCoeff")));
            animation11.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.SlideCoeff")));
            animation11.TimeCoeff = 0F;
            animation11.TransparencyCoeff = 1F;
            this.mailAnimator.DefaultAnimation = animation11;
            this.mailAnimator.Interval = 30;
            this.mailAnimator.MaxAnimationTime = 5000;
            // 
            // Style
            // 
            this.Style.Owner = this;
            this.Style.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // changecolor
            // 
            this.changecolor.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.changecolor.Cursor = null;
            animation12.AnimateOnlyDifferences = true;
            animation12.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.BlindCoeff")));
            animation12.LeafCoeff = 0F;
            animation12.MaxTime = 1F;
            animation12.MinTime = 0F;
            animation12.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicCoeff")));
            animation12.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicShift")));
            animation12.MosaicSize = 0;
            animation12.Padding = new System.Windows.Forms.Padding(0);
            animation12.RotateCoeff = 0F;
            animation12.RotateLimit = 0F;
            animation12.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.ScaleCoeff")));
            animation12.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.SlideCoeff")));
            animation12.TimeCoeff = 0F;
            animation12.TransparencyCoeff = 1F;
            this.changecolor.DefaultAnimation = animation12;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 63;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 730);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerIcon);
            this.Controls.Add(this.title);
            this.Controls.Add(this.sidemenu);
            this.mailAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.changecolor.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "MainForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.sidemenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loading)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changePageMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changePagePlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newMail)).EndInit();
            this.searchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Style)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidemenu;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox headerIcon;
        private System.Windows.Forms.PictureBox user;
        private System.Windows.Forms.Label userText;
        private System.Windows.Forms.PictureBox separator;
        private Bunifu.Framework.UI.BunifuImageButton menuBtn;
        private Bunifu.Framework.UI.BunifuFlatButton inbox;
        private Bunifu.Framework.UI.BunifuFlatButton trash;
        private Bunifu.Framework.UI.BunifuFlatButton spam;
        private Bunifu.Framework.UI.BunifuFlatButton draft;
        private Bunifu.Framework.UI.BunifuFlatButton sent;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.ListView content;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel searchPanel;
        private Bunifu.Framework.UI.BunifuElipse searchCorner;
        private System.Windows.Forms.PictureBox searchBg;
        private System.Windows.Forms.PictureBox searchIcon;
        private Bunifu.Framework.UI.BunifuMaterialTextbox searchText;
        private Bunifu.Framework.UI.BunifuImageButton newMail;
        private System.Windows.Forms.Panel bottomPanel;
        private Bunifu.Framework.UI.BunifuiOSSwitch switchTheme;
        private Bunifu.Framework.UI.BunifuDropdown mailPages;
        private BunifuAnimatorNS.BunifuTransition mailAnimator;
        private Bunifu.Framework.UI.BunifuImageButton changePageMinus;
        private Bunifu.Framework.UI.BunifuImageButton changePagePlus;
        private Bunifu.Framework.UI.BunifuFlatButton logout;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton dark;
        private MetroFramework.Components.MetroStyleManager Style;
        private BunifuAnimatorNS.BunifuTransition changecolor;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox Loading;
        private System.Windows.Forms.Label loadingText;
        private Bunifu.Framework.UI.BunifuCircleProgressbar LoadingBar;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel ReadMailPanel;
    }
}