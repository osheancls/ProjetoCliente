using ProjetoCliente.Models;

namespace ProjetoCliente.Repositorio
{
    public interface IClienteRepositorio
    {
        //crud
        IEnumerable<Cliente> TodosClientes();
    }
}
