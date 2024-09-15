namespace Dominio;

public class Cliente
{
    #region Atributos

    private int _id;
    private string _nome;
    private string _email;
    private string _telefone;
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
                throw new ArgumentException("Nome do cliente não pode ser vazio.");
            }
            _nome = value;
        }
    }

    public string Email
    {
        get { return _email; }
        set { 
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Email do cliente não pode ser vazio.");
            }
            _email = value;
         }
    }

    public string Telefone
    {
        get { return _telefone; }
        set { 
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Telefone do cliente não pode ser vazio.");
            }
            _telefone = value;
        }
    }

    public List<Aluguel> Alugueis
    {
        get { return _alugueis; }
        set { _alugueis = value; }
    }

    #endregion

    #region Construtores

    public Cliente(string nome, string email, string telefone)
    {
        Email = email;
        Telefone = telefone;
        Nome = nome;
        _alugueis = new List<Aluguel>();
    }

    #endregion

}
