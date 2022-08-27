
namespace shoprite_Inventory_App
{
    partial class SalesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductCat = new System.Windows.Forms.ComboBox();
            this.productDisplay = new Guna.UI.WinForms.GunaDataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salesDisplay = new Guna.UI.WinForms.GunaDataGridView();
            this.datelabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.datelabel);
            this.panel1.Controls.Add(this.salesDisplay);
            this.panel1.Controls.Add(this.ProductCat);
            this.panel1.Controls.Add(this.productDisplay);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.ProductPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProductQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProductName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProductId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(189, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 866);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ProductCat
            // 
            this.ProductCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCat.ForeColor = System.Drawing.Color.Red;
            this.ProductCat.FormattingEnabled = true;
            this.ProductCat.Location = new System.Drawing.Point(95, 302);
            this.ProductCat.Name = "ProductCat";
            this.ProductCat.Size = new System.Drawing.Size(211, 33);
            this.ProductCat.TabIndex = 13;
            this.ProductCat.Text = "select category";
            // 
            // productDisplay
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.productDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.productDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productDisplay.BackgroundColor = System.Drawing.Color.White;
            this.productDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.productDisplay.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDisplay.DefaultCellStyle = dataGridViewCellStyle6;
            this.productDisplay.EnableHeadersVisualStyles = false;
            this.productDisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productDisplay.Location = new System.Drawing.Point(480, 505);
            this.productDisplay.Name = "productDisplay";
            this.productDisplay.RowHeadersVisible = false;
            this.productDisplay.RowHeadersWidth = 51;
            this.productDisplay.RowTemplate.Height = 24;
            this.productDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDisplay.Size = new System.Drawing.Size(672, 283);
            this.productDisplay.TabIndex = 12;
            this.productDisplay.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.productDisplay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.productDisplay.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.productDisplay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.productDisplay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.productDisplay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.productDisplay.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.productDisplay.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productDisplay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.productDisplay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productDisplay.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.productDisplay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.productDisplay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.productDisplay.ThemeStyle.HeaderStyle.Height = 4;
            this.productDisplay.ThemeStyle.ReadOnly = false;
            this.productDisplay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.productDisplay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productDisplay.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.productDisplay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.productDisplay.ThemeStyle.RowsStyle.Height = 24;
            this.productDisplay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productDisplay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(787, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 59);
            this.button3.TabIndex = 11;
            this.button3.Text = "EDIT";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(938, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 59);
            this.button2.TabIndex = 10;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(634, 426);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 59);
            this.button4.TabIndex = 4;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // ProductPrice
            // 
            this.ProductPrice.BackColor = System.Drawing.Color.White;
            this.ProductPrice.Enabled = false;
            this.ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProductPrice.ForeColor = System.Drawing.Color.Black;
            this.ProductPrice.Location = new System.Drawing.Point(176, 207);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(211, 26);
            this.ProductPrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price";
            // 
            // ProductQty
            // 
            this.ProductQty.BackColor = System.Drawing.Color.White;
            this.ProductQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProductQty.ForeColor = System.Drawing.Color.Black;
            this.ProductQty.Location = new System.Drawing.Point(176, 251);
            this.ProductQty.Name = "ProductQty";
            this.ProductQty.Size = new System.Drawing.Size(211, 26);
            this.ProductQty.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity:";
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.Color.White;
            this.ProductName.Enabled = false;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProductName.ForeColor = System.Drawing.Color.Black;
            this.ProductName.Location = new System.Drawing.Point(176, 162);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(211, 26);
            this.ProductName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = " Product Name";
            // 
            // ProductId
            // 
            this.ProductId.BackColor = System.Drawing.Color.White;
            this.ProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ProductId.ForeColor = System.Drawing.Color.Black;
            this.ProductId.Location = new System.Drawing.Point(176, 118);
            this.ProductId.Name = "ProductId";
            this.ProductId.Size = new System.Drawing.Size(211, 26);
            this.ProductId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BillId";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(593, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALES";
            // 
            // salesDisplay
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.salesDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.salesDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDisplay.BackgroundColor = System.Drawing.Color.White;
            this.salesDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.salesDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.salesDisplay.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesDisplay.DefaultCellStyle = dataGridViewCellStyle3;
            this.salesDisplay.EnableHeadersVisualStyles = false;
            this.salesDisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.salesDisplay.Location = new System.Drawing.Point(23, 341);
            this.salesDisplay.Name = "salesDisplay";
            this.salesDisplay.RowHeadersVisible = false;
            this.salesDisplay.RowHeadersWidth = 51;
            this.salesDisplay.RowTemplate.Height = 28;
            this.salesDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesDisplay.Size = new System.Drawing.Size(364, 447);
            this.salesDisplay.TabIndex = 14;
            this.salesDisplay.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.salesDisplay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.salesDisplay.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.salesDisplay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.salesDisplay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.salesDisplay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.salesDisplay.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.salesDisplay.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.salesDisplay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.salesDisplay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.salesDisplay.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesDisplay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.salesDisplay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.salesDisplay.ThemeStyle.HeaderStyle.Height = 30;
            this.salesDisplay.ThemeStyle.ReadOnly = false;
            this.salesDisplay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.salesDisplay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.salesDisplay.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.salesDisplay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salesDisplay.ThemeStyle.RowsStyle.Height = 28;
            this.salesDisplay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.salesDisplay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.salesDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDisplay_CellContentClick);
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelabel.ForeColor = System.Drawing.Color.White;
            this.datelabel.Location = new System.Drawing.Point(975, 7);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(48, 24);
            this.datelabel.TabIndex = 15;
            this.datelabel.Text = "Date";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 843);
            this.Controls.Add(this.panel1);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView salesDisplay;
        private System.Windows.Forms.ComboBox ProductCat;
        private Guna.UI.WinForms.GunaDataGridView productDisplay;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datelabel;
    }
}