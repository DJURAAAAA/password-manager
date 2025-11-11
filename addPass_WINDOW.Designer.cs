namespace PassWordManager
{
    partial class addPass_WINDOW
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
            label1 = new Label();
            comboApp = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            userGmailTXT = new TextBox();
            passTXT = new TextBox();
            addPassBTN = new Button();
            label2 = new Label();
            label5 = new Label();
            autoGenerateBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(20, 72);
            label1.Name = "label1";
            label1.Size = new Size(299, 46);
            label1.TabIndex = 0;
            label1.Text = "Select aplication :";
            // 
            // comboApp
            // 
            comboApp.BackColor = SystemColors.InactiveCaption;
            comboApp.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            comboApp.ForeColor = SystemColors.MenuBar;
            comboApp.FormattingEnabled = true;
            comboApp.Items.AddRange(new object[] { "discord", "instagram", "viber", "google", "reddit", "suppercell", "facebook" });
            comboApp.Location = new Point(334, 72);
            comboApp.Name = "comboApp";
            comboApp.Size = new Size(268, 53);
            comboApp.TabIndex = 1;
            comboApp.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(131, 46);
            label3.TabIndex = 3;
            label3.Text = "Gmail :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(12, 218);
            label4.Name = "label4";
            label4.Size = new Size(190, 46);
            label4.TabIndex = 4;
            label4.Text = "password :";
            // 
            // userGmailTXT
            // 
            userGmailTXT.BackColor = SystemColors.InactiveCaption;
            userGmailTXT.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            userGmailTXT.ForeColor = SystemColors.MenuBar;
            userGmailTXT.Location = new Point(163, 143);
            userGmailTXT.Name = "userGmailTXT";
            userGmailTXT.Size = new Size(208, 51);
            userGmailTXT.TabIndex = 5;
            // 
            // passTXT
            // 
            passTXT.BackColor = SystemColors.InactiveCaption;
            passTXT.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            passTXT.ForeColor = SystemColors.MenuBar;
            passTXT.Location = new Point(216, 215);
            passTXT.Name = "passTXT";
            passTXT.Size = new Size(208, 51);
            passTXT.TabIndex = 6;
            // 
            // addPassBTN
            // 
            addPassBTN.BackColor = SystemColors.ControlDark;
            addPassBTN.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addPassBTN.ForeColor = SystemColors.ButtonFace;
            addPassBTN.Location = new Point(105, 335);
            addPassBTN.Name = "addPassBTN";
            addPassBTN.Size = new Size(205, 82);
            addPassBTN.TabIndex = 7;
            addPassBTN.Text = "ADD";
            addPassBTN.UseVisualStyleBackColor = false;
            addPassBTN.Click += addPassBTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(305, 304);
            label2.Name = "label2";
            label2.Size = new Size(497, 28);
            label2.TabIndex = 8;
            label2.Text = "Do not use your old password try create different !";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(316, 332);
            label5.Name = "label5";
            label5.Size = new Size(486, 28);
            label5.TabIndex = 9;
            label5.Text = "If u can't create different pass click auto generate";
            // 
            // autoGenerateBTN
            // 
            autoGenerateBTN.BackColor = SystemColors.AppWorkspace;
            autoGenerateBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoGenerateBTN.ForeColor = SystemColors.ButtonFace;
            autoGenerateBTN.Location = new Point(481, 374);
            autoGenerateBTN.Name = "autoGenerateBTN";
            autoGenerateBTN.Size = new Size(200, 54);
            autoGenerateBTN.TabIndex = 10;
            autoGenerateBTN.Text = "AUTO GENERATE";
            autoGenerateBTN.UseVisualStyleBackColor = false;
            autoGenerateBTN.Click += autoGenerateBTN_Click;
            // 
            // addPass_WINDOW
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(autoGenerateBTN);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(addPassBTN);
            Controls.Add(passTXT);
            Controls.Add(userGmailTXT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboApp);
            Controls.Add(label1);
            Name = "addPass_WINDOW";
            Text = "addPass_WINDOW";
            Load += addPass_WINDOW_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboApp;
        private Label label3;
        private Label label4;
        private TextBox userGmailTXT;
        private TextBox passTXT;
        private Button addPassBTN;
        private Label label2;
        private Label label5;
        private Button autoGenerateBTN;
    }
}