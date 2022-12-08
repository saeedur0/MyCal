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
            this.txtAct.Location = new System.Drawing.Point(768, 283);
            this.txtAct.Name = "txtAct";
            this.txtAct.Size = new System.Drawing.Size(190, 20);
            this.txtAct.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(829, 267);
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
            this.gwlbl.Location = new System.Drawing.Point(609, 267);
            this.gwlbl.Name = "gwlbl";
            this.gwlbl.Size = new System.Drawing.Size(121, 13);
            this.gwlbl.TabIndex = 31;
            this.gwlbl.Text = "Enter Goal Weight in Kg";
            // 
            // txtgoalweight
            // 
            this.txtgoalweight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgoalweight.Location = new System.Drawing.Point(572, 283);
            this.txtgoalweight.Name = "txtgoalweight";
            this.txtgoalweight.Size = new System.Drawing.Size(190, 20);
            this.txtgoalweight.TabIndex = 30;
            // 
            // wlbl
            // 
            this.wlbl.AutoSize = true;
            this.wlbl.BackColor = System.Drawing.Color.Transparent;
            this.wlbl.ForeColor = System.Drawing.Color.White;
            this.wlbl.Location = new System.Drawing.Point(427, 267);
            this.wlbl.Name = "wlbl";
            this.wlbl.Size = new System.Drawing.Size(96, 13);
            this.wlbl.TabIndex = 29;
            this.wlbl.Text = "Enter Weight in Kg";
            // 
            // txtweight
            // 
            this.txtweight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtweight.Location = new System.Drawing.Point(378, 283);
            this.txtweight.Name = "txtweight";
            this.txtweight.Size = new System.Drawing.Size(190, 20);
            this.txtweight.TabIndex = 28;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.Settings;
            this.ClientSize = new System.Drawing.Size(1360, 768);
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
    }
}