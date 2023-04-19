using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services.MoviesService
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
    }
}
