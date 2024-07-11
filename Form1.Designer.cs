namespace WinFormsFakeStoreAPI
{
    partial class Form1
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
            label1 = new Label();
            lblTitle = new Label();
            lblImage = new Label();
            lblCategory = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            pictureBoxIcon = new PictureBox();
            txtDescription = new TextBox();
            txtTitle = new TextBox();
            txtPrice = new TextBox();
            txtCategory = new TextBox();
            ProductBox = new ListBox();
            lblProductsList = new Label();
            progressBar = new ProgressBar();
            lblProgressBar = new Label();
            btnLoadProducts = new Button();
            txtLink = new TextBox();
            lblLink = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(340, 25);
            label1.TabIndex = 0;
            label1.Text = "Fake Product API (Server-Side Exam)";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(15, 109);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(35, 17);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Title";
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblImage.Location = new Point(475, 172);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(44, 17);
            lblImage.TabIndex = 5;
            lblImage.Text = "Image";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblCategory.Location = new Point(14, 214);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(61, 17);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblDescription.Location = new Point(12, 272);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(76, 17);
            lblDescription.TabIndex = 7;
            lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(15, 159);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(38, 17);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(525, 146);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(107, 85);
            pictureBoxIcon.TabIndex = 9;
            pictureBoxIcon.TabStop = false;
            // 
            // txtDescription
            // 
            txtDescription.Enabled = false;
            txtDescription.Location = new Point(12, 292);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(319, 125);
            txtDescription.TabIndex = 14;
            // 
            // txtTitle
            // 
            txtTitle.Enabled = false;
            txtTitle.Location = new Point(14, 129);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(320, 23);
            txtTitle.TabIndex = 15;
            // 
            // txtPrice
            // 
            txtPrice.Enabled = false;
            txtPrice.Location = new Point(15, 179);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(155, 23);
            txtPrice.TabIndex = 16;
            // 
            // txtCategory
            // 
            txtCategory.Enabled = false;
            txtCategory.Location = new Point(12, 234);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(156, 23);
            txtCategory.TabIndex = 17;
            // 
            // ProductBox
            // 
            ProductBox.FormattingEnabled = true;
            ProductBox.ItemHeight = 15;
            ProductBox.Location = new Point(358, 425);
            ProductBox.Name = "ProductBox";
            ProductBox.Size = new Size(388, 169);
            ProductBox.TabIndex = 18;
            ProductBox.SelectedIndexChanged += listBoxProducts_SelectedIndexChanged;
            // 
            // lblProductsList
            // 
            lblProductsList.AutoSize = true;
            lblProductsList.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblProductsList.Location = new Point(358, 405);
            lblProductsList.Name = "lblProductsList";
            lblProductsList.Size = new Size(110, 17);
            lblProductsList.TabIndex = 19;
            lblProductsList.Text = "Fake Product List";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(413, 299);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(275, 23);
            progressBar.TabIndex = 20;
            // 
            // lblProgressBar
            // 
            lblProgressBar.AutoSize = true;
            lblProgressBar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgressBar.Location = new Point(525, 279);
            lblProgressBar.Name = "lblProgressBar";
            lblProgressBar.Size = new Size(64, 17);
            lblProgressBar.TabIndex = 21;
            lblProgressBar.Text = "Loading...";
            // 
            // btnLoadProducts
            // 
            btnLoadProducts.BackColor = Color.Gainsboro;
            btnLoadProducts.Cursor = Cursors.Hand;
            btnLoadProducts.FlatStyle = FlatStyle.Flat;
            btnLoadProducts.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadProducts.Location = new Point(13, 532);
            btnLoadProducts.Name = "btnLoadProducts";
            btnLoadProducts.Size = new Size(321, 45);
            btnLoadProducts.TabIndex = 22;
            btnLoadProducts.Text = "Load Products (Offline)";
            btnLoadProducts.UseVisualStyleBackColor = false;
            btnLoadProducts.Click += btnLoadProducts_Click;
            // 
            // txtLink
            // 
            txtLink.Enabled = false;
            txtLink.Location = new Point(12, 450);
            txtLink.Multiline = true;
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(321, 59);
            txtLink.TabIndex = 24;
            // 
            // lblLink
            // 
            lblLink.AutoSize = true;
            lblLink.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblLink.Location = new Point(12, 430);
            lblLink.Name = "lblLink";
            lblLink.Size = new Size(33, 17);
            lblLink.TabIndex = 23;
            lblLink.Text = "Link";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 25;
            label2.Text = "Product Details:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 606);
            Controls.Add(label2);
            Controls.Add(txtLink);
            Controls.Add(lblLink);
            Controls.Add(btnLoadProducts);
            Controls.Add(lblProgressBar);
            Controls.Add(progressBar);
            Controls.Add(lblProductsList);
            Controls.Add(ProductBox);
            Controls.Add(txtCategory);
            Controls.Add(txtPrice);
            Controls.Add(txtTitle);
            Controls.Add(txtDescription);
            Controls.Add(pictureBoxIcon);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblCategory);
            Controls.Add(lblImage);
            Controls.Add(lblTitle);
            Controls.Add(label1);
            Name = "Form1";
            Text = "FakeProductAPI Form";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitle;
        private Label lblImage;
        private Label lblCategory;
        private Label lblDescription;
        private Label lblPrice;
        private PictureBox pictureBoxIcon;
        private TextBox txtDescription;
        private TextBox txtTitle;
        private TextBox txtPrice;
        private TextBox txtCategory;
        private ListBox ProductBox;
        private Label lblProductsList;
        private ProgressBar progressBar;
        private Label lblProgressBar;
        private Button btnLoadProducts;
        private TextBox txtLink;
        private Label lblLink;
        private Label label2;
    }
}
