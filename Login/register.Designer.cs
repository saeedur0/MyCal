namespace Login
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.fnamelbl = new System.Windows.Forms.Label();
            this.elbl = new System.Windows.Forms.Label();
            this.plbl = new System.Windows.Forms.Label();
            this.btnJoin = new System.Windows.Forms.Button();
            this.clbl = new System.Windows.Forms.Label();
            this.txtconfPass = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.btnLogin = new MyCal.mycalbuttons();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(302, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(302, 149);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(302, 201);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 4;
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.ForeColor = System.Drawing.Color.White;
            this.fnamelbl.Location = new System.Drawing.Point(242, 156);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(54, 13);
            this.fnamelbl.TabIndex = 5;
            this.fnamelbl.Text = "Full Name";
            // 
            // elbl
            // 
            this.elbl.AutoSize = true;
            this.elbl.ForeColor = System.Drawing.Color.White;
            this.elbl.Location = new System.Drawing.Point(263, 182);
            this.elbl.Name = "elbl";
            this.elbl.Size = new System.Drawing.Size(32, 13);
            this.elbl.TabIndex = 6;
            this.elbl.Text = "Email";
            // 
            // plbl
            // 
            this.plbl.AutoSize = true;
            this.plbl.ForeColor = System.Drawing.Color.White;
            this.plbl.Location = new System.Drawing.Point(242, 208);
            this.plbl.Name = "plbl";
            this.plbl.Size = new System.Drawing.Size(53, 13);
            this.plbl.TabIndex = 7;
            this.plbl.Text = "Password";
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(314, 254);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 8;
            this.btnJoin.Text = "Join MyCal";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // clbl
            // 
            this.clbl.AutoSize = true;
            this.clbl.ForeColor = System.Drawing.Color.White;
            this.clbl.Location = new System.Drawing.Point(204, 235);
            this.clbl.Name = "clbl";
            this.clbl.Size = new System.Drawing.Size(91, 13);
            this.clbl.TabIndex = 11;
            this.clbl.Text = "Confirm Password";
            // 
            // txtconfPass
            // 
            this.txtconfPass.Location = new System.Drawing.Point(301, 228);
            this.txtconfPass.Name = "txtconfPass";
            this.txtconfPass.Size = new System.Drawing.Size(100, 20);
            this.txtconfPass.TabIndex = 10;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Transparent;
            this.backbtn.BackgroundImage = global::Login.Properties.Resources.arrow__left;
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(2, 419);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(40, 40);
            this.backbtn.TabIndex = 12;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
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
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(52)))));
            this.btnLogin.Location = new System.Drawing.Point(427, 254);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Join MyCal";
            this.btnLogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(52)))));
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.register;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.clbl);
            this.Controls.Add(this.txtconfPass);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.plbl);
            this.Controls.Add(this.elbl);
            this.Controls.Add(this.fnamelbl);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label fnamelbl;
        private System.Windows.Forms.Label elbl;
        private System.Windows.Forms.Label plbl;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label clbl;
        private System.Windows.Forms.TextBox txtconfPass;
        private System.Windows.Forms.Button backbtn;
        private MyCal.mycalbuttons btnLogin;
    }
}