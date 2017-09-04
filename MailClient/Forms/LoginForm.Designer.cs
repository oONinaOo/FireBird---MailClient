namespace MailClient
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pwText = new ZBobb.AlphaBlendTextBox();
            this.email = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.Label();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.emailText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MailClient.Properties.Resources.newnewnew;
            this.pictureBox1.Location = new System.Drawing.Point(71, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 491);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pwText
            // 
            this.pwText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pwText.BackAlpha = 50;
            this.pwText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pwText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pwText.ForeColor = System.Drawing.Color.White;
            this.pwText.Location = new System.Drawing.Point(214, 505);
            this.pwText.Name = "pwText";
            this.pwText.PasswordChar = '*';
            this.pwText.Size = new System.Drawing.Size(355, 22);
            this.pwText.TabIndex = 1;
            this.pwText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwText_KeyDown);
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(57, 470);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(140, 24);
            this.email.TabIndex = 3;
            this.email.Text = "E-mail address:";
            // 
            // pw
            // 
            this.pw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pw.AutoSize = true;
            this.pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pw.ForeColor = System.Drawing.Color.White;
            this.pw.Location = new System.Drawing.Point(57, 503);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(102, 24);
            this.pw.TabIndex = 4;
            this.pw.Text = "Password: ";
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 13;
            this.bunifuTileButton1.ImageZoom = 30;
            this.bunifuTileButton1.LabelPosition = 26;
            this.bunifuTileButton1.LabelText = "Login";
            this.bunifuTileButton1.Location = new System.Drawing.Point(607, 470);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(77, 59);
            this.bunifuTileButton1.TabIndex = 2;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.emailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.emailText.ForeColor = System.Drawing.Color.White;
            this.emailText.Location = new System.Drawing.Point(214, 470);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(355, 22);
            this.emailText.TabIndex = 0;
            this.emailText.Validating += new System.ComponentModel.CancelEventHandler(this.mail_Validating);
            this.emailText.Validated += new System.EventHandler(this.mail_Validated);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.email);
            this.Controls.Add(this.pwText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.CornflowerBlue;
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Components.MetroStyleManager StyleManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ZBobb.AlphaBlendTextBox pwText;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label pw;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox emailText;
    }
}

