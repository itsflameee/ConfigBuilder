namespace ConfigBuilder
{
    partial class main_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_menu));
            logo = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnGitHub = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = Properties.Resources.logo;
            logo.BackgroundImageLayout = ImageLayout.Zoom;
            logo.FlatAppearance.BorderSize = 0;
            logo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            logo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            logo.FlatStyle = FlatStyle.Flat;
            logo.Location = new Point(0, 11);
            logo.Name = "logo";
            logo.Size = new Size(498, 105);
            logo.TabIndex = 0;
            logo.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.com_apple_Preferences;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(20, 165);
            button1.Name = "button1";
            button1.Size = new Size(103, 103);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.com_apple_mobilesafari;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(138, 165);
            button2.Name = "button2";
            button2.Size = new Size(103, 103);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.network;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(256, 165);
            button3.Name = "button3";
            button3.Size = new Size(103, 103);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.com_apple_DocumentsApp;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(374, 165);
            button4.Name = "button4";
            button4.Size = new Size(103, 103);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 128);
            label1.Name = "label1";
            label1.Size = new Size(63, 30);
            label1.TabIndex = 5;
            label1.Text = "Tools";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(20, 271);
            label2.Name = "label2";
            label2.Size = new Size(103, 39);
            label2.TabIndex = 6;
            label2.Text = ".mobileconfig\r\nBuilder";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(138, 271);
            label3.Name = "label3";
            label3.Size = new Size(103, 39);
            label3.TabIndex = 7;
            label3.Text = "Web-clip\r\nPre-Build\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(256, 271);
            label4.Name = "label4";
            label4.Size = new Size(103, 39);
            label4.TabIndex = 8;
            label4.Text = "Proxy Pre-Build\r\n(VPN / DNS)";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(374, 271);
            label5.Name = "label5";
            label5.Size = new Size(103, 39);
            label5.TabIndex = 9;
            label5.Text = "Data + Prefs\r\nPre-Build";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(20, 316);
            label6.Name = "label6";
            label6.Size = new Size(72, 30);
            label6.TabIndex = 10;
            label6.Text = "About";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 351);
            label7.Name = "label7";
            label7.Size = new Size(204, 15);
            label7.TabIndex = 11;
            label7.Text = "iOS ConfigBuilder | by its.flame | 1.0 | ";
            // 
            // btnGitHub
            // 
            btnGitHub.Location = new Point(224, 347);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new Size(59, 23);
            btnGitHub.TabIndex = 12;
            btnGitHub.Text = "GitHub";
            btnGitHub.UseVisualStyleBackColor = true;
            btnGitHub.Click += btnGitHub_Click;
            // 
            // button5
            // 
            button5.Location = new Point(287, 347);
            button5.Name = "button5";
            button5.Size = new Size(146, 23);
            button5.TabIndex = 13;
            button5.Text = "Guide (its.flame's Jailed)";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // main_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 377);
            Controls.Add(button5);
            Controls.Add(btnGitHub);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(logo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "main_menu";
            Text = "ConfigBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logo;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnGitHub;
        private Button button5;
    }
}
