using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KrustyKrabAPI.Models;


namespace KrustyKrabAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PurchasableController : ControllerBase
  {
    List<Purchasable> Menu = FakeData.Menu;
    // GET api/values
    [HttpGet]
    public ActionResult<List<Purchasable>> Get()
    {
      return Menu;
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Purchasable> Get(int id)
    {
      Purchasable found = Menu.Find(i => i.Id == id);
      if (found != null)
      {
        return found;
      }
      return BadRequest("{\"error\": \"not found\"}");
    }

    // POST api/values
    [HttpPost]
    public ActionResult<List<Purchasable>> Post([FromBody] Purchasable purchasable)
    {
      Menu.Add(purchasable);
      return Menu;
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public ActionResult<Purchasable> Put(int id, [FromBody] Purchasable newData)
    {
      Purchasable OldData = Menu.Find(i => i.Id == id);
      if (OldData == null) { return BadRequest(); }
      Menu.Remove(OldData);
      Menu.Add(newData);
      return newData;
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      Purchasable OldData = Menu.Find(i => i.Id == id);
      if (OldData == null) { return BadRequest(); }
      Menu.Remove(OldData);
      return Ok();
    }
  }
}
