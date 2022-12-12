namespace Login
{
    partial class MainInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.lblcal = new System.Windows.Forms.Label();
            this.pbplus = new System.Windows.Forms.PictureBox();
            this.lblcarbs = new System.Windows.Forms.Label();
            this.lblpro = new System.Windows.Forms.Label();
            this.lblfat = new System.Windows.Forms.Label();
            this.lbleat = new System.Windows.Forms.Label();
            this.lblburned = new System.Windows.Forms.Label();
            this.pbInfoAc = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.lblwater = new System.Windows.Forms.Label();
            this.pbwaterup = new System.Windows.Forms.PictureBox();
            this.pbwaterdown = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnWorkouts = new MyCal.mycalbuttons();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbplus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfoAc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbwaterup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbwaterdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSettings
            // 
            this.pbSettings.BackColor = System.Drawing.Color.Transparent;
            this.pbSettings.BackgroundImage = global::Login.Properties.Resources.Settings_Cog;
            this.pbSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSettings.Location = new System.Drawing.Point(1280, 1);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(64, 64);
            this.pbSettings.TabIndex = 1;
            this.pbSettings.TabStop = false;
            this.pbSettings.Click += new System.EventHandler(this.pbSettings_Click);
            // 
            // lblcal
            // 
            this.lblcal.AutoSize = true;
            this.lblcal.BackColor = System.Drawing.Color.Transparent;
            this.lblcal.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcal.ForeColor = System.Drawing.Color.White;
            this.lblcal.Location = new System.Drawing.Point(405, 201);
            this.lblcal.Name = "lblcal";
            this.lblcal.Size = new System.Drawing.Size(38, 42);
            this.lblcal.TabIndex = 2;
            this.lblcal.Text = "0";
            // 
            // pbplus
            // 
            this.pbplus.BackColor = System.Drawing.Color.Transparent;
            this.pbplus.BackgroundImage = global::Login.Properties.Resources.Plus;
            this.pbplus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbplus.Location = new System.Drawing.Point(60, 514);
            this.pbplus.Name = "pbplus";
            this.pbplus.Size = new System.Drawing.Size(64, 64);
            this.pbplus.TabIndex = 3;
            this.pbplus.TabStop = false;
            this.pbplus.Click += new System.EventHandler(this.pbplus_Click);
            // 
            // lblcarbs
            // 
            this.lblcarbs.AutoSize = true;
            this.lblcarbs.BackColor = System.Drawing.Color.Transparent;
            this.lblcarbs.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarbs.ForeColor = System.Drawing.Color.White;
            this.lblcarbs.Location = new System.Drawing.Point(573, 264);
            this.lblcarbs.Name = "lblcarbs";
            this.lblcarbs.Size = new System.Drawing.Size(38, 42);
            this.lblcarbs.TabIndex = 4;
            this.lblcarbs.Text = "0";
            // 
            // lblpro
            // 
            this.lblpro.AutoSize = true;
            this.lblpro.BackColor = System.Drawing.Color.Transparent;
            this.lblpro.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpro.ForeColor = System.Drawing.Color.White;
            this.lblpro.Location = new System.Drawing.Point(571, 333);
            this.lblpro.Name = "lblpro";
            this.lblpro.Size = new System.Drawing.Size(38, 42);
            this.lblpro.TabIndex = 5;
            this.lblpro.Text = "0";
            // 
            // lblfat
            // 
            this.lblfat.AutoSize = true;
            this.lblfat.BackColor = System.Drawing.Color.Transparent;
            this.lblfat.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfat.ForeColor = System.Drawing.Color.White;
            this.lblfat.Location = new System.Drawing.Point(575, 404);
            this.lblfat.Name = "lblfat";
            this.lblfat.Size = new System.Drawing.Size(38, 42);
            this.lblfat.TabIndex = 6;
            this.lblfat.Text = "0";
            // 
            // lbleat
            // 
            this.lbleat.AutoSize = true;
            this.lbleat.BackColor = System.Drawing.Color.Transparent;
            this.lbleat.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleat.ForeColor = System.Drawing.Color.White;
            this.lbleat.Location = new System.Drawing.Point(145, 317);
            this.lbleat.Name = "lbleat";
            this.lbleat.Size = new System.Drawing.Size(38, 42);
            this.lbleat.TabIndex = 7;
            this.lbleat.Text = "0";
            // 
            // lblburned
            // 
            this.lblburned.AutoSize = true;
            this.lblburned.BackColor = System.Drawing.Color.Transparent;
            this.lblburned.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblburned.ForeColor = System.Drawing.Color.White;
            this.lblburned.Location = new System.Drawing.Point(146, 423);
            this.lblburned.Name = "lblburned";
            this.lblburned.Size = new System.Drawing.Size(38, 42);
            this.lblburned.TabIndex = 8;
            this.lblburned.Text = "0";
            // 
            // pbInfoAc
            // 
            this.pbInfoAc.BackColor = System.Drawing.Color.Transparent;
            this.pbInfoAc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInfoAc.Image = global::Login.Properties.Resources.surface1info;
            this.pbInfoAc.Location = new System.Drawing.Point(643, 478);
            this.pbInfoAc.Name = "pbInfoAc";
            this.pbInfoAc.Size = new System.Drawing.Size(17, 17);
            this.pbInfoAc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbInfoAc.TabIndex = 25;
            this.pbInfoAc.TabStop = false;
            this.pbInfoAc.Click += new System.EventHandler(this.pbInfoAc_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(362, 568);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(12, 11);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(607, 568);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(12, 11);
            this.checkBox2.TabIndex = 32;
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(803, 568);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(12, 11);
            this.checkBox3.TabIndex = 33;
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Location = new System.Drawing.Point(988, 568);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(12, 11);
            this.checkBox4.TabIndex = 34;
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // lblwater
            // 
            this.lblwater.AutoSize = true;
            this.lblwater.BackColor = System.Drawing.Color.Transparent;
            this.lblwater.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwater.ForeColor = System.Drawing.Color.White;
            this.lblwater.Location = new System.Drawing.Point(827, 263);
            this.lblwater.Name = "lblwater";
            this.lblwater.Size = new System.Drawing.Size(38, 42);
            this.lblwater.TabIndex = 35;
            this.lblwater.Text = "0";
            // 
            // pbwaterup
            // 
            this.pbwaterup.BackColor = System.Drawing.Color.Transparent;
            this.pbwaterup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbwaterup.Image = global::Login.Properties.Resources.WaterUp;
            this.pbwaterup.Location = new System.Drawing.Point(1046, 201);
            this.pbwaterup.Name = "pbwaterup";
            this.pbwaterup.Size = new System.Drawing.Size(70, 70);
            this.pbwaterup.TabIndex = 37;
            this.pbwaterup.TabStop = false;
            this.pbwaterup.Click += new System.EventHandler(this.pbwaterup_Click);
            // 
            // pbwaterdown
            // 
            this.pbwaterdown.BackColor = System.Drawing.Color.Transparent;
            this.pbwaterdown.BackgroundImage = global::Login.Properties.Resources.WaterDown;
            this.pbwaterdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbwaterdown.Location = new System.Drawing.Point(1046, 295);
            this.pbwaterdown.Name = "pbwaterdown";
            this.pbwaterdown.Size = new System.Drawing.Size(70, 70);
            this.pbwaterdown.TabIndex = 38;
            this.pbwaterdown.TabStop = false;
            this.pbwaterdown.Click += new System.EventHandler(this.pbwaterdown_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Login.Properties.Resources.surface1info;
            this.pictureBox2.Location = new System.Drawing.Point(767, 365);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnWorkouts
            // 
            this.btnWorkouts.BackColor = System.Drawing.Color.Transparent;
            this.btnWorkouts.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnWorkouts.BorderColor = System.Drawing.SystemColors.Control;
            this.btnWorkouts.BorderColor1 = System.Drawing.SystemColors.Control;
            this.btnWorkouts.BorderRadius = 1;
            this.btnWorkouts.BorderRadius1 = 1;
            this.btnWorkouts.BorderSize = 6;
            this.btnWorkouts.BorderSize1 = 6;
            this.btnWorkouts.FlatAppearance.BorderSize = 0;
            this.btnWorkouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkouts.ForeColor = System.Drawing.Color.Transparent;
            this.btnWorkouts.Location = new System.Drawing.Point(487, 648);
            this.btnWorkouts.Name = "btnWorkouts";
            this.btnWorkouts.Size = new System.Drawing.Size(472, 44);
            this.btnWorkouts.TabIndex = 0;
            this.btnWorkouts.Text = "Workouts";
            this.btnWorkouts.TextColor = System.Drawing.Color.Transparent;
            this.btnWorkouts.UseVisualStyleBackColor = false;
            this.btnWorkouts.Click += new System.EventHandler(this.btnWorkouts_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.MI;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbwaterdown);
            this.Controls.Add(this.pbwaterup);
            this.Controls.Add(this.lblwater);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pbInfoAc);
            this.Controls.Add(this.lblburned);
            this.Controls.Add(this.lbleat);
            this.Controls.Add(this.lblfat);
            this.Controls.Add(this.lblpro);
            this.Controls.Add(this.lblcarbs);
            this.Controls.Add(this.pbplus);
            this.Controls.Add(this.lblcal);
            this.Controls.Add(this.pbSettings);
            this.Controls.Add(this.btnWorkouts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainInterface";
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbplus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfoAc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbwaterup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbwaterdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCal.mycalbuttons btnWorkouts;
        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.Label lblcal;
        private System.Windows.Forms.PictureBox pbplus;
        private System.Windows.Forms.Label lblcarbs;
        private System.Windows.Forms.Label lblpro;
        private System.Windows.Forms.Label lblfat;
        private System.Windows.Forms.Label lbleat;
        private System.Windows.Forms.Label lblburned;
        private System.Windows.Forms.PictureBox pbInfoAc;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label lblwater;
        private System.Windows.Forms.PictureBox pbwaterup;
        private System.Windows.Forms.PictureBox pbwaterdown;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}