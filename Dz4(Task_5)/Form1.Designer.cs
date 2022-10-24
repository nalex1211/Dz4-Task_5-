namespace Dz4_Task_5_
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
            if (disposing && (components != null)) {
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
            this.listOfGoods = new System.Windows.Forms.DataGridView();
            this.ClmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listOfProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listOfGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfGoods
            // 
            this.listOfGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmName,
            this.ClmPrice,
            this.ClmDescription,
            this.ClmDate,
            this.ClmCountry,
            this.Column1,
            this.Column2,
            this.Column3});
            this.listOfGoods.Location = new System.Drawing.Point(12, 12);
            this.listOfGoods.Name = "listOfGoods";
            this.listOfGoods.Size = new System.Drawing.Size(843, 573);
            this.listOfGoods.TabIndex = 0;
            // 
            // ClmName
            // 
            this.ClmName.HeaderText = "Name";
            this.ClmName.Name = "ClmName";
            // 
            // ClmPrice
            // 
            this.ClmPrice.HeaderText = "Price";
            this.ClmPrice.Name = "ClmPrice";
            // 
            // ClmDescription
            // 
            this.ClmDescription.HeaderText = "Description";
            this.ClmDescription.Name = "ClmDescription";
            // 
            // ClmDate
            // 
            this.ClmDate.HeaderText = "Date of Delivery";
            this.ClmDate.Name = "ClmDate";
            // 
            // ClmCountry
            // 
            this.ClmCountry.HeaderText = "Country";
            this.ClmCountry.Name = "ClmCountry";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBook.Location = new System.Drawing.Point(861, 12);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(189, 43);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(861, 640);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add grocery";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(861, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Amount of pages";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Author";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Publishing house";
            this.Column3.Name = "Column3";
            // 
            // listOfProducts
            // 
            this.listOfProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column4,
            this.Column5,
            this.Column6});
            this.listOfProducts.Location = new System.Drawing.Point(12, 640);
            this.listOfProducts.Name = "listOfProducts";
            this.listOfProducts.Size = new System.Drawing.Size(843, 573);
            this.listOfProducts.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Date of Delivery";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Country";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Expiration date";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Unit";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Amount";
            this.Column6.Name = "Column6";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(861, 689);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 1229);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listOfProducts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.listOfGoods);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listOfGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listOfGoods;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCountry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView listOfProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button3;
    }
}

