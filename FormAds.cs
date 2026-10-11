namespace AdBoard {
    public partial class FormAds : Form {
        public FormAds() {
            InitializeComponent();
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
    }
}
