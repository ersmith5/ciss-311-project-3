namespace ciss_311_project_3
{
    partial class SearchBookForm
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
            this.tbxSearchString = new System.Windows.Forms.TextBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.gbxSearchForBooks = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxSearchOptions = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lvwResults = new System.Windows.Forms.ListView();
            this.titleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxSearchForBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxSearchString
            // 
            this.tbxSearchString.Location = new System.Drawing.Point(253, 19);
            this.tbxSearchString.Name = "tbxSearchString";
            this.tbxSearchString.Size = new System.Drawing.Size(270, 20);
            this.tbxSearchString.TabIndex = 10;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(6, 20);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(76, 17);
            this.lblSearchBy.TabIndex = 9;
            this.lblSearchBy.Text = "Search by:";
            // 
            // gbxSearchForBooks
            // 
            this.gbxSearchForBooks.Controls.Add(this.btnSearch);
            this.gbxSearchForBooks.Controls.Add(this.cbxSearchOptions);
            this.gbxSearchForBooks.Controls.Add(this.tbxSearchString);
            this.gbxSearchForBooks.Controls.Add(this.lblSearchBy);
            this.gbxSearchForBooks.Location = new System.Drawing.Point(12, 57);
            this.gbxSearchForBooks.Name = "gbxSearchForBooks";
            this.gbxSearchForBooks.Size = new System.Drawing.Size(529, 90);
            this.gbxSearchForBooks.TabIndex = 11;
            this.gbxSearchForBooks.TabStop = false;
            this.gbxSearchForBooks.Text = "Search for Books";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(206, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 33);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxSearchOptions
            // 
            this.cbxSearchOptions.DisplayMember = "Name";
            this.cbxSearchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchOptions.FormattingEnabled = true;
            this.cbxSearchOptions.Location = new System.Drawing.Point(88, 19);
            this.cbxSearchOptions.Name = "cbxSearchOptions";
            this.cbxSearchOptions.Size = new System.Drawing.Size(159, 21);
            this.cbxSearchOptions.TabIndex = 11;
            this.cbxSearchOptions.SelectedIndexChanged += new System.EventHandler(this.cbxSearchOptions_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(150, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 45);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Search for Books";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(438, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 33);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lvwResults
            // 
            this.lvwResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleColumn});
            this.lvwResults.Enabled = false;
            this.lvwResults.GridLines = true;
            this.lvwResults.Location = new System.Drawing.Point(12, 153);
            this.lvwResults.MultiSelect = false;
            this.lvwResults.Name = "lvwResults";
            this.lvwResults.Size = new System.Drawing.Size(523, 169);
            this.lvwResults.TabIndex = 14;
            this.lvwResults.UseCompatibleStateImageBehavior = false;
            this.lvwResults.View = System.Windows.Forms.View.List;
            this.lvwResults.DoubleClick += new System.EventHandler(this.lvwResults_DoubleClick);
            // 
            // titleColumn
            // 
            this.titleColumn.Width = 523;
            // 
            // SearchBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 373);
            this.Controls.Add(this.lvwResults);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbxSearchForBooks);
            this.Name = "SearchBookForm";
            this.Text = "SearchBookForm";
            this.Load += new System.EventHandler(this.SearchBookForm_Load);
            this.gbxSearchForBooks.ResumeLayout(false);
            this.gbxSearchForBooks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxSearchString;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.GroupBox gbxSearchForBooks;
        private System.Windows.Forms.ComboBox cbxSearchOptions;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lvwResults;
        private System.Windows.Forms.ColumnHeader titleColumn;
    }
}