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
            this.btnWorkouts = new MyCal.mycalbuttons();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbplus)).BeginInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCal.mycalbuttons btnWorkouts;
        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.Label lblcal;
        private System.Windows.Forms.PictureBox pbplus;
    }
}