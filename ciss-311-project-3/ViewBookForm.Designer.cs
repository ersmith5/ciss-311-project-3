namespace ciss_311_project_3
{
    partial class ViewBookForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxISBN = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblCopywriteYear = new System.Windows.Forms.Label();
            this.tbxCopywriteYear = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tbxLocation = new System.Windows.Forms.TextBox();
            this.lblCopies = new System.Windows.Forms.Label();
            this.tbxTotalCopies = new System.Windows.Forms.TextBox();
            this.lblAvailableCopies = new System.Windows.Forms.Label();
            this.tbxAvailableCopies = new System.Windows.Forms.TextBox();
            this.lbxAuthors = new System.Windows.Forms.ListBox();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(529, 45);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "View Book";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxISBN
            // 
            this.tbxISBN.Enabled = false;
            this.tbxISBN.Location = new System.Drawing.Point(164, 57);
            this.tbxISBN.Name = "tbxISBN";
            this.tbxISBN.Size = new System.Drawing.Size(377, 20);
            this.tbxISBN.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(444, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 33);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(12, 328);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(104, 33);
            this.btnCheckout.TabIndex = 17;
            this.btnCheckout.Text = "Ch&eckout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblISBN
            // 
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(12, 58);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblISBN.Size = new System.Drawing.Size(146, 19);
            this.lblISBN.TabIndex = 18;
            this.lblISBN.Text = "ISBN:";
            this.lblISBN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCopywriteYear
            // 
            this.lblCopywriteYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopywriteYear.Location = new System.Drawing.Point(12, 84);
            this.lblCopywriteYear.Name = "lblCopywriteYear";
            this.lblCopywriteYear.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCopywriteYear.Size = new System.Drawing.Size(146, 19);
            this.lblCopywriteYear.TabIndex = 20;
            this.lblCopywriteYear.Text = "Copywrite Year:";
            this.lblCopywriteYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxCopywriteYear
            // 
            this.tbxCopywriteYear.Enabled = false;
            this.tbxCopywriteYear.Location = new System.Drawing.Point(164, 83);
            this.tbxCopywriteYear.Name = "tbxCopywriteYear";
            this.tbxCopywriteYear.Size = new System.Drawing.Size(377, 20);
            this.tbxCopywriteYear.TabIndex = 19;
            // 
            // lblLocation
            // 
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(12, 110);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLocation.Size = new System.Drawing.Size(146, 19);
            this.lblLocation.TabIndex = 22;
            this.lblLocation.Text = "Location:";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxLocation
            // 
            this.tbxLocation.Enabled = false;
            this.tbxLocation.Location = new System.Drawing.Point(164, 109);
            this.tbxLocation.Name = "tbxLocation";
            this.tbxLocation.Size = new System.Drawing.Size(377, 20);
            this.tbxLocation.TabIndex = 21;
            // 
            // lblCopies
            // 
            this.lblCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopies.Location = new System.Drawing.Point(12, 136);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCopies.Size = new System.Drawing.Size(146, 19);
            this.lblCopies.TabIndex = 24;
            this.lblCopies.Text = "Total Copies:";
            this.lblCopies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxTotalCopies
            // 
            this.tbxTotalCopies.Enabled = false;
            this.tbxTotalCopies.Location = new System.Drawing.Point(164, 135);
            this.tbxTotalCopies.Name = "tbxTotalCopies";
            this.tbxTotalCopies.Size = new System.Drawing.Size(110, 20);
            this.tbxTotalCopies.TabIndex = 23;
            // 
            // lblAvailableCopies
            // 
            this.lblAvailableCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCopies.Location = new System.Drawing.Point(280, 136);
            this.lblAvailableCopies.Name = "lblAvailableCopies";
            this.lblAvailableCopies.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAvailableCopies.Size = new System.Drawing.Size(145, 19);
            this.lblAvailableCopies.TabIndex = 26;
            this.lblAvailableCopies.Text = "Available:";
            this.lblAvailableCopies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxAvailableCopies
            // 
            this.tbxAvailableCopies.Enabled = false;
            this.tbxAvailableCopies.Location = new System.Drawing.Point(431, 135);
            this.tbxAvailableCopies.Name = "tbxAvailableCopies";
            this.tbxAvailableCopies.Size = new System.Drawing.Size(110, 20);
            this.tbxAvailableCopies.TabIndex = 25;
            // 
            // lbxAuthors
            // 
            this.lbxAuthors.Enabled = false;
            this.lbxAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxAuthors.FormattingEnabled = true;
            this.lbxAuthors.ItemHeight = 16;
            this.lbxAuthors.Location = new System.Drawing.Point(164, 161);
            this.lbxAuthors.Name = "lbxAuthors";
            this.lbxAuthors.Size = new System.Drawing.Size(377, 164);
            this.lbxAuthors.TabIndex = 27;
            // 
            // lblAuthors
            // 
            this.lblAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthors.Location = new System.Drawing.Point(12, 161);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAuthors.Size = new System.Drawing.Size(146, 19);
            this.lblAuthors.TabIndex = 28;
            this.lblAuthors.Text = "Total Copies:";
            this.lblAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ViewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 373);
            this.Controls.Add(this.lblAuthors);
            this.Controls.Add(this.lbxAuthors);
            this.Controls.Add(this.lblAvailableCopies);
            this.Controls.Add(this.tbxAvailableCopies);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.tbxTotalCopies);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.tbxLocation);
            this.Controls.Add(this.lblCopywriteYear);
            this.Controls.Add(this.tbxCopywriteYear);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbxISBN);
            this.Controls.Add(this.lblTitle);
            this.Name = "ViewBookForm";
            this.Text = "View Book";
            this.Load += new System.EventHandler(this.ViewBookFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxISBN;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblCopywriteYear;
        private System.Windows.Forms.TextBox tbxCopywriteYear;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox tbxLocation;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.TextBox tbxTotalCopies;
        private System.Windows.Forms.Label lblAvailableCopies;
        private System.Windows.Forms.TextBox tbxAvailableCopies;
        private System.Windows.Forms.ListBox lbxAuthors;
        private System.Windows.Forms.Label lblAuthors;
    }
}