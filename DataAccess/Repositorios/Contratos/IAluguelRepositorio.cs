using Dominio;

public interface IAluguelRepositorio
{
    public void Adicionar(Aluguel aluguel);
    public List<JogosMaisAlugadosModelo> JogosMaisAlugados();
    public List<ClientesMaisAlugamModelo> ClientesMaisAlugam();
    public IQueryable<AlugueisAtrasadosModelos> Listar();
}