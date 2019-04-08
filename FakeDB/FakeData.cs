using System.Collections.Generic;

namespace KrustyKrabAPI.Models
{
  public static class FakeData
  {
    public static List<Purchasable> Menu = new List<Purchasable>()
      {
        new Purchasable("Krabby Patty", "Perfectly grilled to perfection by SpongeBob", 2.75m, 110022),
        new Purchasable("Milkshake", "Chocolate, strawberry, or vanilla", 1.50m, 110033),
        new Purchasable("Fries", "Krispy, golden goodness", 2.00m, 110044)
      };


  }
}