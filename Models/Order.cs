using System.Collections.Generic;
namespace KrustyKrabAPI.Models
{
  public class Order
  {
    public int Id { get; set; }
    public List<LineItem> Invoice { get; set; } = new List<LineItem>();

  }
}