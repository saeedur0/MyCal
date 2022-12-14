namespace Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closebtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.emailicoBox3 = new System.Windows.Forms.PictureBox();
            this.emailBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.passwordBox1 = new System.Windows.Forms.TextBox();
            this.memberlabel = new System.Windows.Forms.Label();
            this.registerlbl = new System.Windows.Forms.LinkLabel();
            this.pbDebug = new System.Windows.Forms.PictureBox();
            this.btnLogin = new MyCal.mycalbuttons();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailicoBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDebug)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Login.Properties.Resources.login_input2;
            this.pictureBox1.Location = new System.Drawing.Point(215, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 44);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(743, 1);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(40, 40);
            this.closebtn.TabIndex = 1;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Login.Properties.Resources.login_input2;
            this.pictureBox2.Location = new System.Drawing.Point(215, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(372, 44);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // emailicoBox3
            // 
            this.emailicoBox3.BackColor = System.Drawing.Color.Transparent;
            this.emailicoBox3.Image = global::Login.Properties.Resources.akar_icons_person1;
            this.emailicoBox3.Location = new System.Drawing.Point(222, 148);
            this.emailicoBox3.Name = "emailicoBox3";
            this.emailicoBox3.Size = new System.Drawing.Size(23, 23);
            this.emailicoBox3.TabIndex = 3;
            this.emailicoBox3.TabStop = false;
            // 
            // emailBox1
            // 
            this.emailBox1.BackColor = System.Drawing.Color.White;
            this.emailBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailBox1.Location = new System.Drawing.Point(251, 144);
            this.emailBox1.Multiline = true;
            this.emailBox1.Name = "emailBox1";
            this.emailBox1.Size = new System.Drawing.Size(325, 31);
            this.emailBox1.TabIndex = 4;
            this.emailBox1.Text = "Email";
            this.emailBox1.TextChanged += new System.EventHandler(this.emailBox1_TextChanged);
            this.emailBox1.Enter += new System.EventHandler(this.emailBox1_Enter);
            this.emailBox1.Leave += new System.EventHandler(this.emailBox1_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Login.Properties.Resources.carbon_password;
            this.pictureBox3.Location = new System.Drawing.Point(222, 210);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // passwordBox1
            // 
            this.passwordBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.passwordBox1.Location = new System.Drawing.Point(251, 206);
            this.passwordBox1.Multiline = true;
            this.passwordBox1.Name = "passwordBox1";
            this.passwordBox1.Size = new System.Drawing.Size(325, 31);
            this.passwordBox1.TabIndex = 6;
            this.passwordBox1.Text = "Password";
            this.passwordBox1.Enter += new System.EventHandler(this.passwordBox1_Enter);
            this.passwordBox1.Leave += new System.EventHandler(this.passwordBox1_Leave);
            // 
            // memberlabel
            // 
            this.memberlabel.AutoSize = true;
            this.memberlabel.BackColor = System.Drawing.Color.Transparent;
            this.memberlabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberlabel.ForeColor = System.Drawing.Color.White;
            this.memberlabel.Location = new System.Drawing.Point(265, 367);
            this.memberlabel.Name = "memberlabel";
            this.memberlabel.Size = new System.Drawing.Size(172, 25);
            this.memberlabel.TabIndex = 9;
            this.memberlabel.Text = "Not a member yet?";
            // 
            // registerlbl
            // 
            this.registerlbl.ActiveLinkColor = System.Drawing.Color.White;
            this.registerlbl.AutoSize = true;
            this.registerlbl.BackColor = System.Drawing.Color.Transparent;
            this.registerlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerlbl.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(138)))), ((int)(((byte)(188)))));
            this.registerlbl.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerlbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(138)))), ((int)(((byte)(188)))));
            this.registerlbl.Location = new System.Drawing.Point(433, 367);
            this.registerlbl.Name = "registerlbl";
            this.registerlbl.Size = new System.Drawing.Size(85, 25);
            this.registerlbl.TabIndex = 10;
            this.registerlbl.TabStop = true;
            this.registerlbl.Text = "Register!";
            this.registerlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerlbl_LinkClicked);
            // 
            // pbDebug
            // 
            this.pbDebug.BackColor = System.Drawing.Color.Transparent;
            this.pbDebug.Location = new System.Drawing.Point(-1, -1);
            this.pbDebug.Name = "pbDebug";
            this.pbDebug.Size = new System.Drawing.Size(20, 20);
            this.pbDebug.TabIndex = 12;
            this.pbDebug.TabStop = false;
            this.pbDebug.Click += new System.EventHandler(this.pbDebug_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(52)))));
            this.btnLogin.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(52)))));
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderRadius1 = 20;
            this.btnLogin.BorderSize = 3;
            this.btnLogin.BorderSize1 = 3;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(52)))));
            this.btnLogin.Location = new System.Drawing.Point(320, 267);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(52)))));
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.MyCal_Login1;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.pbDebug);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.registerlbl);
            this.Controls.Add(this.memberlabel);
            this.Controls.Add(this.passwordBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.emailBox1);
            this.Controls.Add(this.emailicoBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailicoBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDebug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox emailicoBox3;
        private System.Windows.Forms.TextBox emailBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox passwordBox1;
        private System.Windows.Forms.Label memberlabel;
        private System.Windows.Forms.LinkLabel registerlbl;
        private MyCal.mycalbuttons btnLogin;
        private System.Windows.Forms.PictureBox pbDebug;
    }
}

