namespace AdBoard {
    public partial class FormAds : Form {
        private AdBoard adBoard;
        public FormAds() {
            InitializeComponent();
            adBoard = new AdBoard();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cbType.SelectedItem?.ToString()) {
                case "Vozilo":
                    lblExtra1.Text = "Marka:";
                    lblExtra2.Text = "Godište:";
                    break;

                case "Nekretnina":
                    lblExtra1.Text = "Lokacija:";
                    lblExtra2.Text = "Površina (m²):";
                    break;

                case "Usluga":
                    lblExtra1.Text = "Regija:";
                    lblExtra2.Text = "Kontakt:";
                    break;
            }

            tbExtra1.Clear();
            tbExtra2.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            if (cbType.SelectedItem?.ToString() == "Vozilo") {
                var price = decimal.Parse(tbPrice.Text);
                var year = int.Parse(tbExtra2.Text);
                adBoard.Add(new VehicleAd(
                    tbTitle.Text,
                    price,
                    tbExtra1.Text,
                    year)
                );
            }
            else if (cbType.SelectedItem?.ToString() == "Nekretnina") {
                // var realEstateAd = new RealEstateAd(tbTitle.Text, nudPrice.Value, tbExtra1.Text, (double)nudExtra2.Value);
                // adBoard.Add(realEstateAd);
            }
            else if (cbType.SelectedItem?.ToString() == "Usluga") {
                // var serviceAd = new ServiceAd(tbTitle.Text, nudPrice.Value, tbExtra1.Text, tbExtra2.Text);
                // adBoard.Add(serviceAd);
            }
            RefreshAdsListAndFees();
        }

        private void RefreshAdsListAndFees() {
            lbAds.Items.Clear();
            foreach (var ad in adBoard.GetAll()) {
                lbAds.Items.Add(ad);
            }
            lblTotalFee.Text = $"{adBoard.GetTotalFee():C}";
        }
    }
}
