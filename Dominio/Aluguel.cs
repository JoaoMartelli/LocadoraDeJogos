namespace Dominio;

public class Aluguel
{

    #region Atributos

    private int _id;
    private DateTime _dataAluguel;
    private DateTime _dataDevolucao;
    private Jogo _jogo;
    private Cliente _cliente;
    private int _jogoId;
    private int _clienteId;

    #endregion

    #region Propriedades

    public int Id
    {
        get { return _id; }
    }

    public DateTime DataAluguel
    {
        get { return _dataAluguel; }
        set { _dataAluguel = value; }
    }

    public DateTime DataDevolucao
    {
        get { return _dataDevolucao; }
        set { _dataDevolucao = value; }
    }

    public int JogoId
    {
        get { return _jogoId; }
        set { _jogoId = value; }
    }

    public int ClienteId
    {
        get { return _clienteId; }
        set { _clienteId = value; }
    }

    public Cliente Cliente
    {
        get { return _cliente; }
        set { _cliente = value; }
    }

    public Jogo Jogo
    {
        get { return _jogo; }
        set { _jogo = value; }
    }

    #endregion

    #region Construtor

    public Aluguel(int jogoId, int clienteId)
    {
        JogoId = jogoId;
        ClienteId = clienteId;
        DataAluguel = DateTime.Now;
        DataDevolucao = DataAluguel.AddDays(7);
    }

    #endregion
}