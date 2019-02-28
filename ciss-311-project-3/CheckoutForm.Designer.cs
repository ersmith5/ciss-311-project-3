namespace ciss_311_project_3
{
    partial class CheckoutForm
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
            this.lblBorrower = new System.Windows.Forms.Label();
            this.cbxBorrower = new System.Windows.Forms.ComboBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxSummary = new System.Windows.Forms.GroupBox();
            this.tbxBookToCheckout = new System.Windows.Forms.TextBox();
            this.tbxBookCheckoutAllotment = new System.Windows.Forms.TextBox();
            this.tbxCurrentCheckedOutBooks = new System.Windows.Forms.TextBox();
            this.tbxBorrower = new System.Windows.Forms.TextBox();
            this.lblBookToCheckout = new System.Windows.Forms.Label();
            this.lblBookCheckoutAllotment = new System.Windows.Forms.Label();
            this.lblCurrentCheckedOutBooks = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(529, 45);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Checkout Book";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBorrower
            // 
            this.lblBorrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrower.Location = new System.Drawing.Point(12, 57);
            this.lblBorrower.Name = "lblBorrower";
            this.lblBorrower.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBorrower.Size = new System.Drawing.Size(146, 19);
            this.lblBorrower.TabIndex = 20;
            this.lblBorrower.Text = "Borrower:";
            this.lblBorrower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxBorrower
            // 
            this.cbxBorrower.FormattingEnabled = true;
            this.cbxBorrower.Location = new System.Drawing.Point(164, 57);
            this.cbxBorrower.Name = "cbxBorrower";
            this.cbxBorrower.Size = new System.Drawing.Size(377, 21);
            this.cbxBorrower.TabIndex = 21;
            this.cbxBorrower.SelectedIndexChanged += new System.EventHandler(this.cbxBorrower_SelectedIndexChanged);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Enabled = false;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(12, 328);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(104, 33);
            this.btnCheckout.TabIndex = 23;
            this.btnCheckout.Text = "Ch&eckout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(444, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 33);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbxSummary
            // 
            this.gbxSummary.Controls.Add(this.tbxBookToCheckout);
            this.gbxSummary.Controls.Add(this.tbxBookCheckoutAllotment);
            this.gbxSummary.Controls.Add(this.tbxCurrentCheckedOutBooks);
            this.gbxSummary.Controls.Add(this.tbxBorrower);
            this.gbxSummary.Controls.Add(this.lblBookToCheckout);
            this.gbxSummary.Controls.Add(this.lblBookCheckoutAllotment);
            this.gbxSummary.Controls.Add(this.lblCurrentCheckedOutBooks);
            this.gbxSummary.Controls.Add(this.label1);
            this.gbxSummary.Location = new System.Drawing.Point(12, 84);
            this.gbxSummary.Name = "gbxSummary";
            this.gbxSummary.Size = new System.Drawing.Size(529, 238);
            this.gbxSummary.TabIndex = 24;
            this.gbxSummary.TabStop = false;
            this.gbxSummary.Text = "Summary";
            // 
            // tbxBookToCheckout
            // 
            this.tbxBookToCheckout.Enabled = false;
            this.tbxBookToCheckout.Location = new System.Drawing.Point(230, 94);
            this.tbxBookToCheckout.Name = "tbxBookToCheckout";
            this.tbxBookToCheckout.Size = new System.Drawing.Size(293, 20);
            this.tbxBookToCheckout.TabIndex = 28;
            // 
            // tbxBookCheckoutAllotment
            // 
            this.tbxBookCheckoutAllotment.Enabled = false;
            this.tbxBookCheckoutAllotment.Location = new System.Drawing.Point(230, 68);
            this.tbxBookCheckoutAllotment.Name = "tbxBookCheckoutAllotment";
            this.tbxBookCheckoutAllotment.Size = new System.Drawing.Size(293, 20);
            this.tbxBookCheckoutAllotment.TabIndex = 27;
            // 
            // tbxCurrentCheckedOutBooks
            // 
            this.tbxCurrentCheckedOutBooks.Enabled = false;
            this.tbxCurrentCheckedOutBooks.Location = new System.Drawing.Point(230, 42);
            this.tbxCurrentCheckedOutBooks.Name = "tbxCurrentCheckedOutBooks";
            this.tbxCurrentCheckedOutBooks.Size = new System.Drawing.Size(293, 20);
            this.tbxCurrentCheckedOutBooks.TabIndex = 26;
            // 
            // tbxBorrower
            // 
            this.tbxBorrower.Enabled = false;
            this.tbxBorrower.Location = new System.Drawing.Point(230, 16);
            this.tbxBorrower.Name = "tbxBorrower";
            this.tbxBorrower.Size = new System.Drawing.Size(293, 20);
            this.tbxBorrower.TabIndex = 25;
            // 
            // lblBookToCheckout
            // 
            this.lblBookToCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookToCheckout.Location = new System.Drawing.Point(3, 94);
            this.lblBookToCheckout.Name = "lblBookToCheckout";
            this.lblBookToCheckout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBookToCheckout.Size = new System.Drawing.Size(221, 19);
            this.lblBookToCheckout.TabIndex = 24;
            this.lblBookToCheckout.Text = "Book to Checkout:";
            this.lblBookToCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBookCheckoutAllotment
            // 
            this.lblBookCheckoutAllotment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCheckoutAllotment.Location = new System.Drawing.Point(3, 68);
            this.lblBookCheckoutAllotment.Name = "lblBookCheckoutAllotment";
            this.lblBookCheckoutAllotment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBookCheckoutAllotment.Size = new System.Drawing.Size(221, 19);
            this.lblBookCheckoutAllotment.TabIndex = 23;
            this.lblBookCheckoutAllotment.Text = "Book Checkout Allotment:";
            this.lblBookCheckoutAllotment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentCheckedOutBooks
            // 
            this.lblCurrentCheckedOutBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCheckedOutBooks.Location = new System.Drawing.Point(3, 42);
            this.lblCurrentCheckedOutBooks.Name = "lblCurrentCheckedOutBooks";
            this.lblCurrentCheckedOutBooks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCurrentCheckedOutBooks.Size = new System.Drawing.Size(221, 19);
            this.lblCurrentCheckedOutBooks.TabIndex = 22;
            this.lblCurrentCheckedOutBooks.Text = "Current Checked Out Books:";
            this.lblCurrentCheckedOutBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(221, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Borrower:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 373);
            this.Controls.Add(this.gbxSummary);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbxBorrower);
            this.Controls.Add(this.lblBorrower);
            this.Controls.Add(this.lblTitle);
            this.Name = "CheckoutForm";
            this.Text = "Checkout Book";
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            this.gbxSummary.ResumeLayout(false);
            this.gbxSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBorrower;
        private System.Windows.Forms.ComboBox cbxBorrower;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxSummary;
        private System.Windows.Forms.Label lblBookToCheckout;
        private System.Windows.Forms.Label lblBookCheckoutAllotment;
        private System.Windows.Forms.Label lblCurrentCheckedOutBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxBookToCheckout;
        private System.Windows.Forms.TextBox tbxBookCheckoutAllotment;
        private System.Windows.Forms.TextBox tbxCurrentCheckedOutBooks;
        private System.Windows.Forms.TextBox tbxBorrower;
    }
}