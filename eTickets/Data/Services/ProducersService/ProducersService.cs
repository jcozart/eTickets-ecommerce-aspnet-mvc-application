using eTickets.Data.Base;
using eTickets.Models;

namespace eTickets.Data.Services.ProducersService
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context) { }
    }
}
