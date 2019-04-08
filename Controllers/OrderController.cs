using Microsoft.AspNetCore.Mvc;

namespace KrustyKrabAPI.Models
{
  [Route("api/[controller]")]
  [ApiController]
  public class OrderController
  {
    [HttpPost]
    public ActionResult<Receipt> NewOrder([FromBody] Order order)
    {
      return new Receipt(order);
    }
  }
}