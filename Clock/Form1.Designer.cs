namespace Clock
{
    partial class Clock
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clockLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.redButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.styleButton1 = new System.Windows.Forms.Button();
            this.styleButton2 = new System.Windows.Forms.Button();
            this.styleButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.clockLabel.Location = new System.Drawing.Point(205, 133);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(215, 77);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "Loading...";
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clockLabel.Click += new System.EventHandler(this.clockLabel_Click);
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Firebrick;
            this.redButton.Location = new System.Drawing.Point(3, 367);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(21, 19);
            this.redButton.TabIndex = 1;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeButton.Location = new System.Drawing.Point(30, 367);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(21, 19);
            this.orangeButton.TabIndex = 2;
            this.orangeButton.UseVisualStyleBackColor = false;
            this.orangeButton.Click += new System.EventHandler(this.orangeButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.Location = new System.Drawing.Point(57, 367);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(21, 19);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Lime;
            this.greenButton.Location = new System.Drawing.Point(84, 367);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(21, 19);
            this.greenButton.TabIndex = 4;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.blueButton.Location = new System.Drawing.Point(111, 367);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(21, 19);
            this.blueButton.TabIndex = 5;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // styleButton1
            // 
            this.styleButton1.BackColor = System.Drawing.Color.White;
            this.styleButton1.Font = new System.Drawing.Font("Tempus Sans ITC", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.styleButton1.Location = new System.Drawing.Point(138, 363);
            this.styleButton1.Name = "styleButton1";
            this.styleButton1.Size = new System.Drawing.Size(75, 23);
            this.styleButton1.TabIndex = 6;
            this.styleButton1.Text = "Style 1";
            this.styleButton1.UseVisualStyleBackColor = false;
            this.styleButton1.Click += new System.EventHandler(this.styleButton1_Click);
            // 
            // styleButton2
            // 
            this.styleButton2.BackColor = System.Drawing.Color.White;
            this.styleButton2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.styleButton2.Location = new System.Drawing.Point(219, 363);
            this.styleButton2.Name = "styleButton2";
            this.styleButton2.Size = new System.Drawing.Size(75, 23);
            this.styleButton2.TabIndex = 7;
            this.styleButton2.Text = "Style 2";
            this.styleButton2.UseVisualStyleBackColor = false;
            this.styleButton2.Click += new System.EventHandler(this.styleButton2_Click);
            // 
            // styleButton3
            // 
            this.styleButton3.BackColor = System.Drawing.Color.White;
            this.styleButton3.Font = new System.Drawing.Font("Vivaldi", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.styleButton3.Location = new System.Drawing.Point(300, 363);
            this.styleButton3.Name = "styleButton3";
            this.styleButton3.Size = new System.Drawing.Size(75, 23);
            this.styleButton3.TabIndex = 8;
            this.styleButton3.Text = "Style 3";
            this.styleButton3.UseVisualStyleBackColor = false;
            this.styleButton3.Click += new System.EventHandler(this.styleButton3_Click);
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(654, 389);
            this.Controls.Add(this.styleButton3);
            this.Controls.Add(this.styleButton2);
            this.Controls.Add(this.styleButton1);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.orangeButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.clockLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Clock";
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label clockLabel;
        private System.Windows.Forms.Timer clockTimer;
        private Button redButton;
        private Button orangeButton;
        private Button yellowButton;
        private Button greenButton;
        private Button blueButton;
        private Button styleButton1;
        private Button styleButton2;
        private Button styleButton3;
    }
}