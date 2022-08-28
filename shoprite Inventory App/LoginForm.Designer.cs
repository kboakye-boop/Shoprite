
namespace shoprite_Inventory_App
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.selectRole = new System.Windows.Forms.ComboBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.loginPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 521);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(666, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to Shoprite Ghana ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.Controls.Add(this.selectRole);
            this.loginPanel.Controls.Add(this.passwordTb);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.usernameLabel);
            this.loginPanel.Controls.Add(this.panel4);
            this.loginPanel.Controls.Add(this.passwordText);
            this.loginPanel.Controls.Add(this.panel3);
            this.loginPanel.Controls.Add(this.usernameTb);
            this.loginPanel.Location = new System.Drawing.Point(311, 100);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(458, 365);
            this.loginPanel.TabIndex = 0;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // selectRole
            // 
            this.selectRole.BackColor = System.Drawing.Color.White;
            this.selectRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectRole.FormattingEnabled = true;
            this.selectRole.Items.AddRange(new object[] {
            "ADMIN",
            "ATTENDANT"});
            this.selectRole.Location = new System.Drawing.Point(260, 17);
            this.selectRole.Name = "selectRole";
            this.selectRole.Size = new System.Drawing.Size(144, 33);
            this.selectRole.TabIndex = 8;
            this.selectRole.Text = "Select Role";
            this.selectRole.SelectedIndexChanged += new System.EventHandler(this.selectRole_SelectedIndexChanged);
            // 
            // passwordTb
            // 
            this.passwordTb.BackColor = System.Drawing.Color.White;
            this.passwordTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.passwordTb.ForeColor = System.Drawing.Color.Black;
            this.passwordTb.Location = new System.Drawing.Point(80, 236);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(314, 27);
            this.passwordTb.TabIndex = 7;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Red;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Location = new System.Drawing.Point(92, 282);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(289, 46);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.White;
            this.passwordLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passwordLabel.ForeColor = System.Drawing.Color.Black;
            this.passwordLabel.Location = new System.Drawing.Point(80, 195);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(100, 19);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.White;
            this.usernameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usernameLabel.ForeColor = System.Drawing.Color.Black;
            this.usernameLabel.Location = new System.Drawing.Point(80, 102);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(100, 19);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.TextChanged += new System.EventHandler(this.emailLabel_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(80, 265);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 1);
            this.panel4.TabIndex = 3;
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.Color.White;
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.passwordText.ForeColor = System.Drawing.Color.Black;
            this.passwordText.Location = new System.Drawing.Point(80, 175);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(314, 27);
            this.passwordText.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(80, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 1);
            this.panel3.TabIndex = 1;
            // 
            // usernameTb
            // 
            this.usernameTb.BackColor = System.Drawing.Color.White;
            this.usernameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.usernameTb.ForeColor = System.Drawing.Color.Black;
            this.usernameTb.Location = new System.Drawing.Point(80, 139);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(314, 27);
            this.usernameTb.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 521);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox usernameLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox selectRole;
    }
}

