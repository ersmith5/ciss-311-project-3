namespace ciss_311_project_3
{
    partial class MainForm
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
            this.gbxUser = new System.Windows.Forms.GroupBox();
            this.gbxLibrarian = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddBorrower = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.gbxAdministrator = new System.Windows.Forms.GroupBox();
            this.btnListCheckedOutBooks = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnListOverdueBooks = new System.Windows.Forms.Button();
            this.gbxUser.SuspendLayout();
            this.gbxLibrarian.SuspendLayout();
            this.gbxAdministrator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUser
            // 
            this.gbxUser.Controls.Add(this.btnSearch);
            this.gbxUser.Location = new System.Drawing.Point(12, 76);
            this.gbxUser.Name = "gbxUser";
            this.gbxUser.Size = new System.Drawing.Size(294, 180);
            this.gbxUser.TabIndex = 0;
            this.gbxUser.TabStop = false;
            this.gbxUser.Text = "User Actions";
            // 
            // gbxLibrarian
            // 
            this.gbxLibrarian.Controls.Add(this.btnAddAuthor);
            this.gbxLibrarian.Controls.Add(this.btnAddBook);
            this.gbxLibrarian.Controls.Add(this.btnAddBorrower);
            this.gbxLibrarian.Location = new System.Drawing.Point(318, 76);
            this.gbxLibrarian.Name = "gbxLibrarian";
            this.gbxLibrarian.Size = new System.Drawing.Size(294, 180);
            this.gbxLibrarian.TabIndex = 1;
            this.gbxLibrarian.TabStop = false;
            this.gbxLibrarian.Text = "Librarian Actions";
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(12, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(270, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search for Book";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(28, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(572, 45);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Tiny Library Book Management System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddBorrower
            // 
            this.btnAddBorrower.Enabled = false;
            this.btnAddBorrower.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBorrower.Location = new System.Drawing.Point(12, 20);
            this.btnAddBorrower.Name = "btnAddBorrower";
            this.btnAddBorrower.Size = new System.Drawing.Size(270, 46);
            this.btnAddBorrower.TabIndex = 0;
            this.btnAddBorrower.Text = "Add Bo&rrower";
            this.btnAddBorrower.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Enabled = false;
            this.btnAddBook.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(12, 72);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(270, 46);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Add &Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Enabled = false;
            this.btnAddAuthor.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.Location = new System.Drawing.Point(12, 124);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(270, 46);
            this.btnAddAuthor.TabIndex = 2;
            this.btnAddAuthor.Text = "Add &Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            // 
            // gbxAdministrator
            // 
            this.gbxAdministrator.Controls.Add(this.btnListOverdueBooks);
            this.gbxAdministrator.Controls.Add(this.btnListCheckedOutBooks);
            this.gbxAdministrator.Location = new System.Drawing.Point(12, 262);
            this.gbxAdministrator.Name = "gbxAdministrator";
            this.gbxAdministrator.Size = new System.Drawing.Size(294, 180);
            this.gbxAdministrator.TabIndex = 3;
            this.gbxAdministrator.TabStop = false;
            this.gbxAdministrator.Text = "Administrator Actions";
            // 
            // btnListCheckedOutBooks
            // 
            this.btnListCheckedOutBooks.Enabled = false;
            this.btnListCheckedOutBooks.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListCheckedOutBooks.Location = new System.Drawing.Point(12, 20);
            this.btnListCheckedOutBooks.Name = "btnListCheckedOutBooks";
            this.btnListCheckedOutBooks.Size = new System.Drawing.Size(270, 46);
            this.btnListCheckedOutBooks.TabIndex = 2;
            this.btnListCheckedOutBooks.Text = "List &Checked Out Books";
            this.btnListCheckedOutBooks.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(330, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(270, 46);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnListOverdueBooks
            // 
            this.btnListOverdueBooks.Enabled = false;
            this.btnListOverdueBooks.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListOverdueBooks.Location = new System.Drawing.Point(12, 72);
            this.btnListOverdueBooks.Name = "btnListOverdueBooks";
            this.btnListOverdueBooks.Size = new System.Drawing.Size(270, 46);
            this.btnListOverdueBooks.TabIndex = 3;
            this.btnListOverdueBooks.Text = "List &Overdue Books";
            this.btnListOverdueBooks.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 452);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbxAdministrator);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbxLibrarian);
            this.Controls.Add(this.gbxUser);
            this.Name = "MainForm";
            this.Text = "Tiny Library Book Management System";
            this.gbxUser.ResumeLayout(false);
            this.gbxLibrarian.ResumeLayout(false);
            this.gbxAdministrator.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUser;
        private System.Windows.Forms.GroupBox gbxLibrarian;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddBorrower;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.GroupBox gbxAdministrator;
        private System.Windows.Forms.Button btnListOverdueBooks;
        private System.Windows.Forms.Button btnListCheckedOutBooks;
        private System.Windows.Forms.Button btnExit;
    }
}

