namespace Login
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.backbtn = new System.Windows.Forms.Button();
            this.txtAct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gwlbl = new System.Windows.Forms.Label();
            this.txtgoalweight = new System.Windows.Forms.TextBox();
            this.wlbl = new System.Windows.Forms.Label();
            this.txtweight = new System.Windows.Forms.TextBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblLogOff = new System.Windows.Forms.Label();
            this.btnDel = new MyCal.mycalbuttons();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.backbtn.Location = new System.Drawing.Point(2, 725);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(40, 40);
            this.backbtn.TabIndex = 13;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // txtAct
            // 
            this.txtAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAct.Location = new System.Drawing.Point(582, 400);
            this.txtAct.Name = "txtAct";
            this.txtAct.Size = new System.Drawing.Size(190, 20);
            this.txtAct.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(643, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Activity Level";
            // 
            // gwlbl
            // 
            this.gwlbl.AutoSize = true;
            this.gwlbl.BackColor = System.Drawing.Color.Transparent;
            this.gwlbl.ForeColor = System.Drawing.Color.White;
            this.gwlbl.Location = new System.Drawing.Point(619, 341);
            this.gwlbl.Name = "gwlbl";
            this.gwlbl.Size = new System.Drawing.Size(121, 13);
            this.gwlbl.TabIndex = 31;
            this.gwlbl.Text = "Enter Goal Weight in Kg";
            // 
            // txtgoalweight
            // 
            this.txtgoalweight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgoalweight.Location = new System.Drawing.Point(582, 357);
            this.txtgoalweight.Name = "txtgoalweight";
            this.txtgoalweight.Size = new System.Drawing.Size(190, 20);
            this.txtgoalweight.TabIndex = 30;
            // 
            // wlbl
            // 
            this.wlbl.AutoSize = true;
            this.wlbl.BackColor = System.Drawing.Color.Transparent;
            this.wlbl.ForeColor = System.Drawing.Color.White;
            this.wlbl.Location = new System.Drawing.Point(631, 295);
            this.wlbl.Name = "wlbl";
            this.wlbl.Size = new System.Drawing.Size(96, 13);
            this.wlbl.TabIndex = 29;
            this.wlbl.Text = "Enter Weight in Kg";
            // 
            // txtweight
            // 
            this.txtweight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtweight.Location = new System.Drawing.Point(582, 311);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(190, 20);
            this.txtweight.TabIndex = 28;
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.BackColor = System.Drawing.Color.Transparent;
            this.lblSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSave.Font = new System.Drawing.Font("Yu Gothic UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.ForeColor = System.Drawing.Color.White;
            this.lblSave.Location = new System.Drawing.Point(648, 476);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(65, 32);
            this.lblSave.TabIndex = 38;
            this.lblSave.Text = "Save";
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // lblLogOff
            // 
            this.lblLogOff.AutoSize = true;
            this.lblLogOff.BackColor = System.Drawing.Color.Transparent;
            this.lblLogOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogOff.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOff.ForeColor = System.Drawing.Color.White;
            this.lblLogOff.Location = new System.Drawing.Point(614, 555);
            this.lblLogOff.Name = "lblLogOff";
            this.lblLogOff.Size = new System.Drawing.Size(130, 45);
            this.lblLogOff.TabIndex = 40;
            this.lblLogOff.Text = "Log Off";
            this.lblLogOff.Click += new System.EventHandler(this.lblLogOff_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDel.BorderColor = System.Drawing.Color.Red;
            this.btnDel.BorderColor1 = System.Drawing.Color.Red;
            this.btnDel.BorderRadius = 1;
            this.btnDel.BorderRadius1 = 1;
            this.btnDel.BorderSize = 6;
            this.btnDel.BorderSize1 = 6;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.Red;
            this.btnDel.Location = new System.Drawing.Point(400, 707);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(561, 49);
            this.btnDel.TabIndex = 39;
            this.btnDel.Text = "Permanently Delete My Account";
            this.btnDel.TextColor = System.Drawing.Color.Red;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(582, 446);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 20);
            this.txtEmail.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(663, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Email";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.Settings;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogOff);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.txtAct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gwlbl);
            this.Controls.Add(this.txtgoalweight);
            this.Controls.Add(this.wlbl);
            this.Controls.Add(this.txtweight);
            this.Controls.Add(this.backbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox txtAct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gwlbl;
        private System.Windows.Forms.TextBox txtgoalweight;
        private System.Windows.Forms.Label wlbl;
        private System.Windows.Forms.TextBox txtweight;
        private System.Windows.Forms.Label lblSave;
        private MyCal.mycalbuttons btnDel;
        private System.Windows.Forms.Label lblLogOff;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
    }
}