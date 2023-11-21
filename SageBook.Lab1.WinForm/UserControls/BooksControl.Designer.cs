namespace SageBook.Lab1.WinForm.UserControls
{
    partial class BooksControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksControl));
            this.pnlBooksControls = new System.Windows.Forms.Panel();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.pnlBooksTop = new System.Windows.Forms.Panel();
            this.lblBooksHeader = new System.Windows.Forms.Label();
            this.pnlBooksBody = new System.Windows.Forms.Panel();
            this.grbSages = new System.Windows.Forms.GroupBox();
            this.lstSages = new System.Windows.Forms.ListBox();
            this.cmbSages = new System.Windows.Forms.ComboBox();
            this.btnAddSage = new System.Windows.Forms.Button();
            this.btnRemoveSage = new System.Windows.Forms.Button();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.lblBookDescription = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookDescription = new System.Windows.Forms.TextBox();
            this.txtBookSearch = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.datBooks = new System.Windows.Forms.DataGridView();
            this.pnlBooksControls.SuspendLayout();
            this.pnlBooksTop.SuspendLayout();
            this.pnlBooksBody.SuspendLayout();
            this.grbSages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBooksControls
            // 
            this.pnlBooksControls.Controls.Add(this.btnUpdateBook);
            this.pnlBooksControls.Controls.Add(this.btnBookDelete);
            this.pnlBooksControls.Controls.Add(this.btnAddBook);
            this.pnlBooksControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBooksControls.Location = new System.Drawing.Point(0, 424);
            this.pnlBooksControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBooksControls.Name = "pnlBooksControls";
            this.pnlBooksControls.Size = new System.Drawing.Size(691, 38);
            this.pnlBooksControls.TabIndex = 0;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.AutoSize = true;
            this.btnUpdateBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(172)))), ((int)(((byte)(78)))));
            this.btnUpdateBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateBook.FlatAppearance.BorderSize = 2;
            this.btnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateBook.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBook.Location = new System.Drawing.Point(160, 0);
            this.btnUpdateBook.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(339, 38);
            this.btnUpdateBook.TabIndex = 2;
            this.btnUpdateBook.Text = "UPDATE";
            this.btnUpdateBook.UseVisualStyleBackColor = false;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.AutoSize = true;
            this.btnBookDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
            this.btnBookDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBookDelete.FlatAppearance.BorderSize = 2;
            this.btnBookDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBookDelete.ForeColor = System.Drawing.Color.White;
            this.btnBookDelete.Location = new System.Drawing.Point(499, 0);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(192, 38);
            this.btnBookDelete.TabIndex = 3;
            this.btnBookDelete.Text = "DELETE";
            this.btnBookDelete.UseVisualStyleBackColor = false;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.AutoSize = true;
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(185)))), ((int)(((byte)(91)))));
            this.btnAddBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddBook.FlatAppearance.BorderSize = 2;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(0, 0);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(160, 38);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "INSERT";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // pnlBooksTop
            // 
            this.pnlBooksTop.BackColor = System.Drawing.Color.IndianRed;
            this.pnlBooksTop.Controls.Add(this.lblBooksHeader);
            this.pnlBooksTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBooksTop.ForeColor = System.Drawing.Color.White;
            this.pnlBooksTop.Location = new System.Drawing.Point(0, 0);
            this.pnlBooksTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBooksTop.Name = "pnlBooksTop";
            this.pnlBooksTop.Size = new System.Drawing.Size(691, 25);
            this.pnlBooksTop.TabIndex = 1;
            // 
            // lblBooksHeader
            // 
            this.lblBooksHeader.AutoSize = true;
            this.lblBooksHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBooksHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBooksHeader.Location = new System.Drawing.Point(0, 0);
            this.lblBooksHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblBooksHeader.Name = "lblBooksHeader";
            this.lblBooksHeader.Size = new System.Drawing.Size(90, 21);
            this.lblBooksHeader.TabIndex = 0;
            this.lblBooksHeader.Text = "Books List:";
            // 
            // pnlBooksBody
            // 
            this.pnlBooksBody.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlBooksBody.Controls.Add(this.grbSages);
            this.pnlBooksBody.Controls.Add(this.btnBookSearch);
            this.pnlBooksBody.Controls.Add(this.lblBookDescription);
            this.pnlBooksBody.Controls.Add(this.lblBookName);
            this.pnlBooksBody.Controls.Add(this.txtBookDescription);
            this.pnlBooksBody.Controls.Add(this.txtBookSearch);
            this.pnlBooksBody.Controls.Add(this.txtBookName);
            this.pnlBooksBody.Controls.Add(this.datBooks);
            this.pnlBooksBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBooksBody.Location = new System.Drawing.Point(0, 25);
            this.pnlBooksBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBooksBody.Name = "pnlBooksBody";
            this.pnlBooksBody.Size = new System.Drawing.Size(691, 399);
            this.pnlBooksBody.TabIndex = 1;
            // 
            // grbSages
            // 
            this.grbSages.Controls.Add(this.lstSages);
            this.grbSages.Controls.Add(this.cmbSages);
            this.grbSages.Controls.Add(this.btnAddSage);
            this.grbSages.Controls.Add(this.btnRemoveSage);
            this.grbSages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbSages.Location = new System.Drawing.Point(13, 79);
            this.grbSages.Name = "grbSages";
            this.grbSages.Size = new System.Drawing.Size(277, 202);
            this.grbSages.TabIndex = 9;
            this.grbSages.TabStop = false;
            this.grbSages.Text = "Sages";
            // 
            // lstSages
            // 
            this.lstSages.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstSages.FormattingEnabled = true;
            this.lstSages.ItemHeight = 17;
            this.lstSages.Location = new System.Drawing.Point(8, 63);
            this.lstSages.Name = "lstSages";
            this.lstSages.Size = new System.Drawing.Size(136, 123);
            this.lstSages.TabIndex = 10;
            // 
            // cmbSages
            // 
            this.cmbSages.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSages.FormattingEnabled = true;
            this.cmbSages.Items.AddRange(new object[] {
            "Select Item"});
            this.cmbSages.Location = new System.Drawing.Point(8, 28);
            this.cmbSages.Name = "cmbSages";
            this.cmbSages.Size = new System.Drawing.Size(136, 28);
            this.cmbSages.TabIndex = 8;
            // 
            // btnAddSage
            // 
            this.btnAddSage.AutoSize = true;
            this.btnAddSage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(185)))), ((int)(((byte)(91)))));
            this.btnAddSage.FlatAppearance.BorderSize = 0;
            this.btnAddSage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSage.Font = new System.Drawing.Font("Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSage.ForeColor = System.Drawing.Color.White;
            this.btnAddSage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSage.Location = new System.Drawing.Point(158, 28);
            this.btnAddSage.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAddSage.Name = "btnAddSage";
            this.btnAddSage.Size = new System.Drawing.Size(28, 29);
            this.btnAddSage.TabIndex = 7;
            this.btnAddSage.Text = "+";
            this.btnAddSage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSage.UseVisualStyleBackColor = false;
            this.btnAddSage.Click += new System.EventHandler(this.btnAddSage_Click);
            // 
            // btnRemoveSage
            // 
            this.btnRemoveSage.AutoSize = true;
            this.btnRemoveSage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
            this.btnRemoveSage.FlatAppearance.BorderSize = 0;
            this.btnRemoveSage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSage.Font = new System.Drawing.Font("Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveSage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveSage.Location = new System.Drawing.Point(158, 63);
            this.btnRemoveSage.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnRemoveSage.Name = "btnRemoveSage";
            this.btnRemoveSage.Size = new System.Drawing.Size(28, 29);
            this.btnRemoveSage.TabIndex = 7;
            this.btnRemoveSage.Text = "-";
            this.btnRemoveSage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRemoveSage.UseVisualStyleBackColor = false;
            this.btnRemoveSage.Click += new System.EventHandler(this.btnRemoveSage_Click);
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.AutoSize = true;
            this.btnBookSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(140)))), ((int)(((byte)(231)))));
            this.btnBookSearch.FlatAppearance.BorderSize = 0;
            this.btnBookSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBookSearch.ForeColor = System.Drawing.Color.White;
            this.btnBookSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnBookSearch.Image")));
            this.btnBookSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBookSearch.Location = new System.Drawing.Point(622, 23);
            this.btnBookSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(52, 27);
            this.btnBookSearch.TabIndex = 4;
            this.btnBookSearch.UseVisualStyleBackColor = false;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // lblBookDescription
            // 
            this.lblBookDescription.AutoSize = true;
            this.lblBookDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBookDescription.Location = new System.Drawing.Point(24, 284);
            this.lblBookDescription.Name = "lblBookDescription";
            this.lblBookDescription.Size = new System.Drawing.Size(101, 20);
            this.lblBookDescription.TabIndex = 3;
            this.lblBookDescription.Text = "Description : ";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBookName.Location = new System.Drawing.Point(24, 19);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(55, 20);
            this.lblBookName.TabIndex = 3;
            this.lblBookName.Text = "Name:";
            // 
            // txtBookDescription
            // 
            this.txtBookDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBookDescription.Location = new System.Drawing.Point(24, 307);
            this.txtBookDescription.Multiline = true;
            this.txtBookDescription.Name = "txtBookDescription";
            this.txtBookDescription.Size = new System.Drawing.Size(650, 76);
            this.txtBookDescription.TabIndex = 2;
            // 
            // txtBookSearch
            // 
            this.txtBookSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBookSearch.Location = new System.Drawing.Point(313, 23);
            this.txtBookSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.Size = new System.Drawing.Size(309, 27);
            this.txtBookSearch.TabIndex = 2;
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBookName.Location = new System.Drawing.Point(24, 42);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(266, 27);
            this.txtBookName.TabIndex = 2;
            // 
            // datBooks
            // 
            this.datBooks.BackgroundColor = System.Drawing.Color.Linen;
            this.datBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datBooks.Location = new System.Drawing.Point(313, 63);
            this.datBooks.Margin = new System.Windows.Forms.Padding(0);
            this.datBooks.Name = "datBooks";
            this.datBooks.RowTemplate.Height = 25;
            this.datBooks.Size = new System.Drawing.Size(361, 239);
            this.datBooks.TabIndex = 0;
            this.datBooks.SelectionChanged += new System.EventHandler(this.datBooks_SelectionChanged);
            // 
            // BooksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pnlBooksBody);
            this.Controls.Add(this.pnlBooksTop);
            this.Controls.Add(this.pnlBooksControls);
            this.Name = "BooksControl";
            this.Size = new System.Drawing.Size(691, 462);
            this.pnlBooksControls.ResumeLayout(false);
            this.pnlBooksControls.PerformLayout();
            this.pnlBooksTop.ResumeLayout(false);
            this.pnlBooksTop.PerformLayout();
            this.pnlBooksBody.ResumeLayout(false);
            this.pnlBooksBody.PerformLayout();
            this.grbSages.ResumeLayout(false);
            this.grbSages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlBooksControls;
        private Panel pnlBooksBody;
        private Panel pnlBooksTop;
        private DataGridView datBooks;
        private Label lblBooksHeader;
        private Button btnAddBook;
        private Button btnBookDelete;
        private Button btnUpdateBook;
        private Label lblBookName;
        private TextBox txtBookName;
        private Label lblBookDescription;
        private TextBox txtBookDescription;
        private Button btnBookSearch;
        private TextBox txtBookSearch;
        private GroupBox grbSages;
        private ComboBox cmbSages;
        private ListBox lstSages;
        private Button btnAddSage;
        private Button btnRemoveSage;
    }
}
