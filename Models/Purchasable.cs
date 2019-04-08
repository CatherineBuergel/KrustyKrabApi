namespace KrustyKrabAPI.Models
{
  public class Purchasable
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public string Description { get; set; }
    public Purchasable(string name, string desc, decimal price, int id)
    {
      Name = name;
      Description = desc;
      Price = price;
      Id = id;
    }
  }
}