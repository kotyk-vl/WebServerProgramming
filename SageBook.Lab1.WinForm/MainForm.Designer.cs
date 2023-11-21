namespace SageBook.Lab1.WinForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTabs = new System.Windows.Forms.Panel();
            this.tabs = new System.Windows.Forms.TableLayoutPanel();
            this.btnSages = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.panelMainBody = new System.Windows.Forms.Panel();
            this.pnlControlBody = new System.Windows.Forms.Panel();
            this.panelTabs.SuspendLayout();
            this.tabs.SuspendLayout();
            this.panelMainBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTabs
            // 
            this.panelTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.panelTabs.Controls.Add(this.tabs);
            this.panelTabs.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTabs.Location = new System.Drawing.Point(0, 0);
            this.panelTabs.Margin = new System.Windows.Forms.Padding(0);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(138, 450);
            this.panelTabs.TabIndex = 0;
            // 
            // tabs
            // 
            this.tabs.BackColor = System.Drawing.Color.Transparent;
            this.tabs.ColumnCount = 1;
            this.tabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabs.Controls.Add(this.btnSages, 0, 1);
            this.tabs.Controls.Add(this.btnBooks, 0, 0);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(0);
            this.tabs.Name = "tabs";
            this.tabs.RowCount = 2;
            this.tabs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabs.Size = new System.Drawing.Size(138, 80);
            this.tabs.TabIndex = 0;
            // 
            // btnSages
            // 
            this.btnSages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSages.Location = new System.Drawing.Point(0, 40);
            this.btnSages.Margin = new System.Windows.Forms.Padding(0);
            this.btnSages.Name = "btnSages";
            this.btnSages.Size = new System.Drawing.Size(149, 40);
            this.btnSages.TabIndex = 1;
            this.btnSages.Text = "Sages";
            this.btnSages.UseVisualStyleBackColor = true;
            this.btnSages.Click += new System.EventHandler(this.btn_sages_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBooks.Location = new System.Drawing.Point(0, 0);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(0);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(149, 40);
            this.btnBooks.TabIndex = 0;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btn_books_Click);
            // 
            // panelMainBody
            // 
            this.panelMainBody.BackColor = System.Drawing.Color.White;
            this.panelMainBody.Controls.Add(this.pnlControlBody);
            this.panelMainBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainBody.Location = new System.Drawing.Point(138, 0);
            this.panelMainBody.Name = "panelMainBody";
            this.panelMainBody.Size = new System.Drawing.Size(703, 450);
            this.panelMainBody.TabIndex = 2;
            // 
            // pnlControlBody
            // 
            this.pnlControlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlControlBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnlControlBody.Name = "pnlControlBody";
            this.pnlControlBody.Size = new System.Drawing.Size(703, 450);
            this.pnlControlBody.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.panelMainBody);
            this.Controls.Add(this.panelTabs);
            this.Name = "MainForm";
            this.Text = "SageBookORM";
            this.panelTabs.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.panelMainBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTabs;
        private TableLayoutPanel tabs;
        private Button btnSages;
        private Button btnBooks;
        private Panel panelMainBody;
        private Panel pnlControlBody;
    }
}