using System.Collections.ObjectModel;

namespace AdBoard; 
public class AdBoard {
    public AdBoard() {
        ads = new List<Advertisement>();
    }

    public void Add(Advertisement ad) {
        ads.Add(ad);
    }

    public ReadOnlyCollection<Advertisement> GetAll() {
        return ads.AsReadOnly();
    }

    public decimal GetTotalFee() {
        decimal totalFee = 0;
        foreach (var ad in ads) {
            totalFee += ad.CalculateFee();
        }
        return totalFee;
    }

    public List<Advertisement> Search(string text) {
        return
            (from ad in ads
            where ad.Title.Contains(text, StringComparison.OrdinalIgnoreCase)
            select ad).ToList();
    }

    private List<Advertisement> ads;
}
