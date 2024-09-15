using Dominio;
using DataAccess;

public class JogoRepositorio : IJogoRepositorio
{
	private readonly Contexto _contexto;

    public JogoRepositorio(Contexto contexto)
    {
        _contexto = contexto;
    }

    public void Adicionar(Jogo jogo)
    {
        _contexto.Jogos.Add(jogo);
        _contexto.SaveChanges();
    }

    public void Atualizar(Jogo jogo)
    {
        _contexto.Jogos.Update(jogo);
        _contexto.SaveChanges();
    }

    public void Remover(Jogo jogo)
    {
        _contexto.Jogos.Remove(jogo);
        _contexto.SaveChanges();
    }

    public List<Jogo> JogosDisponiveis()
    {
        return _contexto.Jogos.Where(jogo => jogo.Disponibilidade == true).ToList();
    }

    public List<Jogo> JogosIndisponiveis()
    {
        return _contexto.Jogos.Where(jogo => jogo.Disponibilidade == false).ToList();
    }

    public Jogo BuscarJogoPeloNome(string nome)
    {
        using Contexto contexto = new Contexto();

        return contexto.Jogos.FirstOrDefault(x => x.Nome == nome);
    }

    public Jogo BuscarJogoPeloId(int id)
    {
        using Contexto contexto = new Contexto();

        return contexto.Jogos.FirstOrDefault(x => x.Id == id);
    }

}