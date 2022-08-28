
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.attendantNameLable = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.orderDisplay = new Guna.UI.WinForms.GunaDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.datelabel = new System.Windows.Forms.Label();
            this.salesDisplay = new Guna.UI.WinForms.GunaDataGridView();
            this.ProductCat = new System.Windows.Forms.ComboBox();
            this.salesListDisplay = new Guna.UI.WinForms.GunaDataGridView();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BillId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesListDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.attendantNameLable);
            this.panel1.Controls.Add(this.amountLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.orderDisplay);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.datelabel);
            this.panel1.Controls.Add(this.salesDisplay);
            this.panel1.Controls.Add(this.ProductCat);
            this.panel1.Controls.Add(this.salesListDisplay);
            this.panel1.Controls.Add(this.ProductPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ProductQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ProductName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BillId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(189, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 866);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(739, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "SALES LIST";
            // 
            // attendantNameLable
            // 
            this.attendantNameLable.AutoSize = true;
            this.attendantNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendantNameLable.ForeColor = System.Drawing.Color.White;
            this.attendantNameLable.Location = new System.Drawing.Point(112, 7);
            this.attendantNameLable.Name = "attendantNameLable";
            this.attendantNameLable.Size = new System.Drawing.Size(89, 24);
            this.attendantNameLable.TabIndex = 24;
            this.attendantNameLable.Text = "Attendant";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.BackColor = System.Drawing.Color.Red;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.amountLabel.ForeColor = System.Drawing.Color.White;
            this.amountLabel.Location = new System.Drawing.Point(888, 368);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(42, 29);
            this.amountLabel.TabIndex = 23;
            this.amountLabel.Text = "Rs";
            this.amountLabel.Click += new System.EventHandler(this.amountLabel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(713, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "AMOUNT Rs";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(748, 729);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 59);
            this.button3.TabIndex = 21;
            this.button3.Text = "PRINT";
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
            this.button2.Location = new System.Drawing.Point(893, 729);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 59);
            this.button2.TabIndex = 20;
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
            this.button4.Location = new System.Drawing.Point(589, 729);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 59);
            this.button4.TabIndex = 19;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // orderDisplay
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.orderDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderDisplay.BackgroundColor = System.Drawing.Color.White;
            this.orderDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderDisplay.ColumnHeadersHeight = 30;
            this.orderDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ProdName,
            this.Price,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDisplay.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderDisplay.EnableHeadersVisualStyles = false;
            this.orderDisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderDisplay.Location = new System.Drawing.Point(480, 118);
            this.orderDisplay.Name = "orderDisplay";
            this.orderDisplay.RowHeadersVisible = false;
            this.orderDisplay.RowHeadersWidth = 51;
            this.orderDisplay.RowTemplate.Height = 24;
            this.orderDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDisplay.Size = new System.Drawing.Size(672, 229);
            this.orderDisplay.TabIndex = 18;
            this.orderDisplay.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.orderDisplay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.orderDisplay.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.orderDisplay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.orderDisplay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.orderDisplay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.orderDisplay.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.orderDisplay.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderDisplay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.orderDisplay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderDisplay.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.orderDisplay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.orderDisplay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderDisplay.ThemeStyle.HeaderStyle.Height = 30;
            this.orderDisplay.ThemeStyle.ReadOnly = false;
            this.orderDisplay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.orderDisplay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderDisplay.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.orderDisplay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.orderDisplay.ThemeStyle.RowsStyle.Height = 24;
            this.orderDisplay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderDisplay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id
            // 
            this.id.HeaderText = "ProductId";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "ProductName";
            this.ProdName.MinimumWidth = 6;
            this.ProdName.Name = "ProdName";
            // 
            // Price
            // 
            this.Price.HeaderText = "ProductPrice";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "ProductQty";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(85, 323);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(223, 59);
            this.button5.TabIndex = 17;
            this.button5.Text = "Add Product";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(240, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // salesDisplay
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.salesDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.salesDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesDisplay.BackgroundColor = System.Drawing.Color.White;
            this.salesDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.salesDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.salesDisplay.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesDisplay.DefaultCellStyle = dataGridViewCellStyle6;
            this.salesDisplay.EnableHeadersVisualStyles = false;
            this.salesDisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.salesDisplay.Location = new System.Drawing.Point(23, 440);
            this.salesDisplay.Name = "salesDisplay";
            this.salesDisplay.RowHeadersVisible = false;
            this.salesDisplay.RowHeadersWidth = 51;
            this.salesDisplay.RowTemplate.Height = 28;
            this.salesDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesDisplay.Size = new System.Drawing.Size(364, 348);
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
            this.salesDisplay.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.salesDisplay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.salesDisplay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.salesDisplay.ThemeStyle.HeaderStyle.Height = 30;
            this.salesDisplay.ThemeStyle.ReadOnly = false;
            this.salesDisplay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.salesDisplay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.salesDisplay.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.salesDisplay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salesDisplay.ThemeStyle.RowsStyle.Height = 28;
            this.salesDisplay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.salesDisplay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.salesDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesDisplay_CellContentClick);
            // 
            // ProductCat
            // 
            this.ProductCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCat.ForeColor = System.Drawing.Color.Red;
            this.ProductCat.FormattingEnabled = true;
            this.ProductCat.Location = new System.Drawing.Point(23, 401);
            this.ProductCat.Name = "ProductCat";
            this.ProductCat.Size = new System.Drawing.Size(211, 33);
            this.ProductCat.TabIndex = 13;
            this.ProductCat.Text = "select category";
            this.ProductCat.SelectedIndexChanged += new System.EventHandler(this.ProductCat_SelectedIndexChanged);
            this.ProductCat.SelectionChangeCommitted += new System.EventHandler(this.ProductCat_SelectionChangeCommitted);
            // 
            // salesListDisplay
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.salesListDisplay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.salesListDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salesListDisplay.BackgroundColor = System.Drawing.Color.White;
            this.salesListDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesListDisplay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.salesListDisplay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesListDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.salesListDisplay.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.salesListDisplay.DefaultCellStyle = dataGridViewCellStyle9;
            this.salesListDisplay.EnableHeadersVisualStyles = false;
            this.salesListDisplay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.salesListDisplay.Location = new System.Drawing.Point(480, 465);
            this.salesListDisplay.Name = "salesListDisplay";
            this.salesListDisplay.RowHeadersVisible = false;
            this.salesListDisplay.RowHeadersWidth = 51;
            this.salesListDisplay.RowTemplate.Height = 24;
            this.salesListDisplay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesListDisplay.Size = new System.Drawing.Size(672, 229);
            this.salesListDisplay.TabIndex = 12;
            this.salesListDisplay.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.salesListDisplay.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.salesListDisplay.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.salesListDisplay.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.salesListDisplay.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.salesListDisplay.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.salesListDisplay.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.salesListDisplay.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.salesListDisplay.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.salesListDisplay.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.salesListDisplay.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.salesListDisplay.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.salesListDisplay.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.salesListDisplay.ThemeStyle.HeaderStyle.Height = 30;
            this.salesListDisplay.ThemeStyle.ReadOnly = false;
            this.salesListDisplay.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.salesListDisplay.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.salesListDisplay.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.salesListDisplay.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salesListDisplay.ThemeStyle.RowsStyle.Height = 24;
            this.salesListDisplay.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.salesListDisplay.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.salesListDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesListDisplay_CellContentClick);
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
            // BillId
            // 
            this.BillId.BackColor = System.Drawing.Color.White;
            this.BillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BillId.ForeColor = System.Drawing.Color.Black;
            this.BillId.Location = new System.Drawing.Point(176, 118);
            this.BillId.Name = "BillId";
            this.BillId.Size = new System.Drawing.Size(211, 26);
            this.BillId.TabIndex = 3;
            this.BillId.TextChanged += new System.EventHandler(this.ProductId_TextChanged);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(593, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALES";
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
            this.label8.Location = new System.Drawing.Point(36, 801);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "Log Out";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 843);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesListDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView salesDisplay;
        private System.Windows.Forms.ComboBox ProductCat;
        private Guna.UI.WinForms.GunaDataGridView salesListDisplay;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BillId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private Guna.UI.WinForms.GunaDataGridView orderDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label attendantNameLable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label8;
    }
}