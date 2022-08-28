
namespace shoprite_Inventory_App
{
    partial class ProductsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductDropdown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductCat = new System.Windows.Forms.ComboBox();
            this.productDisplay = new Guna.UI.WinForms.GunaDataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ProductQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ProductDropdown);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ProductCat);
            this.panel1.Controls.Add(this.productDisplay);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.ProductQty);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProductPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProductName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProductId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(205, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 866);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(860, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ProductDropdown
            // 
            this.ProductDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDropdown.ForeColor = System.Drawing.Color.Red;
            this.ProductDropdown.FormattingEnabled = true;
            this.ProductDropdown.Location = new System.Drawing.Point(634, 79);
            this.ProductDropdown.Name = "ProductDropdown";
            this.ProductDropdown.Size = new System.Drawing.Size(211, 33);
            this.ProductDropdown.TabIndex = 15;
            this.ProductDropdown.Text = "select category";
            this.ProductDropdown.SelectedIndexChanged += new System.EventHandler(this.ProductDropdown_SelectedIndexChanged);
            this.ProductDropdown.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "CATEGORIES:";
            // 
            // ProductCat
            // 
            this.ProductCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCat.ForeColor = System.Drawing.Color.Red;
            this.ProductCat.FormattingEnabled = true;
            this.ProductCat.Location = new System.Drawing.Point(176, 426);
            this.ProductCat.Name = "ProductCat";
            this.ProductCat.Size = new System.Drawing.Size(211, 33);
            this.ProductCat.TabIndex = 13;
            this.ProductCat.Text = "select category";
            this.ProductCat.SelectedIndexChanged += new System.EventHandler(this.ProductCat_SelectedIndexChanged);
            // 
            // productDisplay
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.productDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.productDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDisplay.BackgroundColor = System.Drawing.Color.White;
            this.productDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.productDisplay.ColumnHeadersHeight = 30;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDisplay.DefaultCellStyle = dataGridViewCellStyle12;
            this.productDisplay.EnableHeadersVisualStyles = false;
            this.productDisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productDisplay.Location = new System.Drawing.Point(480, 118);
            this.productDisplay.Name = "productDisplay";
            this.productDisplay.RowHeadersVisible = false;
            this.productDisplay.RowHeadersWidth = 51;
            this.productDisplay.RowTemplate.Height = 28;
            this.productDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDisplay.Size = new System.Drawing.Size(672, 670);
            this.productDisplay.TabIndex = 12;
            this.productDisplay.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.productDisplay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.productDisplay.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.productDisplay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.productDisplay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.productDisplay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.productDisplay.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.productDisplay.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productDisplay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.productDisplay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productDisplay.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold);
            this.productDisplay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.productDisplay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.productDisplay.ThemeStyle.HeaderStyle.Height = 30;
            this.productDisplay.ThemeStyle.ReadOnly = false;
            this.productDisplay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.productDisplay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productDisplay.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.productDisplay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.productDisplay.ThemeStyle.RowsStyle.Height = 28;
            this.productDisplay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productDisplay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDisplay_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(25, 622);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 59);
            this.button3.TabIndex = 11;
            this.button3.Text = "EDIT";
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
            this.button2.Location = new System.Drawing.Point(25, 716);
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
            this.button4.Location = new System.Drawing.Point(24, 534);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 59);
            this.button4.TabIndex = 4;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ProductQty
            // 
            this.ProductQty.BackColor = System.Drawing.Color.White;
            this.ProductQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProductQty.ForeColor = System.Drawing.Color.Black;
            this.ProductQty.Location = new System.Drawing.Point(176, 263);
            this.ProductQty.Name = "ProductQty";
            this.ProductQty.Size = new System.Drawing.Size(211, 30);
            this.ProductQty.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "QUANTITY:";
            // 
            // ProductPrice
            // 
            this.ProductPrice.BackColor = System.Drawing.Color.White;
            this.ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProductPrice.ForeColor = System.Drawing.Color.Black;
            this.ProductPrice.Location = new System.Drawing.Point(176, 338);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(211, 30);
            this.ProductPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "PRICE:";
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.Color.White;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProductName.ForeColor = System.Drawing.Color.Black;
            this.ProductName.Location = new System.Drawing.Point(176, 188);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(211, 30);
            this.ProductName.TabIndex = 5;
            this.ProductName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "NAME:";
            // 
            // ProductId
            // 
            this.ProductId.BackColor = System.Drawing.Color.White;
            this.ProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProductId.ForeColor = System.Drawing.Color.Black;
            this.ProductId.Location = new System.Drawing.Point(176, 118);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(211, 30);
            this.ProductId.TabIndex = 3;
            this.ProductId.TextChanged += new System.EventHandler(this.ProductId_TextChanged);
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
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PRODUCTS";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(25, 208);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 76);
            this.button5.TabIndex = 2;
            this.button5.Text = "Categories\r\n\r\n";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(25, 335);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(159, 76);
            this.button7.TabIndex = 4;
            this.button7.Text = "Attendant";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(52, 747);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 29);
            this.label8.TabIndex = 27;
            this.label8.Text = "Log Out";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1369, 843);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductId;
        private System.Windows.Forms.TextBox ProductQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private Guna.UI.WinForms.GunaDataGridView productDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ProductCat;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox ProductDropdown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}