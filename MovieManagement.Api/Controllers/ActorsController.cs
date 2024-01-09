using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Application.Service;
using MovieManagement.Domain.Entity;

namespace MovieManagement.Application.Controllers
{
    [Route("Api/[Controller]")]
    public class ActorsController : ApiController
    {
        private readonly IActorService _actorService;

        public ActorsController(IActorService actorService) => _actorService = actorService;

        [HttpGet]
        public async Task<IActionResult> GetAllActors()
        {
            return Ok(await _actorService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ErrorOr<Actor?>>> GetActorByIdAsync([FromRoute] Guid id)
        {
            var result =  await _actorService.GetActorByIdAsync(id);

            return result.Match(Ok, errors => Problem(errors));
        }





    }
}
