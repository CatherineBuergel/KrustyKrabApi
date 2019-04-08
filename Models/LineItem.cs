using System.ComponentModel.DataAnnotations;

namespace KrustyKrabAPI.Models
{
  public class LineItem
  {
    public int Id { get; set; }

    [Range(1, 50)]
    public int Quantity { get; set; }
  }
}