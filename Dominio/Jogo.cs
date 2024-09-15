namespace Dominio;

public class Jogo
{
    #region Atributos

    private int _id;
    private string _nome;
    private string _genero;
    private string _plataforma;
    private bool _disponibilidade;
    private List<Aluguel> _alugueis;

    #endregion

    #region Propriedades

    public int Id
    {
        get { return _id; }
    }

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Nome do jogo não pode ser vazio.");
            }
            _nome = value;
        }
    }

    public string Genero
    {
        get { return _genero; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Gênero do jogo não pode ser vazio.");
            }
            _genero = value;
        }
    }

    public string Plataforma
    {
        get { return _plataforma; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Plataforma do jogo não pode ser vazia.");
            }
            _plataforma = value;
        }
    }

    public bool Disponibilidade
    {
        get { return _disponibilidade; }
    }

    public List<Aluguel> Alugueis
    {
        get { return _alugueis; }
        set { _alugueis = value; }
    }

    #endregion

    #region Construtores

    public Jogo(string nome, string genero, string plataforma)
    {
        Nome = nome;
        Genero = genero;
        Plataforma = plataforma;
        _alugueis = new List<Aluguel>();
        _disponibilidade = true;
    }

    #endregion

    #region Métodos

    public void Disponivel()
    {
        _disponibilidade = true;
    }

    public void Indisponivel()
    {
        _disponibilidade = false;
    }

    #endregion

}