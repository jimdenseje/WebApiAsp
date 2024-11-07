namespace WebApiAsp.Models;

public class ProductItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public int InStock { get; set; }
    public int Sold { get; set; }
    public double Price { get; set; }
    public string? ImageUrl { get; set; }
}