namespace Reddit_RSS_Bot
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.subredditTextBox = new System.Windows.Forms.TextBox();
            this.feedTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.intervalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addFeedButton = new System.Windows.Forms.Button();
            this.NSFWCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.feedsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(12, 25);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subreddit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "RSS feed";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 64);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // subredditTextBox
            // 
            this.subredditTextBox.Location = new System.Drawing.Point(12, 103);
            this.subredditTextBox.Name = "subredditTextBox";
            this.subredditTextBox.Size = new System.Drawing.Size(200, 20);
            this.subredditTextBox.TabIndex = 6;
            // 
            // feedTextBox
            // 
            this.feedTextBox.Location = new System.Drawing.Point(12, 142);
            this.feedTextBox.Name = "feedTextBox";
            this.feedTextBox.Size = new System.Drawing.Size(325, 20);
            this.feedTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Interval (in seconds)";
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.Location = new System.Drawing.Point(218, 25);
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(200, 20);
            this.intervalTextBox.TabIndex = 9;
            this.intervalTextBox.Text = "60";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // addFeedButton
            // 
            this.addFeedButton.Location = new System.Drawing.Point(343, 140);
            this.addFeedButton.Name = "addFeedButton";
            this.addFeedButton.Size = new System.Drawing.Size(75, 23);
            this.addFeedButton.TabIndex = 13;
            this.addFeedButton.Text = "Add";
            this.addFeedButton.UseVisualStyleBackColor = true;
            this.addFeedButton.Click += new System.EventHandler(this.addFeedButton_Click);
            // 
            // NSFWCheckBox
            // 
            this.NSFWCheckBox.AutoSize = true;
            this.NSFWCheckBox.Location = new System.Drawing.Point(218, 67);
            this.NSFWCheckBox.Name = "NSFWCheckBox";
            this.NSFWCheckBox.Size = new System.Drawing.Size(58, 17);
            this.NSFWCheckBox.TabIndex = 14;
            this.NSFWCheckBox.Text = "NSFW";
            this.NSFWCheckBox.UseVisualStyleBackColor = true;
            this.NSFWCheckBox.CheckedChanged += new System.EventHandler(this.NSFWCheckBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "RSS feeds";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 367);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(406, 37);
            this.startButton.TabIndex = 17;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // feedsListBox
            // 
            this.feedsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.feedsListBox.FormattingEnabled = true;
            this.feedsListBox.ItemHeight = 16;
            this.feedsListBox.Location = new System.Drawing.Point(12, 181);
            this.feedsListBox.Name = "feedsListBox";
            this.feedsListBox.Size = new System.Drawing.Size(406, 180);
            this.feedsListBox.TabIndex = 18;
            this.feedsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.feedsListBox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 416);
            this.Controls.Add(this.feedsListBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NSFWCheckBox);
            this.Controls.Add(this.addFeedButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.intervalTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.feedTextBox);
            this.Controls.Add(this.subredditTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Reddit RSS bot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox subredditTextBox;
        private System.Windows.Forms.TextBox feedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox intervalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addFeedButton;
        private System.Windows.Forms.CheckBox NSFWCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox feedsListBox;
    }
}

