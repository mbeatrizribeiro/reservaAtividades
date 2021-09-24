using System.Threading.Tasks;

namespace ReservaAtividades.Domain.Repositorios
{
    public interface IRepository
    {
        Task SalvarAlteracoes();
    }
}
