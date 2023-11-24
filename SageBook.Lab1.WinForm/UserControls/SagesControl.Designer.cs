namespace SageBook.Lab1.WinForm.UserControls
{
    partial class SagesControl
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
            this.pnlSageControls = new System.Windows.Forms.Panel();
            this.btnUpdateSage = new System.Windows.Forms.Button();
            this.btnSageDelete = new System.Windows.Forms.Button();
            this.btnAddSage = new System.Windows.Forms.Button();
            this.pnlSagesTop = new System.Windows.Forms.Panel();
            this.lblSagesHeader = new System.Windows.Forms.Label();
            this.pnlSagesBody = new System.Windows.Forms.Panel();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.numSageAge = new System.Windows.Forms.NumericUpDown();
            this.lblSageAge = new System.Windows.Forms.Label();
            this.lblSageCity = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblSageName = new System.Windows.Forms.Label();
            this.txtSageCity = new System.Windows.Forms.TextBox();
            this.txtSageName = new System.Windows.Forms.TextBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.datSages = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pnlSageControls.SuspendLayout();
            this.pnlSagesTop.SuspendLayout();
            this.pnlSagesBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSageAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSages)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSageControls
            // 
            this.pnlSageControls.Controls.Add(this.btnUpdateSage);
            this.pnlSageControls.Controls.Add(this.btnSageDelete);
            this.pnlSageControls.Controls.Add(this.btnAddSage);
            this.pnlSageControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSageControls.Location = new System.Drawing.Point(0, 424);
            this.pnlSageControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSageControls.Name = "pnlSageControls";
            this.pnlSageControls.Size = new System.Drawing.Size(691, 38);
            this.pnlSageControls.TabIndex = 0;
            // 
            // btnUpdateSage
            // 
            this.btnUpdateSage.AutoSize = true;
            this.btnUpdateSage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(172)))), ((int)(((byte)(78)))));
            this.btnUpdateSage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateSage.FlatAppearance.BorderSize = 2;
            this.btnUpdateSage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateSage.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSage.Location = new System.Drawing.Point(160, 0);
            this.btnUpdateSage.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdateSage.Name = "btnUpdateSage";
            this.btnUpdateSage.Size = new System.Drawing.Size(339, 38);
            this.btnUpdateSage.TabIndex = 2;
            this.btnUpdateSage.Text = "Update Sage";
            this.btnUpdateSage.UseVisualStyleBackColor = false;
            this.btnUpdateSage.Click += new System.EventHandler(this.btnUpdateSage_Click);
            // 
            // btnSageDelete
            // 
            this.btnSageDelete.AutoSize = true;
            this.btnSageDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(81)))), ((int)(((byte)(75)))));
            this.btnSageDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSageDelete.FlatAppearance.BorderSize = 2;
            this.btnSageDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSageDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSageDelete.ForeColor = System.Drawing.Color.White;
            this.btnSageDelete.Location = new System.Drawing.Point(499, 0);
            this.btnSageDelete.Name = "btnSageDelete";
            this.btnSageDelete.Size = new System.Drawing.Size(192, 38);
            this.btnSageDelete.TabIndex = 3;
            this.btnSageDelete.Text = "Remove Sage";
            this.btnSageDelete.UseVisualStyleBackColor = false;
            this.btnSageDelete.Click += new System.EventHandler(this.btnSageDelete_Click);
            // 
            // btnAddSage
            // 
            this.btnAddSage.AutoSize = true;
            this.btnAddSage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(185)))), ((int)(((byte)(91)))));
            this.btnAddSage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddSage.FlatAppearance.BorderSize = 2;
            this.btnAddSage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddSage.ForeColor = System.Drawing.Color.White;
            this.btnAddSage.Location = new System.Drawing.Point(0, 0);
            this.btnAddSage.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAddSage.Name = "btnAddSage";
            this.btnAddSage.Size = new System.Drawing.Size(160, 38);
            this.btnAddSage.TabIndex = 1;
            this.btnAddSage.Text = "Add New Sage";
            this.btnAddSage.UseVisualStyleBackColor = false;
            this.btnAddSage.Click += new System.EventHandler(this.btnAddSage_Click);
            // 
            // pnlSagesTop
            // 
            this.pnlSagesTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(172)))), ((int)(((byte)(78)))));
            this.pnlSagesTop.Controls.Add(this.lblSagesHeader);
            this.pnlSagesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSagesTop.ForeColor = System.Drawing.Color.White;
            this.pnlSagesTop.Location = new System.Drawing.Point(0, 0);
            this.pnlSagesTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSagesTop.Name = "pnlSagesTop";
            this.pnlSagesTop.Size = new System.Drawing.Size(691, 41);
            this.pnlSagesTop.TabIndex = 1;
            // 
            // lblSagesHeader
            // 
            this.lblSagesHeader.AutoSize = true;
            this.lblSagesHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSagesHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSagesHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(52)))), ((int)(((byte)(38)))));
            this.lblSagesHeader.Location = new System.Drawing.Point(0, 0);
            this.lblSagesHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblSagesHeader.Name = "lblSagesHeader";
            this.lblSagesHeader.Size = new System.Drawing.Size(132, 32);
            this.lblSagesHeader.TabIndex = 0;
            this.lblSagesHeader.Text = "Sages List:";
            // 
            // pnlSagesBody
            // 
            this.pnlSagesBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(118)))));
            this.pnlSagesBody.Controls.Add(this.lstBooks);
            this.pnlSagesBody.Controls.Add(this.numSageAge);
            this.pnlSagesBody.Controls.Add(this.lblSageAge);
            this.pnlSagesBody.Controls.Add(this.lblSageCity);
            this.pnlSagesBody.Controls.Add(this.lblBooks);
            this.pnlSagesBody.Controls.Add(this.lblSageName);
            this.pnlSagesBody.Controls.Add(this.txtSageCity);
            this.pnlSagesBody.Controls.Add(this.txtSageName);
            this.pnlSagesBody.Controls.Add(this.pbPhoto);
            this.pnlSagesBody.Controls.Add(this.datSages);
            this.pnlSagesBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSagesBody.Location = new System.Drawing.Point(0, 41);
            this.pnlSagesBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSagesBody.Name = "pnlSagesBody";
            this.pnlSagesBody.Size = new System.Drawing.Size(691, 383);
            this.pnlSagesBody.TabIndex = 1;
            // 
            // lstBooks
            // 
            this.lstBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(237)))), ((int)(((byte)(212)))));
            this.lstBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(13)))), ((int)(((byte)(122)))));
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 21;
            this.lstBooks.Location = new System.Drawing.Point(293, 216);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(362, 109);
            this.lstBooks.TabIndex = 11;
            // 
            // numSageAge
            // 
            this.numSageAge.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numSageAge.Location = new System.Drawing.Point(499, 131);
            this.numSageAge.Name = "numSageAge";
            this.numSageAge.Size = new System.Drawing.Size(156, 27);
            this.numSageAge.TabIndex = 7;
            // 
            // lblSageAge
            // 
            this.lblSageAge.AutoSize = true;
            this.lblSageAge.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSageAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(237)))), ((int)(((byte)(212)))));
            this.lblSageAge.Location = new System.Drawing.Point(431, 133);
            this.lblSageAge.Name = "lblSageAge";
            this.lblSageAge.Size = new System.Drawing.Size(41, 20);
            this.lblSageAge.TabIndex = 6;
            this.lblSageAge.Text = "Age:";
            // 
            // lblSageCity
            // 
            this.lblSageCity.AutoSize = true;
            this.lblSageCity.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSageCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(237)))), ((int)(((byte)(212)))));
            this.lblSageCity.Location = new System.Drawing.Point(431, 76);
            this.lblSageCity.Name = "lblSageCity";
            this.lblSageCity.Size = new System.Drawing.Size(40, 20);
            this.lblSageCity.TabIndex = 6;
            this.lblSageCity.Text = "City:";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(237)))), ((int)(((byte)(212)))));
            this.lblBooks.Location = new System.Drawing.Point(293, 193);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(59, 20);
            this.lblBooks.TabIndex = 5;
            this.lblBooks.Text = "BOOKS";
            // 
            // lblSageName
            // 
            this.lblSageName.AutoSize = true;
            this.lblSageName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(237)))), ((int)(((byte)(212)))));
            this.lblSageName.Location = new System.Drawing.Point(431, 21);
            this.lblSageName.Name = "lblSageName";
            this.lblSageName.Size = new System.Drawing.Size(55, 20);
            this.lblSageName.TabIndex = 5;
            this.lblSageName.Text = "Name:";
            // 
            // txtSageCity
            // 
            this.txtSageCity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSageCity.Location = new System.Drawing.Point(499, 76);
            this.txtSageCity.Margin = new System.Windows.Forms.Padding(0);
            this.txtSageCity.Name = "txtSageCity";
            this.txtSageCity.Size = new System.Drawing.Size(156, 27);
            this.txtSageCity.TabIndex = 3;
            // 
            // txtSageName
            // 
            this.txtSageName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSageName.Location = new System.Drawing.Point(499, 21);
            this.txtSageName.Margin = new System.Windows.Forms.Padding(0);
            this.txtSageName.Name = "txtSageName";
            this.txtSageName.Size = new System.Drawing.Size(156, 27);
            this.txtSageName.TabIndex = 3;
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(237)))), ((int)(((byte)(212)))));
            this.pbPhoto.Location = new System.Drawing.Point(293, 21);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(123, 142);
            this.pbPhoto.TabIndex = 1;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
            // 
            // datSages
            // 
            this.datSages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(237)))), ((int)(((byte)(212)))));
            this.datSages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datSages.Location = new System.Drawing.Point(0, 0);
            this.datSages.Margin = new System.Windows.Forms.Padding(0);
            this.datSages.Name = "datSages";
            this.datSages.RowTemplate.Height = 25;
            this.datSages.Size = new System.Drawing.Size(271, 383);
            this.datSages.TabIndex = 0;
            this.datSages.SelectionChanged += new System.EventHandler(this.datSages_SelectionChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // SagesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pnlSagesBody);
            this.Controls.Add(this.pnlSagesTop);
            this.Controls.Add(this.pnlSageControls);
            this.Name = "SagesControl";
            this.Size = new System.Drawing.Size(691, 462);
            this.VisibleChanged += new System.EventHandler(this.SagesControl_VisibleChanged);
            this.pnlSageControls.ResumeLayout(false);
            this.pnlSageControls.PerformLayout();
            this.pnlSagesTop.ResumeLayout(false);
            this.pnlSagesTop.PerformLayout();
            this.pnlSagesBody.ResumeLayout(false);
            this.pnlSagesBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSageAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datSages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlSageControls;
        private Panel pnlSagesBody;
        private Panel pnlSagesTop;
        private DataGridView datSages;
        private Label lblSagesHeader;
        private Button btnAddSage;
        private Button btnSageDelete;
        private Button btnUpdateSage;
        private PictureBox pbPhoto;
        private TextBox txtSageCity;
        private TextBox txtSageName;
        private Label lblSageName;
        private NumericUpDown numSageAge;
        private Label lblSageAge;
        private Label lblSageCity;
        private Label lblBooks;
        private ListBox lstBooks;
        private OpenFileDialog openFileDialog;
    }
}
