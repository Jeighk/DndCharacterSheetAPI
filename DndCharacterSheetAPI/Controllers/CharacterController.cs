using Microsoft.AspNetCore.Mvc;
using DndCharacterSheetAPI.Models;
using Microsoft.AspNetCore.Http;
using DndCharacterSheetAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace DndCharacterSheetAPI.Controllers
{
    [ApiController]
    [Route("api/character")]
    public class CharacterController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        private readonly DataContext _dataContext;
        private readonly ILogger<CharacterController> _logger;
        public CharacterController(DataContext context)
        {
            _dataContext = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CharacterModel>>> Get()
        {
            try
            {
                return Ok(await _dataContext.Characters.ToListAsync());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        public async Task<ActionResult> Post(CharacterModel model)
        {
            var hero = new CharacterModel();
            _dataContext.Characters.Add(model);            
            await _dataContext.SaveChangesAsync();        
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
