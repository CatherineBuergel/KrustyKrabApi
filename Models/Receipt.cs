using System.Collections.Generic;

namespace KrustyKrabAPI.Models
{
  public class Receipt
  {
    public Dictionary<string, decimal> ItemTotals { get; set; }
    public decimal Total { get; set; }


    //items, quantity
    public Receipt(Order order)
    {
      Total = 0;
      ItemTotals = new Dictionary<string, decimal>();
      foreach (var lineItem in order.Invoice)
      {
        var bb = FakeData.Menu.Find(b => b.Id == lineItem.Id);
        if (bb == null) { continue; }
        decimal subTotal = bb.Price * lineItem.Quantity;
        Total += subTotal;
        ItemTotals.Add(bb.Name, subTotal);
      }

    }
  }
}