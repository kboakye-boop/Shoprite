
namespace shoprite_Inventory_App
{
    partial class AttendantForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AttendantDisplay = new Guna.UI.WinForms.GunaDataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.AttendantPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AttendantUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AttendantId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.AttendantDisplay);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.AttendantPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.AttendantUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AttendantId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(192, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 857);
            this.panel1.TabIndex = 1;
            // 
            // AttendantDisplay
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AttendantDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AttendantDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AttendantDisplay.BackgroundColor = System.Drawing.Color.White;
            this.AttendantDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AttendantDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AttendantDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendantDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AttendantDisplay.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttendantDisplay.DefaultCellStyle = dataGridViewCellStyle3;
            this.AttendantDisplay.EnableHeadersVisualStyles = false;
            this.AttendantDisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendantDisplay.Location = new System.Drawing.Point(493, 113);
            this.AttendantDisplay.Name = "AttendantDisplay";
            this.AttendantDisplay.RowHeadersVisible = false;
            this.AttendantDisplay.RowHeadersWidth = 51;
            this.AttendantDisplay.RowTemplate.Height = 28;
            this.AttendantDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttendantDisplay.Size = new System.Drawing.Size(672, 670);
            this.AttendantDisplay.TabIndex = 13;
            this.AttendantDisplay.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.AttendantDisplay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AttendantDisplay.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AttendantDisplay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AttendantDisplay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AttendantDisplay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AttendantDisplay.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AttendantDisplay.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendantDisplay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AttendantDisplay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AttendantDisplay.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttendantDisplay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AttendantDisplay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AttendantDisplay.ThemeStyle.HeaderStyle.Height = 30;
            this.AttendantDisplay.ThemeStyle.ReadOnly = false;
            this.AttendantDisplay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AttendantDisplay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AttendantDisplay.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.AttendantDisplay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AttendantDisplay.ThemeStyle.RowsStyle.Height = 28;
            this.AttendantDisplay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendantDisplay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AttendantDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendantDisplay_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(24, 509);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 59);
            this.button3.TabIndex = 11;
            this.button3.Text = "EDIT PASSWORD";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(24, 603);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 59);
            this.button2.TabIndex = 10;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(23, 421);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 59);
            this.button4.TabIndex = 4;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AttendantPassword
            // 
            this.AttendantPassword.BackColor = System.Drawing.Color.White;
            this.AttendantPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AttendantPassword.ForeColor = System.Drawing.Color.Black;
            this.AttendantPassword.Location = new System.Drawing.Point(150, 258);
            this.AttendantPassword.Name = "AttendantPassword";
            this.AttendantPassword.Size = new System.Drawing.Size(211, 30);
            this.AttendantPassword.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "PASSWORD:";
            // 
            // AttendantUsername
            // 
            this.AttendantUsername.BackColor = System.Drawing.Color.White;
            this.AttendantUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AttendantUsername.ForeColor = System.Drawing.Color.Black;
            this.AttendantUsername.Location = new System.Drawing.Point(150, 183);
            this.AttendantUsername.Name = "AttendantUsername";
            this.AttendantUsername.Size = new System.Drawing.Size(211, 30);
            this.AttendantUsername.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "USERNAME:";
            // 
            // AttendantId
            // 
            this.AttendantId.BackColor = System.Drawing.Color.White;
            this.AttendantId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AttendantId.ForeColor = System.Drawing.Color.Black;
            this.AttendantId.Location = new System.Drawing.Point(150, 113);
            this.AttendantId.Name = "AttendantId";
            this.AttendantId.Size = new System.Drawing.Size(211, 30);
            this.AttendantId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(505, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE ATTENDANT";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(12, 313);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(159, 76);
            this.button7.TabIndex = 16;
            this.button7.Text = "Products";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(12, 447);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 76);
            this.button6.TabIndex = 15;
            this.button6.Text = "Selling";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(12, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 76);
            this.button5.TabIndex = 14;
            this.button5.Text = "Categories";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AttendantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 843);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Name = "AttendantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.AttendantForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox AttendantPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AttendantUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AttendantId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private Guna.UI.WinForms.GunaDataGridView AttendantDisplay;
    }
}