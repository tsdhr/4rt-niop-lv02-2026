namespace AdBoard;

public abstract class Advertisement {
    protected Advertisement(string title, decimal price) {
        Title = title;
        Price = price;
        PublishedAt = DateTime.Now;
    }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public DateTime PublishedAt { get; set; }
}
