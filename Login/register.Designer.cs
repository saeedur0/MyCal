﻿namespace Login
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
            this.clbl = new System.Windows.Forms.Label();
            this.txtconfPass = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.wlbl = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.gwlbl = new System.Windows.Forms.Label();
            this.txtGoalw = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnJoin3 = new MyCal.mycalbuttons();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(309, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(309, 134);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(309, 186);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(189, 20);
            this.txtPass.TabIndex = 4;
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.ForeColor = System.Drawing.Color.White;
            this.fnamelbl.Location = new System.Drawing.Point(249, 141);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(54, 13);
            this.fnamelbl.TabIndex = 5;
            this.fnamelbl.Text = "Full Name";
            // 
            // elbl
            // 
            this.elbl.AutoSize = true;
            this.elbl.ForeColor = System.Drawing.Color.White;
            this.elbl.Location = new System.Drawing.Point(270, 167);
            this.elbl.Name = "elbl";
            this.elbl.Size = new System.Drawing.Size(32, 13);
            this.elbl.TabIndex = 6;
            this.elbl.Text = "Email";
            // 
            // plbl
            // 
            this.plbl.AutoSize = true;
            this.plbl.ForeColor = System.Drawing.Color.White;
            this.plbl.Location = new System.Drawing.Point(249, 193);
            this.plbl.Name = "plbl";
            this.plbl.Size = new System.Drawing.Size(53, 13);
            this.plbl.TabIndex = 7;
            this.plbl.Text = "Password";
            // 
            // clbl
            // 
            this.clbl.AutoSize = true;
            this.clbl.ForeColor = System.Drawing.Color.White;
            this.clbl.Location = new System.Drawing.Point(211, 220);
            this.clbl.Name = "clbl";
            this.clbl.Size = new System.Drawing.Size(91, 13);
            this.clbl.TabIndex = 11;
            this.clbl.Text = "Confirm Password";
            // 
            // txtconfPass
            // 
            this.txtconfPass.Location = new System.Drawing.Point(308, 213);
            this.txtconfPass.Name = "txtconfPass";
            this.txtconfPass.Size = new System.Drawing.Size(190, 20);
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
            // wlbl
            // 
            this.wlbl.AutoSize = true;
            this.wlbl.BackColor = System.Drawing.Color.Transparent;
            this.wlbl.ForeColor = System.Drawing.Color.White;
            this.wlbl.Location = new System.Drawing.Point(206, 328);
            this.wlbl.Name = "wlbl";
            this.wlbl.Size = new System.Drawing.Size(96, 13);
            this.wlbl.TabIndex = 15;
            this.wlbl.Text = "Enter Weight in Kg";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(308, 322);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(190, 20);
            this.txtWeight.TabIndex = 14;
            // 
            // gwlbl
            // 
            this.gwlbl.AutoSize = true;
            this.gwlbl.BackColor = System.Drawing.Color.Transparent;
            this.gwlbl.ForeColor = System.Drawing.Color.White;
            this.gwlbl.Location = new System.Drawing.Point(181, 356);
            this.gwlbl.Name = "gwlbl";
            this.gwlbl.Size = new System.Drawing.Size(121, 13);
            this.gwlbl.TabIndex = 17;
            this.gwlbl.Text = "Enter Goal Weight in Kg";
            // 
            // txtGoalw
            // 
            this.txtGoalw.Location = new System.Drawing.Point(308, 349);
            this.txtGoalw.Name = "txtGoalw";
            this.txtGoalw.Size = new System.Drawing.Size(190, 20);
            this.txtGoalw.TabIndex = 16;
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "-- Select Gender --",
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(14, 24);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(121, 21);
            this.cbGender.TabIndex = 18;
            // 
            // btnJoin3
            // 
            this.btnJoin3.BackColor = System.Drawing.Color.Transparent;
            this.btnJoin3.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnJoin3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(52)))));
            this.btnJoin3.BorderColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(52)))));
            this.btnJoin3.BorderRadius = 20;
            this.btnJoin3.BorderRadius1 = 20;
            this.btnJoin3.BorderSize = 3;
            this.btnJoin3.BorderSize1 = 3;
            this.btnJoin3.FlatAppearance.BorderSize = 0;
            this.btnJoin3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoin3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(52)))));
            this.btnJoin3.Location = new System.Drawing.Point(322, 391);
            this.btnJoin3.Name = "btnJoin3";
            this.btnJoin3.Size = new System.Drawing.Size(150, 40);
            this.btnJoin3.TabIndex = 13;
            this.btnJoin3.Text = "Join MyCal";
            this.btnJoin3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(255)))), ((int)(((byte)(52)))));
            this.btnJoin3.UseVisualStyleBackColor = false;
            this.btnJoin3.Click += new System.EventHandler(this.btnJoin3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Enter Weight in Kg";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.register;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.gwlbl);
            this.Controls.Add(this.txtGoalw);
            this.Controls.Add(this.wlbl);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.btnJoin3);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.clbl);
            this.Controls.Add(this.txtconfPass);
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
        private System.Windows.Forms.Label clbl;
        private System.Windows.Forms.TextBox txtconfPass;
        private System.Windows.Forms.Button backbtn;
        private MyCal.mycalbuttons btnJoin3;
        private System.Windows.Forms.Label wlbl;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label gwlbl;
        private System.Windows.Forms.TextBox txtGoalw;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label1;
    }
}