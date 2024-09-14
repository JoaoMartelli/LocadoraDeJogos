using DataAccess;
using Dominio;

public class AluguelRepositorio : IAluguelRepositorio
{
    private readonly Contexto _contexto;

    public AluguelRepositorio(Contexto contexto)
    {
        _contexto = contexto;
    }

    public void Adicionar(Aluguel aluguel)
    {
        _contexto.Alugueis.Add(aluguel);
        _contexto.SaveChanges();
    }

    public IQueryable<AlugueisAtrasadosModelos> Listar()
    {
        IQueryable<AlugueisAtrasadosModelos> lista = _contexto.Alugueis.GroupBy(x => x.Id)
        .Select(g => new
        {
            JogoId = g.Key,
            ClienteId = g.First().ClienteId,
            Disponibilidade = g.First().Jogo.Disponibilidade,
            DataDevolucao = g.Max(x => x.DataDevolucao)
        })
        .Join(_contexto.Jogos,
                aluguel => aluguel.JogoId,
                jogo => jogo.Id,
                (aluguel, jogos) => new AlugueisAtrasadosModelos
                {
                    AluguelId = aluguel.JogoId,
                    Disponibilidade = jogos.Disponibilidade,
                    DataDevolucao = aluguel.DataDevolucao,
                    ClienteId = aluguel.ClienteId,
                    JogoId = aluguel.JogoId,
                }).Where(x => x.Disponibilidade == false && x.DataDevolucao < DateTime.Now);

        return lista;
    }

    public List<ClientesMaisAlugamModelo> ClientesMaisAlugam()
    {
        var clientesMaisAlugam = _contexto.Alugueis
            .GroupBy(a => a.ClienteId)
            .Select(g => new
            {
                ClienteId = g.Key,
                QuantidadeAlugueis = g.Count()
            })
            .Join(_contexto.Clientes,
                aluguel => aluguel.ClienteId,
                cliente => cliente.Id,
                (aluguel, cliente) => new ClientesMaisAlugamModelo
                {
                    NomeCliente = cliente.Nome,
                    QuantidadeAluguel = aluguel.QuantidadeAlugueis
                })
                .OrderByDescending(a => a.QuantidadeAluguel)
            .ToList();

        return clientesMaisAlugam;
    }

    public List<JogosMaisAlugadosModelo> JogosMaisAlugados()
    {
        var x = _contexto.Alugueis
            .GroupBy(a => a.JogoId)
            .Select(g => new
            {
                JogoId = g.Key,
                QuantidadeAlugueis = g.Count()
            })
            .Join(_contexto.Jogos,
                aluguel => aluguel.JogoId,
                jogo => jogo.Id,
                (aluguel, jogo) => new JogosMaisAlugadosModelo
                {
                    JogoNome = jogo.Nome,
                    QuantidadeAluguel = aluguel.QuantidadeAlugueis
                })
                .OrderByDescending(a => a.QuantidadeAluguel)
            .ToList();

        return x;
    }


}


