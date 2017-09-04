namespace MailClient
{
    partial class Write
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Write));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tileEmail = new MetroFramework.Controls.MetroTile();
            this.txtboxEmail = new MetroFramework.Controls.MetroTextBox();
            this.tileCC = new MetroFramework.Controls.MetroTile();
            this.txtboxCC = new MetroFramework.Controls.MetroTextBox();
            this.tileSubject = new MetroFramework.Controls.MetroTile();
            this.txtboxSubject = new MetroFramework.Controls.MetroTextBox();
            this.tileMessage = new MetroFramework.Controls.MetroTile();
            this.txtboxMessage = new MetroFramework.Controls.MetroTextBox();
            this.tileSend = new MetroFramework.Controls.MetroTile();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.tileDate = new MetroFramework.Controls.MetroTile();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.attachment = new Bunifu.Framework.UI.BunifuImageButton();
            this.Style = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tileEmail.SuspendLayout();
            this.tileCC.SuspendLayout();
            this.tileSubject.SuspendLayout();
            this.tileMessage.SuspendLayout();
            this.tileSend.SuspendLayout();
            this.tileDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Style)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.metroLabel1, BunifuAnimatorNS.DecorationType.None);
            this.metroLabel1.Location = new System.Drawing.Point(58, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(0, 0);
            this.metroLabel1.TabIndex = 0;
            // 
            // tileEmail
            // 
            this.tileEmail.ActiveControl = null;
            this.tileEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileEmail.Controls.Add(this.txtboxEmail);
            this.bunifuTransition1.SetDecoration(this.tileEmail, BunifuAnimatorNS.DecorationType.None);
            this.tileEmail.Location = new System.Drawing.Point(27, 80);
            this.tileEmail.Name = "tileEmail";
            this.tileEmail.Size = new System.Drawing.Size(111, 45);
            this.tileEmail.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileEmail.TabIndex = 1;
            this.tileEmail.Text = "Email Adress";
            this.tileEmail.UseSelectable = true;
            this.tileEmail.Click += new System.EventHandler(this.tileEmail_Click);
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtboxEmail.CustomButton.Image = null;
            this.txtboxEmail.CustomButton.Location = new System.Drawing.Point(-22, 1);
            this.txtboxEmail.CustomButton.Name = "";
            this.txtboxEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxEmail.CustomButton.TabIndex = 1;
            this.txtboxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxEmail.CustomButton.UseSelectable = true;
            this.txtboxEmail.CustomButton.Visible = false;
            this.bunifuTransition1.SetDecoration(this.txtboxEmail, BunifuAnimatorNS.DecorationType.None);
            this.txtboxEmail.Lines = new string[0];
            this.txtboxEmail.Location = new System.Drawing.Point(111, 13);
            this.txtboxEmail.MaxLength = 32767;
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.PasswordChar = '\0';
            this.txtboxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxEmail.SelectedText = "";
            this.txtboxEmail.SelectionLength = 0;
            this.txtboxEmail.SelectionStart = 0;
            this.txtboxEmail.ShortcutsEnabled = true;
            this.txtboxEmail.Size = new System.Drawing.Size(0, 23);
            this.txtboxEmail.TabIndex = 0;
            this.txtboxEmail.UseSelectable = true;
            this.txtboxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileCC
            // 
            this.tileCC.ActiveControl = null;
            this.tileCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileCC.Controls.Add(this.txtboxCC);
            this.bunifuTransition1.SetDecoration(this.tileCC, BunifuAnimatorNS.DecorationType.None);
            this.tileCC.Location = new System.Drawing.Point(27, 131);
            this.tileCC.Name = "tileCC";
            this.tileCC.Size = new System.Drawing.Size(111, 45);
            this.tileCC.TabIndex = 2;
            this.tileCC.Text = "CC";
            this.tileCC.UseSelectable = true;
            this.tileCC.Click += new System.EventHandler(this.tileCC_Click);
            // 
            // txtboxCC
            // 
            this.txtboxCC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtboxCC.CustomButton.Image = null;
            this.txtboxCC.CustomButton.Location = new System.Drawing.Point(-22, 1);
            this.txtboxCC.CustomButton.Name = "";
            this.txtboxCC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxCC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxCC.CustomButton.TabIndex = 1;
            this.txtboxCC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxCC.CustomButton.UseSelectable = true;
            this.txtboxCC.CustomButton.Visible = false;
            this.bunifuTransition1.SetDecoration(this.txtboxCC, BunifuAnimatorNS.DecorationType.None);
            this.txtboxCC.Lines = new string[0];
            this.txtboxCC.Location = new System.Drawing.Point(111, 13);
            this.txtboxCC.MaxLength = 32767;
            this.txtboxCC.Name = "txtboxCC";
            this.txtboxCC.PasswordChar = '\0';
            this.txtboxCC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxCC.SelectedText = "";
            this.txtboxCC.SelectionLength = 0;
            this.txtboxCC.SelectionStart = 0;
            this.txtboxCC.ShortcutsEnabled = true;
            this.txtboxCC.Size = new System.Drawing.Size(0, 23);
            this.txtboxCC.TabIndex = 0;
            this.txtboxCC.UseSelectable = true;
            this.txtboxCC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxCC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileSubject
            // 
            this.tileSubject.ActiveControl = null;
            this.tileSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileSubject.Controls.Add(this.txtboxSubject);
            this.bunifuTransition1.SetDecoration(this.tileSubject, BunifuAnimatorNS.DecorationType.None);
            this.tileSubject.Location = new System.Drawing.Point(27, 182);
            this.tileSubject.Name = "tileSubject";
            this.tileSubject.Size = new System.Drawing.Size(111, 45);
            this.tileSubject.TabIndex = 3;
            this.tileSubject.Text = "Subject";
            this.tileSubject.UseSelectable = true;
            this.tileSubject.Click += new System.EventHandler(this.tileSubject_Click);
            // 
            // txtboxSubject
            // 
            this.txtboxSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtboxSubject.CustomButton.Image = null;
            this.txtboxSubject.CustomButton.Location = new System.Drawing.Point(-22, 1);
            this.txtboxSubject.CustomButton.Name = "";
            this.txtboxSubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxSubject.CustomButton.TabIndex = 1;
            this.txtboxSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxSubject.CustomButton.UseSelectable = true;
            this.txtboxSubject.CustomButton.Visible = false;
            this.bunifuTransition1.SetDecoration(this.txtboxSubject, BunifuAnimatorNS.DecorationType.None);
            this.txtboxSubject.Lines = new string[0];
            this.txtboxSubject.Location = new System.Drawing.Point(111, 13);
            this.txtboxSubject.MaxLength = 32767;
            this.txtboxSubject.Name = "txtboxSubject";
            this.txtboxSubject.PasswordChar = '\0';
            this.txtboxSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxSubject.SelectedText = "";
            this.txtboxSubject.SelectionLength = 0;
            this.txtboxSubject.SelectionStart = 0;
            this.txtboxSubject.ShortcutsEnabled = true;
            this.txtboxSubject.Size = new System.Drawing.Size(0, 23);
            this.txtboxSubject.TabIndex = 0;
            this.txtboxSubject.UseSelectable = true;
            this.txtboxSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileMessage
            // 
            this.tileMessage.ActiveControl = null;
            this.tileMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileMessage.Controls.Add(this.txtboxMessage);
            this.bunifuTransition1.SetDecoration(this.tileMessage, BunifuAnimatorNS.DecorationType.None);
            this.tileMessage.Location = new System.Drawing.Point(27, 233);
            this.tileMessage.Name = "tileMessage";
            this.tileMessage.Size = new System.Drawing.Size(111, 252);
            this.tileMessage.TabIndex = 4;
            this.tileMessage.Text = "Message";
            this.tileMessage.UseSelectable = true;
            this.tileMessage.Click += new System.EventHandler(this.tileMessage_Click);
            // 
            // txtboxMessage
            // 
            this.txtboxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtboxMessage.CustomButton.Image = null;
            this.txtboxMessage.CustomButton.Location = new System.Drawing.Point(-220, 2);
            this.txtboxMessage.CustomButton.Name = "";
            this.txtboxMessage.CustomButton.Size = new System.Drawing.Size(217, 217);
            this.txtboxMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxMessage.CustomButton.TabIndex = 1;
            this.txtboxMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxMessage.CustomButton.UseSelectable = true;
            this.txtboxMessage.CustomButton.Visible = false;
            this.bunifuTransition1.SetDecoration(this.txtboxMessage, BunifuAnimatorNS.DecorationType.None);
            this.txtboxMessage.Lines = new string[0];
            this.txtboxMessage.Location = new System.Drawing.Point(111, 15);
            this.txtboxMessage.MaxLength = 32767;
            this.txtboxMessage.Multiline = true;
            this.txtboxMessage.Name = "txtboxMessage";
            this.txtboxMessage.PasswordChar = '\0';
            this.txtboxMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxMessage.SelectedText = "";
            this.txtboxMessage.SelectionLength = 0;
            this.txtboxMessage.SelectionStart = 0;
            this.txtboxMessage.ShortcutsEnabled = true;
            this.txtboxMessage.Size = new System.Drawing.Size(0, 222);
            this.txtboxMessage.TabIndex = 0;
            this.txtboxMessage.UseSelectable = true;
            this.txtboxMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tileSend
            // 
            this.tileSend.ActiveControl = null;
            this.tileSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tileSend.Controls.Add(this.btnSend);
            this.bunifuTransition1.SetDecoration(this.tileSend, BunifuAnimatorNS.DecorationType.None);
            this.tileSend.Location = new System.Drawing.Point(27, 491);
            this.tileSend.Name = "tileSend";
            this.tileSend.Size = new System.Drawing.Size(824, 45);
            this.tileSend.TabIndex = 5;
            this.tileSend.UseSelectable = true;
            this.tileSend.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.btnSend, BunifuAnimatorNS.DecorationType.None);
            this.btnSend.Location = new System.Drawing.Point(111, 13);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(698, 19);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send Email";
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblTime, BunifuAnimatorNS.DecorationType.None);
            this.lblTime.Location = new System.Drawing.Point(193, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(57, 19);
            this.lblTime.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00:00";
            // 
            // tileDate
            // 
            this.tileDate.ActiveControl = null;
            this.tileDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tileDate.Controls.Add(this.lblTime);
            this.bunifuTransition1.SetDecoration(this.tileDate, BunifuAnimatorNS.DecorationType.None);
            this.tileDate.Location = new System.Drawing.Point(598, 32);
            this.tileDate.Name = "tileDate";
            this.tileDate.Size = new System.Drawing.Size(253, 42);
            this.tileDate.TabIndex = 7;
            this.tileDate.Text = "Date";
            this.tileDate.UseSelectable = true;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 1F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            this.bunifuTransition1.Interval = 30;
            // 
            // attachment
            // 
            this.attachment.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.attachment, BunifuAnimatorNS.DecorationType.None);
            this.attachment.Image = global::MailClient.Properties.Resources.attachment;
            this.attachment.ImageActive = null;
            this.attachment.Location = new System.Drawing.Point(520, 34);
            this.attachment.Name = "attachment";
            this.attachment.Size = new System.Drawing.Size(35, 35);
            this.attachment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.attachment.TabIndex = 8;
            this.attachment.TabStop = false;
            this.attachment.Zoom = 10;
            this.attachment.Click += new System.EventHandler(this.attachment_Click);
            // 
            // Style
            // 
            this.Style.Owner = null;
            // 
            // Write
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 558);
            this.Controls.Add(this.attachment);
            this.Controls.Add(this.tileDate);
            this.Controls.Add(this.tileEmail);
            this.Controls.Add(this.tileSend);
            this.Controls.Add(this.tileMessage);
            this.Controls.Add(this.tileCC);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tileSubject);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MinimumSize = new System.Drawing.Size(600, 558);
            this.Name = "Write";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Write Email";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tileEmail.ResumeLayout(false);
            this.tileCC.ResumeLayout(false);
            this.tileSubject.ResumeLayout(false);
            this.tileMessage.ResumeLayout(false);
            this.tileSend.ResumeLayout(false);
            this.tileDate.ResumeLayout(false);
            this.tileDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Style)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile tileEmail;
        private MetroFramework.Controls.MetroTextBox txtboxEmail;
        private MetroFramework.Controls.MetroTile tileCC;
        private MetroFramework.Controls.MetroTextBox txtboxCC;
        private MetroFramework.Controls.MetroTile tileSubject;
        private MetroFramework.Controls.MetroTextBox txtboxSubject;
        private MetroFramework.Controls.MetroTile tileMessage;
        private MetroFramework.Controls.MetroTextBox txtboxMessage;
        private MetroFramework.Controls.MetroTile tileSend;
        private MetroFramework.Controls.MetroButton btnSend;
        private MetroFramework.Controls.MetroLabel lblTime;
        private MetroFramework.Controls.MetroTile tileDate;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private MetroFramework.Components.MetroStyleManager Style;
        private Bunifu.Framework.UI.BunifuImageButton attachment;
    }
}

