
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
            this.locationBox = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.selectCityButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.day1Button = new System.Windows.Forms.Button();
            this.day2Button = new System.Windows.Forms.Button();
            this.day4Button = new System.Windows.Forms.Button();
            this.day3Button = new System.Windows.Forms.Button();
            this.day6Button = new System.Windows.Forms.Button();
            this.day5Button = new System.Windows.Forms.Button();
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
            this.weekButton.Text = "Forecast";
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
            // locationBox
            // 
            this.locationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(194)))), ((int)(((byte)(254)))));
            this.locationBox.Enabled = false;
            this.locationBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.locationBox.ForeColor = System.Drawing.Color.White;
            this.locationBox.Location = new System.Drawing.Point(15, 104);
            this.locationBox.MaxLength = 100;
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(240, 29);
            this.locationBox.TabIndex = 3;
            this.locationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.locationBox.Visible = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(19, 76);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(146, 25);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Enter City Here";
            this.labelInfo.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.White;
            this.errorLabel.Location = new System.Drawing.Point(95, 200);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(160, 25);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "Is this your city?";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel.Visible = false;
            // 
            // selectCityButton
            // 
            this.selectCityButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.selectCityButton.FlatAppearance.BorderSize = 5;
            this.selectCityButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.selectCityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectCityButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCityButton.ForeColor = System.Drawing.Color.White;
            this.selectCityButton.Location = new System.Drawing.Point(15, 240);
            this.selectCityButton.Name = "selectCityButton";
            this.selectCityButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.selectCityButton.Size = new System.Drawing.Size(320, 50);
            this.selectCityButton.TabIndex = 6;
            this.selectCityButton.Text = "Stratford, CA - 5°";
            this.selectCityButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectCityButton.UseVisualStyleBackColor = true;
            this.selectCityButton.Click += new System.EventHandler(this.selectCityButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(262, 104);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(73, 29);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // day1Button
            // 
            this.day1Button.BackColor = System.Drawing.Color.Transparent;
            this.day1Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.day1Button.FlatAppearance.BorderSize = 0;
            this.day1Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.day1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.day1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day1Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day1Button.ForeColor = System.Drawing.Color.White;
            this.day1Button.Location = new System.Drawing.Point(12, 320);
            this.day1Button.Name = "day1Button";
            this.day1Button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.day1Button.Size = new System.Drawing.Size(50, 320);
            this.day1Button.TabIndex = 8;
            this.day1Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.day1Button.UseVisualStyleBackColor = false;
            this.day1Button.Click += new System.EventHandler(this.day1Button_Click);
            // 
            // day2Button
            // 
            this.day2Button.BackColor = System.Drawing.Color.Transparent;
            this.day2Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.day2Button.FlatAppearance.BorderSize = 0;
            this.day2Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.day2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.day2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day2Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day2Button.ForeColor = System.Drawing.Color.White;
            this.day2Button.Location = new System.Drawing.Point(67, 320);
            this.day2Button.Name = "day2Button";
            this.day2Button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.day2Button.Size = new System.Drawing.Size(50, 320);
            this.day2Button.TabIndex = 9;
            this.day2Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.day2Button.UseVisualStyleBackColor = false;
            this.day2Button.Click += new System.EventHandler(this.day2Button_Click);
            // 
            // day4Button
            // 
            this.day4Button.BackColor = System.Drawing.Color.Transparent;
            this.day4Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.day4Button.FlatAppearance.BorderSize = 0;
            this.day4Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.day4Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.day4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day4Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day4Button.ForeColor = System.Drawing.Color.White;
            this.day4Button.Location = new System.Drawing.Point(177, 320);
            this.day4Button.Name = "day4Button";
            this.day4Button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.day4Button.Size = new System.Drawing.Size(50, 320);
            this.day4Button.TabIndex = 11;
            this.day4Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.day4Button.UseVisualStyleBackColor = false;
            this.day4Button.Click += new System.EventHandler(this.day4Button_Click);
            // 
            // day3Button
            // 
            this.day3Button.BackColor = System.Drawing.Color.Transparent;
            this.day3Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.day3Button.FlatAppearance.BorderSize = 0;
            this.day3Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.day3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.day3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day3Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day3Button.ForeColor = System.Drawing.Color.White;
            this.day3Button.Location = new System.Drawing.Point(122, 320);
            this.day3Button.Name = "day3Button";
            this.day3Button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.day3Button.Size = new System.Drawing.Size(50, 320);
            this.day3Button.TabIndex = 10;
            this.day3Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.day3Button.UseVisualStyleBackColor = false;
            this.day3Button.Click += new System.EventHandler(this.day3Button_Click);
            // 
            // day6Button
            // 
            this.day6Button.BackColor = System.Drawing.Color.Transparent;
            this.day6Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.day6Button.FlatAppearance.BorderSize = 0;
            this.day6Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.day6Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.day6Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day6Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day6Button.ForeColor = System.Drawing.Color.White;
            this.day6Button.Location = new System.Drawing.Point(287, 320);
            this.day6Button.Name = "day6Button";
            this.day6Button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.day6Button.Size = new System.Drawing.Size(50, 320);
            this.day6Button.TabIndex = 13;
            this.day6Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.day6Button.UseVisualStyleBackColor = false;
            this.day6Button.Click += new System.EventHandler(this.day6Button_Click);
            // 
            // day5Button
            // 
            this.day5Button.BackColor = System.Drawing.Color.Transparent;
            this.day5Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.day5Button.FlatAppearance.BorderSize = 0;
            this.day5Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.day5Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.day5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day5Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day5Button.ForeColor = System.Drawing.Color.White;
            this.day5Button.Location = new System.Drawing.Point(232, 320);
            this.day5Button.Name = "day5Button";
            this.day5Button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.day5Button.Size = new System.Drawing.Size(50, 320);
            this.day5Button.TabIndex = 12;
            this.day5Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.day5Button.UseVisualStyleBackColor = false;
            this.day5Button.Click += new System.EventHandler(this.day5Button_Click);
            // 
            // WeatherScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(194)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.day6Button);
            this.Controls.Add(this.day5Button);
            this.Controls.Add(this.day4Button);
            this.Controls.Add(this.day3Button);
            this.Controls.Add(this.day2Button);
            this.Controls.Add(this.day1Button);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.selectCityButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.locationButton);
            this.Controls.Add(this.weekButton);
            this.Controls.Add(this.currentButton);
            this.DoubleBuffered = true;
            this.Name = "WeatherScreen";
            this.Size = new System.Drawing.Size(350, 650);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WeatherScreen_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer updateTick;
        private System.Windows.Forms.Button currentButton;
        private System.Windows.Forms.Button weekButton;
        private System.Windows.Forms.Button locationButton;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button selectCityButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button day1Button;
        private System.Windows.Forms.Button day2Button;
        private System.Windows.Forms.Button day4Button;
        private System.Windows.Forms.Button day3Button;
        private System.Windows.Forms.Button day6Button;
        private System.Windows.Forms.Button day5Button;
    }
}
