using ReservaAtividades.Domain.Repositorios;
using System.Threading.Tasks;

namespace ReservaAtividades.Data.Repositorios
{
    public class RepositoryBase : IRepository
    {
        protected RepositoryBase(ReservasContext context)
        {
            Context = context;
        }

        protected ReservasContext Context { get; }

        public async Task SalvarAlteracoes()
        {
            await Context.SaveChangesAsync();
        }
    }
}
