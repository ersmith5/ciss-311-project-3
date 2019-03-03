namespace CheckoutHistory_Form
{
    partial class CheckoutHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutHistoryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.isbnBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.HistoryView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // isbnBox
            // 
            resources.ApplyResources(this.isbnBox, "isbnBox");
            this.isbnBox.Name = "isbnBox";
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // HistoryView
            // 
            this.HistoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.HistoryView, "HistoryView");
            this.HistoryView.Name = "HistoryView";
            this.HistoryView.RowTemplate.Height = 24;
            // 
            // CheckoutHistoryForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HistoryView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.isbnBox);
            this.Controls.Add(this.label1);
            this.Name = "CheckoutHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.HistoryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isbnBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView HistoryView;
    }
}
