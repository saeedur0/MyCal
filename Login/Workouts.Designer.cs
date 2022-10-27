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
            this.mycalbuttons1 = new MyCal.mycalbuttons();
            this.SuspendLayout();
            // 
            // mycalbuttons1
            // 
            this.mycalbuttons1.BackColor = System.Drawing.Color.Transparent;
            this.mycalbuttons1.BackgroundColor = System.Drawing.Color.Transparent;
            this.mycalbuttons1.BorderColor = System.Drawing.Color.Transparent;
            this.mycalbuttons1.BorderColor1 = System.Drawing.Color.Transparent;
            this.mycalbuttons1.BorderRadius = 20;
            this.mycalbuttons1.BorderRadius1 = 20;
            this.mycalbuttons1.BorderSize = 0;
            this.mycalbuttons1.BorderSize1 = 0;
            this.mycalbuttons1.FlatAppearance.BorderSize = 0;
            this.mycalbuttons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mycalbuttons1.ForeColor = System.Drawing.Color.Transparent;
            this.mycalbuttons1.Location = new System.Drawing.Point(443, 302);
            this.mycalbuttons1.Name = "mycalbuttons1";
            this.mycalbuttons1.Size = new System.Drawing.Size(150, 40);
            this.mycalbuttons1.TabIndex = 0;
            this.mycalbuttons1.Text = "mycalbuttons1";
            this.mycalbuttons1.TextColor = System.Drawing.Color.Transparent;
            this.mycalbuttons1.UseVisualStyleBackColor = false;
            // 
            // Workouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.wrkouts;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1344, 749);
            this.Controls.Add(this.mycalbuttons1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Workouts";
            this.Text = "Workouts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private MyCal.mycalbuttons mycalbuttons1;
    }
}