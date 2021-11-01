
namespace XMLWeather
{
    partial class WeatherScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.updateTick = new System.Windows.Forms.Timer(this.components);
            this.currentButton = new System.Windows.Forms.Button();
            this.weekButton = new System.Windows.Forms.Button();
            this.locationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateTick
            // 
            this.updateTick.Enabled = true;
            this.updateTick.Interval = 10;
            this.updateTick.Tick += new System.EventHandler(this.updateTick_Tick);
            // 
            // currentButton
            // 
            this.currentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.currentButton.FlatAppearance.BorderSize = 0;
            this.currentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentButton.ForeColor = System.Drawing.Color.White;
            this.currentButton.Location = new System.Drawing.Point(0, 0);
            this.currentButton.Name = "currentButton";
            this.currentButton.Size = new System.Drawing.Size(116, 60);
            this.currentButton.TabIndex = 0;
            this.currentButton.Text = "Current";
            this.currentButton.UseVisualStyleBackColor = false;
            this.currentButton.Click += new System.EventHandler(this.currentButton_Click);
            // 
            // weekButton
            // 
            this.weekButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.weekButton.FlatAppearance.BorderSize = 0;
            this.weekButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weekButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekButton.ForeColor = System.Drawing.Color.White;
            this.weekButton.Location = new System.Drawing.Point(116, 0);
            this.weekButton.Name = "weekButton";
            this.weekButton.Size = new System.Drawing.Size(116, 60);
            this.weekButton.TabIndex = 1;
            this.weekButton.Text = "7 Day";
            this.weekButton.UseVisualStyleBackColor = false;
            this.weekButton.Click += new System.EventHandler(this.weekButton_Click);
            // 
            // locationButton
            // 
            this.locationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(102)))), ((int)(((byte)(124)))));
            this.locationButton.FlatAppearance.BorderSize = 0;
            this.locationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationButton.ForeColor = System.Drawing.Color.White;
            this.locationButton.Location = new System.Drawing.Point(232, 0);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(118, 60);
            this.locationButton.TabIndex = 2;
            this.locationButton.Text = "Location";
            this.locationButton.UseVisualStyleBackColor = false;
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // WeatherScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(194)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.locationButton);
            this.Controls.Add(this.weekButton);
            this.Controls.Add(this.currentButton);
            this.DoubleBuffered = true;
            this.Name = "WeatherScreen";
            this.Size = new System.Drawing.Size(350, 650);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WeatherScreen_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer updateTick;
        private System.Windows.Forms.Button currentButton;
        private System.Windows.Forms.Button weekButton;
        private System.Windows.Forms.Button locationButton;
    }
}
