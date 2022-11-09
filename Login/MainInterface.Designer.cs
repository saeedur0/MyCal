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
            this.btnWorkouts = new MyCal.mycalbuttons();
            this.SuspendLayout();
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
            this.ClientSize = new System.Drawing.Size(1344, 749);
            this.Controls.Add(this.btnWorkouts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainInterface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private MyCal.mycalbuttons btnWorkouts;
    }
}