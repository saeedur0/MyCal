namespace Login
{
    partial class Workouts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workouts));
            this.backbtn = new System.Windows.Forms.Button();
            this.btncardio = new MyCal.mycalbuttons();
            this.btnstrength = new MyCal.mycalbuttons();
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
            this.backbtn.Location = new System.Drawing.Point(12, 435);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(40, 40);
            this.backbtn.TabIndex = 13;
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // btncardio
            // 
            this.btncardio.BackColor = System.Drawing.Color.Transparent;
            this.btncardio.BackgroundColor = System.Drawing.Color.Transparent;
            this.btncardio.BorderColor = System.Drawing.SystemColors.Control;
            this.btncardio.BorderColor1 = System.Drawing.SystemColors.Control;
            this.btncardio.BorderRadius = 1;
            this.btncardio.BorderRadius1 = 1;
            this.btncardio.BorderSize = 6;
            this.btncardio.BorderSize1 = 6;
            this.btncardio.FlatAppearance.BorderSize = 0;
            this.btncardio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncardio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncardio.ForeColor = System.Drawing.Color.Transparent;
            this.btncardio.Location = new System.Drawing.Point(89, 196);
            this.btncardio.Name = "btncardio";
            this.btncardio.Size = new System.Drawing.Size(460, 491);
            this.btncardio.TabIndex = 3;
            this.btncardio.Text = "Cardio";
            this.btncardio.TextColor = System.Drawing.Color.Transparent;
            this.btncardio.UseVisualStyleBackColor = false;
            this.btncardio.Click += new System.EventHandler(this.btncardio_Click);
            // 
            // btnstrength
            // 
            this.btnstrength.BackColor = System.Drawing.Color.Transparent;
            this.btnstrength.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnstrength.BorderColor = System.Drawing.SystemColors.Control;
            this.btnstrength.BorderColor1 = System.Drawing.SystemColors.Control;
            this.btnstrength.BorderRadius = 1;
            this.btnstrength.BorderRadius1 = 1;
            this.btnstrength.BorderSize = 6;
            this.btnstrength.BorderSize1 = 6;
            this.btnstrength.FlatAppearance.BorderSize = 0;
            this.btnstrength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstrength.ForeColor = System.Drawing.Color.Transparent;
            this.btnstrength.Location = new System.Drawing.Point(800, 196);
            this.btnstrength.Name = "btnstrength";
            this.btnstrength.Size = new System.Drawing.Size(460, 491);
            this.btnstrength.TabIndex = 2;
            this.btnstrength.Text = "Strength";
            this.btnstrength.TextColor = System.Drawing.Color.Transparent;
            this.btnstrength.UseVisualStyleBackColor = false;
            this.btnstrength.Click += new System.EventHandler(this.btnstrength_Click);
            // 
            // Workouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.wrkouts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1344, 749);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.btncardio);
            this.Controls.Add(this.btnstrength);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Workouts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workouts";
            this.ResumeLayout(false);

        }

        #endregion
        private MyCal.mycalbuttons btnstrength;
        private MyCal.mycalbuttons btncardio;
        private System.Windows.Forms.Button backbtn;
    }
}