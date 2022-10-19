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
            ((System.ComponentModel.ISupportInitialize)(this.listOfGoods)).BeginInit();
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
            this.ClmCountry});
            this.listOfGoods.Location = new System.Drawing.Point(12, 12);
            this.listOfGoods.Name = "listOfGoods";
            this.listOfGoods.Size = new System.Drawing.Size(535, 573);
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
            this.btnAddBook.Location = new System.Drawing.Point(12, 591);
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
            this.button2.Location = new System.Drawing.Point(207, 591);
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
            this.button1.Location = new System.Drawing.Point(402, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 705);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.listOfGoods);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.listOfGoods)).EndInit();
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
    }
}

