namespace AdBoard; 
public class VehicleAd : Advertisement {
    public VehicleAd(string title, decimal price, string brand, int year) : base(title, price) {
        Brand = brand;
        Year = year;
    }
    override public string GetDetails() {
        return $"Vozilo: {Brand}, {Year}.";
    }
    public override decimal CalculateFee() {
        var fee = Price * 0.02m;
        return fee < 5m ? 5m : fee;
    }
    public string Brand { get; set; }
    public int Year { get; set; }
}
