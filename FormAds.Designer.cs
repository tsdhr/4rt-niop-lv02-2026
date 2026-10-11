namespace AdBoard {
    partial class FormAds {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHeader;

        private System.Windows.Forms.GroupBox gbAdDetails;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblExtra1;
        private System.Windows.Forms.TextBox tbExtra1;
        private System.Windows.Forms.Label lblExtra2;
        private System.Windows.Forms.TextBox tbExtra2;
        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;

        private System.Windows.Forms.Label lblAdsHeader;
        private System.Windows.Forms.ListBox lbAds;
        private System.Windows.Forms.Label lblTotalFeeTitle;
        private System.Windows.Forms.Label lblTotalFee;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            lblHeader = new Label();
            gbAdDetails = new GroupBox();
            lblType = new Label();
            cbType = new ComboBox();
            lblTitle = new Label();
            tbTitle = new TextBox();
            lblPrice = new Label();
            tbPrice = new TextBox();
            lblExtra1 = new Label();
            tbExtra1 = new TextBox();
            lblExtra2 = new Label();
            tbExtra2 = new TextBox();
            btnAdd = new Button();
            gbSearch = new GroupBox();
            lblSearch = new Label();
            tbSearch = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            lblAdsHeader = new Label();
            lbAds = new ListBox();
            lblTotalFeeTitle = new Label();
            lblTotalFee = new Label();
            gbAdDetails.SuspendLayout();
            gbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeader.ForeColor = Color.FromArgb(35, 65, 105);
            lblHeader.Location = new Point(23, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(1097, 51);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "OGLASNIK - POLIMORFIZAM";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gbAdDetails
            // 
            gbAdDetails.Controls.Add(lblType);
            gbAdDetails.Controls.Add(cbType);
            gbAdDetails.Controls.Add(lblTitle);
            gbAdDetails.Controls.Add(tbTitle);
            gbAdDetails.Controls.Add(lblPrice);
            gbAdDetails.Controls.Add(tbPrice);
            gbAdDetails.Controls.Add(lblExtra1);
            gbAdDetails.Controls.Add(tbExtra1);
            gbAdDetails.Controls.Add(lblExtra2);
            gbAdDetails.Controls.Add(tbExtra2);
            gbAdDetails.Controls.Add(btnAdd);
            gbAdDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbAdDetails.ForeColor = Color.FromArgb(35, 65, 105);
            gbAdDetails.Location = new Point(23, 93);
            gbAdDetails.Margin = new Padding(3, 4, 3, 4);
            gbAdDetails.Name = "gbAdDetails";
            gbAdDetails.Padding = new Padding(3, 4, 3, 4);
            gbAdDetails.Size = new Size(1097, 300);
            gbAdDetails.TabIndex = 1;
            gbAdDetails.TabStop = false;
            gbAdDetails.Text = "Podaci o oglasu";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(23, 47);
            lblType.Name = "lblType";
            lblType.Size = new Size(98, 20);
            lblType.TabIndex = 0;
            lblType.Text = "Vrsta oglasa:";
            // 
            // cbType
            // 
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Vozilo", "Nekretnina", "Usluga" });
            cbType.Location = new Point(154, 41);
            cbType.Margin = new Padding(3, 4, 3, 4);
            cbType.Name = "cbType";
            cbType.Size = new Size(285, 28);
            cbType.TabIndex = 1;
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(23, 100);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(110, 20);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Naslov oglasa:";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(154, 95);
            tbTitle.Margin = new Padding(3, 4, 3, 4);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(399, 27);
            tbTitle.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(594, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(80, 20);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Cijena (€):";
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(697, 95);
            tbPrice.Margin = new Padding(3, 4, 3, 4);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(205, 27);
            tbPrice.TabIndex = 5;
            // 
            // lblExtra1
            // 
            lblExtra1.AutoSize = true;
            lblExtra1.Location = new Point(23, 157);
            lblExtra1.Name = "lblExtra1";
            lblExtra1.Size = new Size(57, 20);
            lblExtra1.TabIndex = 6;
            lblExtra1.Text = "Marka:";
            // 
            // tbExtra1
            // 
            tbExtra1.Location = new Point(154, 152);
            tbExtra1.Margin = new Padding(3, 4, 3, 4);
            tbExtra1.Name = "tbExtra1";
            tbExtra1.Size = new Size(399, 27);
            tbExtra1.TabIndex = 7;
            // 
            // lblExtra2
            // 
            lblExtra2.AutoSize = true;
            lblExtra2.Location = new Point(594, 157);
            lblExtra2.Name = "lblExtra2";
            lblExtra2.Size = new Size(67, 20);
            lblExtra2.TabIndex = 8;
            lblExtra2.Text = "Godište:";
            // 
            // tbExtra2
            // 
            tbExtra2.Location = new Point(697, 152);
            tbExtra2.Margin = new Padding(3, 4, 3, 4);
            tbExtra2.Name = "tbExtra2";
            tbExtra2.Size = new Size(205, 27);
            tbExtra2.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(35, 115, 190);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(23, 220);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(229, 51);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Dodaj oglas";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(lblSearch);
            gbSearch.Controls.Add(tbSearch);
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(btnShowAll);
            gbSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbSearch.ForeColor = Color.FromArgb(35, 65, 105);
            gbSearch.Location = new Point(23, 413);
            gbSearch.Margin = new Padding(3, 4, 3, 4);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new Padding(3, 4, 3, 4);
            gbSearch.Size = new Size(1097, 107);
            gbSearch.TabIndex = 2;
            gbSearch.TabStop = false;
            gbSearch.Text = "Pretraživanje oglasa";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(23, 48);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(106, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Naslov sadrži:";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(154, 43);
            tbSearch.Margin = new Padding(3, 4, 3, 4);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(399, 27);
            tbSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(577, 37);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 43);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Pretraži";
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(749, 37);
            btnShowAll.Margin = new Padding(3, 4, 3, 4);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(160, 43);
            btnShowAll.TabIndex = 3;
            btnShowAll.Text = "Prikaži sve";
            // 
            // lblAdsHeader
            // 
            lblAdsHeader.AutoSize = true;
            lblAdsHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAdsHeader.ForeColor = Color.FromArgb(35, 65, 105);
            lblAdsHeader.Location = new Point(25, 540);
            lblAdsHeader.Name = "lblAdsHeader";
            lblAdsHeader.Size = new Size(122, 25);
            lblAdsHeader.TabIndex = 3;
            lblAdsHeader.Text = "Popis oglasa";
            // 
            // lbAds
            // 
            lbAds.Font = new Font("Consolas", 9F);
            lbAds.FormattingEnabled = true;
            lbAds.HorizontalScrollbar = true;
            lbAds.Location = new Point(23, 577);
            lbAds.Margin = new Padding(3, 4, 3, 4);
            lbAds.Name = "lbAds";
            lbAds.Size = new Size(1097, 184);
            lbAds.TabIndex = 4;
            // 
            // lblTotalFeeTitle
            // 
            lblTotalFeeTitle.AutoSize = true;
            lblTotalFeeTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalFeeTitle.Location = new Point(25, 793);
            lblTotalFeeTitle.Name = "lblTotalFeeTitle";
            lblTotalFeeTitle.Size = new Size(260, 25);
            lblTotalFeeTitle.TabIndex = 5;
            lblTotalFeeTitle.Text = "Ukupna naknada za objavu:";
            // 
            // lblTotalFee
            // 
            lblTotalFee.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalFee.ForeColor = Color.FromArgb(20, 125, 75);
            lblTotalFee.Location = new Point(297, 784);
            lblTotalFee.Name = "lblTotalFee";
            lblTotalFee.Size = new Size(286, 43);
            lblTotalFee.TabIndex = 6;
            lblTotalFee.Text = "0,00 €";
            lblTotalFee.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormAds
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1143, 867);
            Controls.Add(lblHeader);
            Controls.Add(gbAdDetails);
            Controls.Add(gbSearch);
            Controls.Add(lblAdsHeader);
            Controls.Add(lbAds);
            Controls.Add(lblTotalFeeTitle);
            Controls.Add(lblTotalFee);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1026, 851);
            Name = "FormAds";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Oglasnik - Polimorfizam";
            gbAdDetails.ResumeLayout(false);
            gbAdDetails.PerformLayout();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}