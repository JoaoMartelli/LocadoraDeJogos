using DataAccess;
using Dominio;

public class ClienteRepositorio : IClienteRepositorio
{
	private readonly Contexto _contexto;
	
	public ClienteRepositorio(Contexto contexto)
	{
		_contexto = contexto;
	}

    public void Adicionar(Cliente cliente)
    {
        _contexto.Clientes.Add(cliente);
        _contexto.SaveChanges();
    }

    public void Atualizar(Cliente cliente)
    {
        _contexto.Clientes.Update(cliente);
        _contexto.SaveChanges();
    }

    public void Remover(Cliente cliente)
    {
        _contexto.Clientes.Remove(cliente);
        _contexto.SaveChanges();
    }
    
    public Cliente BuscarClientePeloEmail(string email)
    {
        using Contexto contexto = new Contexto();

        return contexto.Clientes.FirstOrDefault(x => x.Email == email);
    }

    public Cliente BuscarClientePeloNome(string nome)
    {
        using Contexto contexto = new Contexto();

        return contexto.Clientes.FirstOrDefault(x => x.Nome == nome);
    }

    public Cliente BuscarClientePeloId(int id)
    {
        using Contexto contexto = new Contexto();

        return contexto.Clientes.FirstOrDefault(x => x.Id == id);
    }


}