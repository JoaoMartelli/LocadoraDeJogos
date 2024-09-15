using Dominio;

public interface IJogoRepositorio
{
    public void Adicionar(Jogo jogo);
    public void Atualizar(Jogo jogo);
    public void Remover(Jogo jogo);
    public List<Jogo> JogosDisponiveis();
    public List<Jogo> JogosIndisponiveis();
    public Jogo BuscarJogoPeloId(int id);
    public Jogo BuscarJogoPeloNome(string nome);
}