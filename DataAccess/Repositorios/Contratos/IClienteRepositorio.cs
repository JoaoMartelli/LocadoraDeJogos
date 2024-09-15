using Dominio;

public interface IClienteRepositorio
{
    public void Adicionar(Cliente cliente);
    public void Atualizar(Cliente cliente);
    public void Remover(Cliente cliente);
    public Cliente BuscarClientePeloEmail(string email);
    public Cliente BuscarClientePeloNome(string nome);
    public Cliente BuscarClientePeloId(int id);

}