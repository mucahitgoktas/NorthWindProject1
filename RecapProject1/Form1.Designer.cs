
namespace RecapProject1
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
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.crxKategori = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.tbxSearchId = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearchByCategoryId = new System.Windows.Forms.TextBox();
            this.gbxCategory.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.tbxSearchId.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.crxKategori);
            this.gbxCategory.Controls.Add(this.lblKategori);
            this.gbxCategory.Location = new System.Drawing.Point(18, 20);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(705, 63);
            this.gbxCategory.TabIndex = 0;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Listele";
            this.gbxCategory.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // crxKategori
            // 
            this.crxKategori.FormattingEnabled = true;
            this.crxKategori.Location = new System.Drawing.Point(99, 19);
            this.crxKategori.Name = "crxKategori";
            this.crxKategori.Size = new System.Drawing.Size(238, 21);
            this.crxKategori.TabIndex = 2;
            this.crxKategori.SelectedIndexChanged += new System.EventHandler(this.crxKategori_SelectedIndexChanged);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(21, 22);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(46, 13);
            this.lblKategori.TabIndex = 1;
            this.lblKategori.Text = "Kategori";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Location = new System.Drawing.Point(18, 92);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(705, 48);
            this.gbxSearch.TabIndex = 1;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Ürün İsmine Göre Ara";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(98, 21);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(239, 20);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(21, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(32, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Ara : ";
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(18, 212);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(704, 105);
            this.dgwProduct.TabIndex = 2;
            this.dgwProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellContentClick);
            // 
            // tbxSearchId
            // 
            this.tbxSearchId.Controls.Add(this.tbxSearchByCategoryId);
            this.tbxSearchId.Controls.Add(this.label1);
            this.tbxSearchId.Location = new System.Drawing.Point(18, 154);
            this.tbxSearchId.Name = "tbxSearchId";
            this.tbxSearchId.Size = new System.Drawing.Size(707, 47);
            this.tbxSearchId.TabIndex = 3;
            this.tbxSearchId.TabStop = false;
            this.tbxSearchId.Text = "Ürün Numarasına Göre Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ara : ";
            // 
            // tbxSearchByCategoryId
            // 
            this.tbxSearchByCategoryId.Location = new System.Drawing.Point(99, 16);
            this.tbxSearchByCategoryId.Name = "tbxSearchByCategoryId";
            this.tbxSearchByCategoryId.Size = new System.Drawing.Size(239, 20);
            this.tbxSearchByCategoryId.TabIndex = 2;
            this.tbxSearchByCategoryId.TextChanged += new System.EventHandler(this.tbxSearchByCategoryId_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 387);
            this.Controls.Add(this.tbxSearchId);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxCategory);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.tbxSearchId.ResumeLayout(false);
            this.tbxSearchId.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox crxKategori;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox tbxSearchId;
        private System.Windows.Forms.TextBox tbxSearchByCategoryId;
        private System.Windows.Forms.Label label1;
    }
}

