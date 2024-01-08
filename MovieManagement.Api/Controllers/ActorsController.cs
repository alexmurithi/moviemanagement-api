using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Application.Service;
using MovieManagement.Domain.Entity;

namespace MovieManagement.Application.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
    public class ActorsController : ControllerBase
    {
        private readonly IActorService _actorService;

        public ActorsController(IActorService actorService) => _actorService = actorService;

        [HttpGet]
        public async Task<IActionResult> GetAllActors()
        {
            return Ok(await _actorService.GetAll());
        }


        //public ActionResult<ErrorOr<Actor?>> GetActorById(Guid id)
        // {
        //   var res = _actorService.GetActorById(id);

        // return res.Match(Ok, _ => Problem(statusCode : StatusCodes.Status404NotFound,title:"User not Found!"));


        // }

        [HttpGet("{id}")]
        public async  Task<ActionResult<ErrorOr<Actor?>>> GetActorByIdAsync([FromRoute] Guid id)
        {
            var result =  await _actorService.GetActorByIdAsync(id);

            return result.MatchFirst(Ok, error => Problem(statusCode: StatusCodes.Status404NotFound, title: error.Description));
        }





    }
}
