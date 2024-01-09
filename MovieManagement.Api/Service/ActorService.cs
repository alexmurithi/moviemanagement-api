using ErrorOr;
using Microsoft.AspNetCore.Http.HttpResults;
using MovieManagement.Application.Exceptions;
using MovieManagement.Domain.Entity;
using MovieManagement.Domain.UnitOfWork;
using MovieManagement.Domain.Common.Errors;

namespace MovieManagement.Application.Service
{
    public class ActorService : IActorService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ILogger<ActorService> _logger;

        public ActorService(IUnitOfWork unitOfWork, ILogger<ActorService> logger) 
            => (_unitOfWork, _logger) = (unitOfWork, logger);

        public ErrorOr<Actor?> GetActorById(Guid id)
        {
            var actor = _unitOfWork.ActorRepository.GetById(id);
            if (actor is not null)
            {
                _logger.LogInformation($"Returning Actor: Id={actor.Id}, FirstName={actor.FirstName}, LastName={actor.LastName}");
                return actor;
            }
            _logger.LogInformation($"Actor with Id {id} not found");
            return Errors.Actor.ActorNotFound(id);
        }

        public async Task<ErrorOr<Actor?>> GetActorByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var actor = await _unitOfWork.ActorRepository.GetByIdAsync(id, cancellationToken);

            if (actor is not null)
            {
                _logger.LogInformation($"Returning Actor: Id={actor.Id}, FirstName={actor.FirstName}");
                return actor;
            }

            _logger.LogInformation($"Actor with Id {id} not found");
            return Errors.Actor.ActorNotFound(id);
        }


        public async Task<IEnumerable<Actor>> GetAll()
        {
            var actors = await _unitOfWork.ActorRepository.GetAllAsync();
            _logger.LogInformation($"Returning Actors: {actors.Count()} actors returned");
            return actors;
        }

        

    }
}
