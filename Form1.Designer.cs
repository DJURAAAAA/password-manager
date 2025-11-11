namespace PassWordManager
{
    partial class MainWindow
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
            panel1 = new Panel();
            addPasswordBTN = new Button();
            favoritesBTN = new Button();
            log_outBTN = new Button();
            log_inBTN = new Button();
            profilePIC = new PictureBox();
            userNameLBL = new Label();
            panel2 = new Panel();
            showPassVIEW = new ListView();
            panel3 = new Panel();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            showBTN = new Button();
            userPassLBL = new Label();
            copyBTN = new Button();
            label3 = new Label();
            userGmailLBL = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePIC).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(addPasswordBTN);
            panel1.Controls.Add(favoritesBTN);
            panel1.Controls.Add(log_outBTN);
            panel1.Controls.Add(log_inBTN);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(130, 536);
            panel1.TabIndex = 1;
            // 
            // addPasswordBTN
            // 
            addPasswordBTN.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addPasswordBTN.Location = new Point(17, 341);
            addPasswordBTN.Name = "addPasswordBTN";
            addPasswordBTN.Size = new Size(94, 81);
            addPasswordBTN.TabIndex = 9;
            addPasswordBTN.Text = "📂";
            addPasswordBTN.UseVisualStyleBackColor = true;
            addPasswordBTN.Click += addPasswordBTN_Click;
            // 
            // favoritesBTN
            // 
            favoritesBTN.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            favoritesBTN.Location = new Point(17, 237);
            favoritesBTN.Name = "favoritesBTN";
            favoritesBTN.Size = new Size(94, 81);
            favoritesBTN.TabIndex = 8;
            favoritesBTN.Text = "⭐";
            favoritesBTN.UseVisualStyleBackColor = true;
            favoritesBTN.Click += favoritesBTN_Click;
            // 
            // log_outBTN
            // 
            log_outBTN.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            log_outBTN.Location = new Point(17, 129);
            log_outBTN.Name = "log_outBTN";
            log_outBTN.Size = new Size(94, 81);
            log_outBTN.TabIndex = 7;
            log_outBTN.Text = "➜]";
            log_outBTN.UseVisualStyleBackColor = true;
            log_outBTN.Click += log_outBTN_Click;
            // 
            // log_inBTN
            // 
            log_inBTN.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            log_inBTN.Location = new Point(17, 27);
            log_inBTN.Name = "log_inBTN";
            log_inBTN.Size = new Size(94, 81);
            log_inBTN.TabIndex = 6;
            log_inBTN.Text = "👤";
            log_inBTN.UseVisualStyleBackColor = true;
            log_inBTN.Click += log_inBTN_Click;
            // 
            // profilePIC
            // 
            profilePIC.Image = Properties.Resources.guest;
            profilePIC.Location = new Point(174, 12);
            profilePIC.Name = "profilePIC";
            profilePIC.Size = new Size(82, 80);
            profilePIC.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePIC.TabIndex = 4;
            profilePIC.TabStop = false;
            // 
            // userNameLBL
            // 
            userNameLBL.AutoSize = true;
            userNameLBL.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userNameLBL.ForeColor = SystemColors.ButtonFace;
            userNameLBL.Location = new Point(271, 29);
            userNameLBL.Name = "userNameLBL";
            userNameLBL.Size = new Size(194, 38);
            userNameLBL.TabIndex = 5;
            userNameLBL.Text = "Hello, Guest !";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(showPassVIEW);
            panel2.Location = new Point(174, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(466, 417);
            panel2.TabIndex = 6;
            // 
            // showPassVIEW
            // 
            showPassVIEW.FullRowSelect = true;
            showPassVIEW.Location = new Point(3, 3);
            showPassVIEW.Name = "showPassVIEW";
            showPassVIEW.Size = new Size(460, 411);
            showPassVIEW.TabIndex = 8;
            showPassVIEW.UseCompatibleStateImageBehavior = false;
            showPassVIEW.SelectedIndexChanged += showPassVIEW_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(button10);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(showBTN);
            panel3.Controls.Add(userPassLBL);
            panel3.Controls.Add(copyBTN);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(userGmailLBL);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(666, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(327, 509);
            panel3.TabIndex = 7;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(174, 460);
            button10.Name = "button10";
            button10.Size = new Size(127, 36);
            button10.TabIndex = 10;
            button10.Text = "vip";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(21, 460);
            button9.Name = "button9";
            button9.Size = new Size(127, 36);
            button9.TabIndex = 9;
            button9.Text = "hoster";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(174, 408);
            button8.Name = "button8";
            button8.Size = new Size(127, 36);
            button8.TabIndex = 8;
            button8.Text = "Security";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(20, 408);
            button7.Name = "button7";
            button7.Size = new Size(127, 36);
            button7.TabIndex = 7;
            button7.Text = "Dev";
            button7.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(12, 364);
            label7.Name = "label7";
            label7.Size = new Size(89, 41);
            label7.TabIndex = 6;
            label7.Text = "Tags:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 309);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 5;
            label4.Text = "passSaver.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(3, 250);
            label5.Name = "label5";
            label5.Size = new Size(320, 41);
            label5.TabIndex = 4;
            label5.Text = "Web/Hosting service:";
            // 
            // showBTN
            // 
            showBTN.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showBTN.Location = new Point(261, 190);
            showBTN.Name = "showBTN";
            showBTN.Size = new Size(40, 36);
            showBTN.TabIndex = 1;
            showBTN.Text = "👁";
            showBTN.UseVisualStyleBackColor = true;
            showBTN.Click += showBTN_Click;
            // 
            // userPassLBL
            // 
            userPassLBL.AutoSize = true;
            userPassLBL.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userPassLBL.Location = new Point(20, 201);
            userPassLBL.Name = "userPassLBL";
            userPassLBL.Size = new Size(127, 25);
            userPassLBL.TabIndex = 3;
            userPassLBL.Text = ".......................";
            // 
            // copyBTN
            // 
            copyBTN.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            copyBTN.Location = new Point(199, 190);
            copyBTN.Name = "copyBTN";
            copyBTN.Size = new Size(40, 36);
            copyBTN.TabIndex = 0;
            copyBTN.Text = "⿻";
            copyBTN.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(20, 142);
            label3.Name = "label3";
            label3.Size = new Size(158, 41);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // userGmailLBL
            // 
            userGmailLBL.AutoSize = true;
            userGmailLBL.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userGmailLBL.Location = new Point(21, 92);
            userGmailLBL.Name = "userGmailLBL";
            userGmailLBL.Size = new Size(189, 25);
            userGmailLBL.TabIndex = 1;
            userGmailLBL.Text = "example@gmail.com";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(21, 40);
            label1.Name = "label1";
            label1.Size = new Size(198, 41);
            label1.TabIndex = 0;
            label1.Text = "Email/Gmail:";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1011, 560);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(userNameLBL);
            Controls.Add(profilePIC);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PassWord manager";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profilePIC).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private PictureBox profilePIC;
        private Label userNameLBL;
        private Button addPasswordBTN;
        private Button favoritesBTN;
        private Button log_outBTN;
        private Button log_inBTN;
        private Panel panel2;
        private Panel panel3;
        private Label userPassLBL;
        private Label label3;
        private Label userGmailLBL;
        private Label label1;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Label label7;
        private Label label4;
        private Label label5;
        private Button showBTN;
        private Button copyBTN;
        private ListView showPassVIEW;
    }
}
