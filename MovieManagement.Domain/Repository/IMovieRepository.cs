using MovieManagement.Domain.Common.Repository;
using MovieManagement.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Domain.Repository
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
    }
}
