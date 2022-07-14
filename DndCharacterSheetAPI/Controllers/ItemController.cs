using Microsoft.AspNetCore.Mvc;

namespace DndCharacterSheetAPI.Controllers
{
    public class ItemController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult> Post()
        {
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> Put()
        {
            return Ok();
        }
        [HttpDelete]
        public async Task<ActionResult> Delete()
        {
            return Ok();
        }
    }
}
