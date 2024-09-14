using DataAccess;
using Dominio;
public partial class Program
{
    public static void Main(string[] args)
    {
        try
        {
            AcoesMenu();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro no programa principal: {ex.Message}");
        }
    }

    public static EnumMenu Menu()
    {
        try
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|                            MENU                            |");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 1 - Gerenciamento de Jogos                                 |");
            Console.WriteLine("| 2 - Cadastro de Clientes                                   |");
            Console.WriteLine("| 3 - Registro de Alugueis                                   |");
            Console.WriteLine("| 4 - Devolucões                                             |");
            Console.WriteLine("| 5 - Relatórios                                             |");
            Console.WriteLine("| 0 - Sair                                                   |");
            Console.WriteLine("--------------------------------------------------------------");

            var OpcaoMenu = Enum.TryParse<EnumMenu>(Console.ReadLine(), out var opcaoMenu);

            Console.Clear();

            if (!OpcaoMenu)
            {
                throw new Exception("opção inválida. Digite uma opção válida.");
            }

            return opcaoMenu;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro no menu principal: {ex.Message}");
            return Menu();
        }
    }

    public static void AcoesMenu()
    {
        EnumMenu? acao = null;

        try
        {
            acao = Menu();
            switch (acao)
            {
                case EnumMenu.GerenciamentoJogos:
                    GerenciamentoJogos();
                    break;

                case EnumMenu.CadastroClientes:
                    CadastroClientes();
                    break;

                case EnumMenu.RegistroAlugueis:
                    RegistroAlugueis();
                    break;

                case EnumMenu.Devolucoes:
                    Devolucoes();
                    break;

                case EnumMenu.Relatorios:
                    Relatorios();
                    break;

                case EnumMenu.Sair:
                    Console.WriteLine("Saindo do sistema...");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro nas ações do menu principal: {ex.Message}");
        }
        finally
        {
            if (acao != EnumMenu.Sair)
            {
                AcoesMenu();
            }
        }
    }

    public static void GerenciamentoJogos()
    {

        EnumGerenciamentoJogos? acao = null;

        try
        {
            acao = MenuGerenciamentoJogos();

            switch (acao)
            {
                case EnumGerenciamentoJogos.NovoJogo:
                    AdicionarJogo();
                    break;

                case EnumGerenciamentoJogos.AtualizarJogo:
                    AtualizarJogo();
                    break;

                case EnumGerenciamentoJogos.RemoverJogo:
                    RemoverJogo();
                    break;

                case EnumGerenciamentoJogos.Voltar:
                    Console.WriteLine("Voltando ao Menu Principal...");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro nas ações do Gerenciamento de Jogos: {ex.Message}");
        }
        finally
        {
            if (acao != EnumGerenciamentoJogos.Voltar)
            {
                GerenciamentoJogos();
            }
        }
    }

    public static EnumGerenciamentoJogos MenuGerenciamentoJogos()
    {
        try
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|                   GERENCIAMENTO DE JOGOS                   |");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 1 - Cadastrar Novo Jogo                                    |");
            Console.WriteLine("| 2 - Editar Jogo Existente                                  |");
            Console.WriteLine("| 3 - Excluir Jogo                                           |");
            Console.WriteLine("| 0 - Voltar ao Menu Principal                               |");
            Console.WriteLine("--------------------------------------------------------------");

            var OpcaoMenu = Enum.TryParse<EnumGerenciamentoJogos>(Console.ReadLine(), out var opcaoMenu);

            Console.Clear();

            if (!OpcaoMenu)
            {
                throw new Exception("opção inválida. Digite uma opção válida.");
            }

            return opcaoMenu;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro no menu de gerenciamento de jogos: {ex.Message}");
            return MenuGerenciamentoJogos();
        }
    }

    public static void CadastroClientes()
    {

        EnumCadastroClientes? acao = null;

        try
        {
            acao = MenuCadastroClientes();

            switch (acao)
            {
                case EnumCadastroClientes.Cadastrar:
                    AdicionarCliente();
                    break;

                case EnumCadastroClientes.Atualizar:
                    AtualizarCliente();
                    break;

                case EnumCadastroClientes.Remover:
                    RemoverCliente();
                    break;

                case EnumCadastroClientes.Voltar:
                    Console.WriteLine("Voltando ao Menu Principal...");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro nas ações de cadastro de clientes: {ex.Message}");
        }
        finally
        {
            if (acao != EnumCadastroClientes.Voltar)
            {
                CadastroClientes();
            }
        }
    }

    public static EnumCadastroClientes MenuCadastroClientes()
    {
        try
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|                    CADASTRO DE CLIENTES                    |");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 1 - Cadastrar Novo Cliente                                 |");
            Console.WriteLine("| 2 - Editar Cliente Existente                               |");
            Console.WriteLine("| 3 - Excluir Cliente                                        |");
            Console.WriteLine("| 0 - Voltar ao Menu Principal                               |");
            Console.WriteLine("--------------------------------------------------------------");

            var OpcaoMenu = Enum.TryParse<EnumCadastroClientes>(Console.ReadLine(), out var opcaoMenu);

            Console.Clear();

            if (!OpcaoMenu)
            {
                throw new Exception("opção inválida. Digite uma opção válida.");
            }

            return opcaoMenu;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro no menu de cadastro de clientes: {ex.Message}");
            return MenuCadastroClientes();
        }
    }

    public static void RegistroAlugueis()
    {
        EnumRegistroAlugueis? acao = null;

        try
        {
            acao = MenuRegistroAlugueis();

            switch (acao)
            {
                case EnumRegistroAlugueis.NovoAluguel:
                    RegistrarAluguel();
                    break;

                case EnumRegistroAlugueis.Voltar:
                    Console.WriteLine("Voltando ao Menu Principal...");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro nas ações de registro de alugueis: {ex.Message}");
        }
        finally
        {
            if (acao != EnumRegistroAlugueis.Voltar)
            {
                RegistroAlugueis();
            }
        }

    }

    public static EnumRegistroAlugueis MenuRegistroAlugueis()
    {
        try
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|                     REGISTRO DE ALUGUEIS                   |");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 1 - Registrar Novo Aluguel                                 |");
            Console.WriteLine("| 0 - Voltar ao Menu Principal                               |");
            Console.WriteLine("--------------------------------------------------------------");

            var OpcaoMenu = Enum.TryParse<EnumRegistroAlugueis>(Console.ReadLine(), out var opcaoMenu);

            Console.Clear();

            if (!OpcaoMenu)
            {
                throw new Exception("opção inválida. Digite uma opção válida.");
            }

            return opcaoMenu;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro no menu de registro de alugueis: {ex.Message}");
            return MenuRegistroAlugueis();
        }
    }

    public static void Devolucoes()
    {
        EnumDevolucoes? acao = null;

        try
        {
            acao = MenuDevolucoes();

            switch (acao)
            {
                case EnumDevolucoes.Devolucao:
                    RegistrarDevolucao();
                    break;

                case EnumDevolucoes.Voltar:
                    Console.WriteLine("Voltando ao Menu Principal...");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro nas ações de devolução: {ex.Message}");
        }
        finally
        {
            if (acao != EnumDevolucoes.Voltar)
            {
                Devolucoes();
            }

        }

    }

    public static EnumDevolucoes MenuDevolucoes()
    {
        try
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|                     REGISTRO DE ALUGUEIS                   |");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 1 - Devolver Jogo                                          |");
            Console.WriteLine("| 0 - Voltar ao Menu Principal                               |");
            Console.WriteLine("--------------------------------------------------------------");

            var OpcaoMenu = Enum.TryParse<EnumDevolucoes>(Console.ReadLine(), out var opcaoMenu);

            Console.Clear();

            if (!OpcaoMenu)
            {
                throw new Exception("opção inválida. Digite uma opção válida.");
            }

            return opcaoMenu;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro no menu de devoluções: {ex.Message}");
            return MenuDevolucoes();
        }
    }

    public static void Relatorios()
    {
        EnumRelatorios? acao = null;

        try
        {
            acao = MenuRelatorios();

            switch (acao)
            {
                case EnumRelatorios.JogosMaisAlugados:
                    JogosMaisAlugados();
                    break;

                case EnumRelatorios.ClientesMaisAlugam:
                    ClientesMaisAlugam();
                    break;

                case EnumRelatorios.JogosAlugados:
                    JogosAlugados();
                    break;

                case EnumRelatorios.JogosDisponiveis:
                    JogosDisponiveis();
                    break;

                case EnumRelatorios.AlugueisAtrasados:
                    AlugueisAtrasados();
                    break;

                case EnumRelatorios.Voltar:
                    Console.WriteLine("Voltando ao Menu Principal...");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro nas ações do relatorio: {ex.Message}");
        }
        finally
        {
            if (acao != EnumRelatorios.Voltar)
            {
                Relatorios();
            }
        }
    }

    public static EnumRelatorios MenuRelatorios()
    {
        try
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|                        RELATÓRIOS                          |");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 1 - Relatório de Jogos Mais Alugados                       |");
            Console.WriteLine("| 2 - Relatório de Clientes que Mais Alugam                  |");
            Console.WriteLine("| 3 - Relatório de Jogos Alugados                            |");
            Console.WriteLine("| 4 - Relatório de Jogos Disponiveis                         |");
            Console.WriteLine("| 5 - Relatório de Alugueis que estão atrasados              |");
            Console.WriteLine("| 0 - Voltar ao Menu Principal                               |");
            Console.WriteLine("--------------------------------------------------------------");

            var OpcaoMenu = Enum.TryParse<EnumRelatorios>(Console.ReadLine(), out var opcaoMenu);

            Console.Clear();

            if (!OpcaoMenu)
            {
                throw new Exception("opção inválida. Digite uma opção válida.");
            }

            return opcaoMenu;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro no menu de relatorios: {ex.Message}");
            return MenuRelatorios();
        }
    }

    public static void AdicionarJogo()
    {
        try
        {
            using Contexto contexto = new Contexto();

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|                      CADASTRO DE JOGOS                     |");
            Console.WriteLine("--------------------------------------------------------------");
            Console.Write("| Informe o nome do jogo: ");
            var nome = Console.ReadLine();
            var repositorioJogo = new JogoRepositorio(contexto);

            if (repositorioJogo.BuscarJogoPeloNome(nome) != null)
            {
                throw new Exception("Esse jogo já foi cadastrado.");
            }

            Console.Write("| Informe o Gênero do jogo: ");
            var genero = Console.ReadLine();
            Console.Write("| Informe a Plataforma do jogo: ");
            var plataforma = Console.ReadLine();

            if (Confirmar() == false)
            {
                throw new Exception("Cancelando...");
            }

            var jogo = new Jogo(nome, genero, plataforma);

            repositorioJogo.Adicionar(jogo);
            Console.Clear();
            Console.WriteLine("Jogo cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na hora de adicionar jogo: {ex.Message}");
        }
    }

    public static void AtualizarJogo()
    {
        try
        {
            using Contexto contexto = new Contexto();
            var repositorioJogo = new JogoRepositorio(contexto);

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|                    ATUALIZAÇÃO DE JOGOS                    |");
            Console.WriteLine("--------------------------------------------------------------");
            Console.Write("| Informe o nome do jogo que deseja atualizar: ");
            var nome = Console.ReadLine();

            var jogo = repositorioJogo.BuscarJogoPeloNome(nome);

            if (jogo == null)
            {
                throw new Exception("Esse jogo ainda não foi cadastrado.");
            }

            Console.WriteLine("Se quiser manter alguma informação basta dar enter sem nada.");
            Console.Write("| Informe o novo nome do jogo que deseja atualizar: ");
            nome = Console.ReadLine();
            Console.Write("| Informe o novo Gênero do jogo: ");
            var genero = Console.ReadLine();
            Console.Write("| Informe a nova Plataforma do jogo: ");
            var plataforma = Console.ReadLine();


            if (!Confirmar())
            {
                throw new Exception("Cancelando...");
            }

            if (!string.IsNullOrEmpty(genero))
            {
                jogo.Genero = genero;
            }

            if (!string.IsNullOrEmpty(nome))
            {
                jogo.Nome = nome;
            }

            if (!string.IsNullOrEmpty(plataforma))
            {
                jogo.Plataforma = plataforma;
            }

            repositorioJogo.Atualizar(jogo);

            Console.Clear();
            Console.WriteLine("Jogo atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na hora de atualizar jogo: {ex.Message}");
        }
    }

    public static void RemoverJogo()
    {
        try
        {
            using Contexto contexto = new Contexto();
            var repositorioJogo = new JogoRepositorio(contexto);

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|                        REMOVER JOGOS                       |");
            Console.WriteLine("--------------------------------------------------------------");
            Console.Write("| Informe o nome do jogo que deseja remover:");
            var nome = Console.ReadLine();

            var jogo = repositorioJogo.BuscarJogoPeloNome(nome);

            if (jogo == null)
            {
                throw new Exception("Esse jogo ainda não foi cadastrado.");
            }

            if (!Confirmar())
            {
                throw new Exception("Cancelando...");
            }

            repositorioJogo.Remover(jogo);

            Console.Clear();
            Console.WriteLine("Jogo removido com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na hora de remover jogos: {ex.Message}");
        }
    }

    public static void AdicionarCliente()
    {
        try
        {
            using Contexto contexto = new Contexto();
            var repositorioCliente = new ClienteRepositorio(contexto);

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|                    CADASTRO DE CLIENTES                     |");
            Console.WriteLine("--------------------------------------------------------------");
            Console.Write("| Informe o nome do cliente: ");
            var nome = Console.ReadLine();

            Console.Write("| Informe o email do cliente: ");
            var email = Console.ReadLine();

            if (repositorioCliente.BuscarClientePeloEmail(email) != null)
            {
                throw new Exception("Esse cliente já foi cadastrado.");
            }


            Console.Write("| Informe o telefone do cliente: ");
            var telefone = Console.ReadLine();

            if (Confirmar() == false)
            {
                throw new Exception("Cancelando...");
            }

            var cliente = new Cliente(nome, email, telefone);

            repositorioCliente.Adicionar(cliente);
            Console.Clear();
            Console.WriteLine("Cliente cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na hora de adicionar jogo: {ex.Message}");
        }

    }

    public static void AtualizarCliente()
    {
        try
        {
            using Contexto contexto = new Contexto();
            var repositorioCliente = new ClienteRepositorio(contexto);

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|                  ATUALIZAÇÃO DE CLIENTES                   |");
            Console.WriteLine("--------------------------------------------------------------");
            Console.Write("| Informe o email do cliente que deseja atualizar: ");
            var email = Console.ReadLine();

            var cliente = repositorioCliente.BuscarClientePeloEmail(email);

            if (cliente == null)
            {
                throw new Exception("Esse cliente ainda não foi cadastrado.");
            }

            Console.WriteLine("Se quiser manter alguma informação basta dar enter sem nada.");
            Console.Write("| Informe o novo nome do cliente: ");
            var nome = Console.ReadLine();

            Console.Write("| Informe o novo email do cliente: ");
            email = Console.ReadLine();

            Console.Write("| Informe o novo telefone do cliente: ");
            var telefone = Console.ReadLine();


            if (!Confirmar())
            {
                throw new Exception("Cancelando...");
            }

            if (!string.IsNullOrEmpty(email))
            {
                cliente.Email = email;
            }

            if (!string.IsNullOrEmpty(nome))
            {
                cliente.Nome = nome;
            }

            if (!string.IsNullOrEmpty(telefone))
            {
                cliente.Telefone = telefone;
            }

            repositorioCliente.Atualizar(cliente);

            Console.Clear();
            Console.WriteLine("Cliente atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na hora de atualizar cliente: {ex.Message}");
        }
    }

    public static void RemoverCliente()
    {
        try
        {
            using Contexto contexto = new Contexto();
            var repositorioCliente = new ClienteRepositorio(contexto);

            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|                      REMOVER CLIENTES                       |");
            Console.WriteLine("--------------------------------------------------------------");
            Console.Write("| Informe o email do cliente que deseja remover: ");
            var email = Console.ReadLine();

            var cliente = repositorioCliente.BuscarClientePeloEmail(email);

            if (cliente == null)
            {
                throw new Exception("Esse cliente ainda não foi cadastrado.");
            }

            if (!Confirmar())
            {
                throw new Exception("Cancelando...");
            }

            repositorioCliente.Remover(cliente);

            Console.Clear();
            Console.WriteLine("Cliente removido com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na hora de remover cliente: {ex.Message}");
        }
    }

    public static void RegistrarAluguel()
    {
        try
        {
            using Contexto contexto = new Contexto();
            var repositorioCliente = new ClienteRepositorio(contexto);
            var repositorioJogo = new JogoRepositorio(contexto);


            Console.WriteLine("Informe qual ID do cliente que deseja registrar aluguel: ");
            var validandoClienteId = int.TryParse(Console.ReadLine(), out var clienteId);

            if (!validandoClienteId || repositorioCliente.BuscarClientePeloId(clienteId) == null)
            {
                throw new Exception("ID do cliente inválido.");
            }

            Console.WriteLine("Informe qual ID do jogo que deseja alugar: ");
            var validandoJogoId = int.TryParse(Console.ReadLine(), out var jogoId);
            if (!validandoJogoId)
            {
                throw new Exception("ID do jogo inválido.");
            }

            var jogo = repositorioJogo.BuscarJogoPeloId(jogoId);

            if (jogo == null)
            {
                throw new Exception("Esse jogo ainda não foi cadastrado.");
            }

            if (jogo.Disponibilidade == false)
            {
                throw new Exception("Esse jogo já está alugado.");
            }

            if (!Confirmar())
            {
                throw new Exception("Cancelando...");
            }

            var aluguel = new Aluguel(jogoId, clienteId);

            jogo.Indisponivel();
            var repositorioAluguel = new AluguelRepositorio(contexto);
            repositorioAluguel.Adicionar(aluguel);
            repositorioJogo.Atualizar(jogo);

            Console.Clear();
            Console.WriteLine("Aluguel registrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na hora de registrar aluguel: {ex.Message}");
        }
    }

    public static void RegistrarDevolucao()
    {
        try
        {
            using Contexto contexto = new Contexto();
            var repositorioJogo = new JogoRepositorio(contexto);

            Console.WriteLine("Informe qual o ID do jogo que deseja registrar devolução: ");
            var validandoJogoId = int.TryParse(Console.ReadLine(), out var jogoId);

            if (!validandoJogoId)
            {
                throw new Exception("ID do jogo inválido.");
            }

            var jogo = repositorioJogo.BuscarJogoPeloId(jogoId);

            if (jogo == null)
            {
                throw new Exception("Esse jogo ainda não foi cadastrado.");
            }

            if (jogo.Disponibilidade == true)
            {
                throw new Exception("Esse jogo não está alugado.");
            }

            if (!Confirmar())
            {
                throw new Exception("Cancelando...");
            }

            jogo.Disponivel();

            Console.Clear();
            Console.WriteLine("Devolução registrada com sucesso!");

            repositorioJogo.Atualizar(jogo);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro na hora de registrar devolução: {ex.Message}");
        }
    }

    public static void JogosMaisAlugados()
    {
        using Contexto contexto = new Contexto();
        var aluguelRepositorio = new AluguelRepositorio(contexto);

        var alugueisPorJogo = aluguelRepositorio.JogosMaisAlugados();

        if (alugueisPorJogo.Count() == 0)
        {
            throw new Exception("Nenhum jogo foi alugado ainda.");
        }

        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("|            Jogo              |      QuantidadeAlugueis     |");
        Console.WriteLine("--------------------------------------------------------------");


        int contador = 1;
        foreach (var item in alugueisPorJogo)
        {
            Console.WriteLine($"| {item.JogoNome,-28} | {item.QuantidadeAluguel,-27} |");
            contador++;
            if (contador > 10)
            {
                break;
            }
        }

    }

    public static void ClientesMaisAlugam()
    {
        using Contexto contexto = new Contexto();
        var aluguelRepositorio = new AluguelRepositorio(contexto);

        var clientesMaisAlugam = aluguelRepositorio.ClientesMaisAlugam();

        if (clientesMaisAlugam.Count() == 0)
        {
            throw new Exception("Nenhum cliente alugou ainda.");
        }

        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("|           Cliente            |      QuantidadeAlugueis     |");
        Console.WriteLine("--------------------------------------------------------------");


        int contador = 1;
        foreach (var item in clientesMaisAlugam)
        {
            Console.WriteLine($"| {item.NomeCliente,-28} | {item.QuantidadeAluguel,-27} |");
            contador++;
            if (contador > 10)
            {
                break;
            }
        }
    }

    public static void JogosAlugados()
    {
        using Contexto contexto = new Contexto();
        var jogosRepositorio = new JogoRepositorio(contexto);

        var jogosIndisponiveis = jogosRepositorio.JogosIndisponiveis();

        if (jogosIndisponiveis.Count() == 0)
        {
            throw new Exception("Não há nenhum jogo indisponivel.");
        }

        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("|            Jogos            |            Status            |");
        Console.WriteLine("--------------------------------------------------------------");

        foreach (var item in jogosIndisponiveis)
        {
            Console.WriteLine($"| {item.Nome,-27} | {"Indisponivel",-27} |");
        }
    }

    public static void JogosDisponiveis()
    {
        using Contexto contexto = new Contexto();
        var jogosRepositorio = new JogoRepositorio(contexto);

        var jogosDisponiveis = jogosRepositorio.JogosDisponiveis();

        if (jogosDisponiveis.Count() == 0)
        {
            throw new Exception("Não há nenhum jogo disponível.");
        }

        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("|            Jogos            |            Status            |");
        Console.WriteLine("--------------------------------------------------------------");

        foreach (var item in jogosDisponiveis)
        {
            Console.WriteLine($"| {item.Nome,-27} | {"Disponivel",-27} |");
        }
    }

    public static void AlugueisAtrasados()
    {

        using Contexto contexto = new Contexto();

        AluguelRepositorio aluguelRepositorio = new AluguelRepositorio(contexto);
        var jogosDisponiveis = aluguelRepositorio.Listar();

        if (jogosDisponiveis.Count() == 0)
        {
            throw new Exception("Não há nenhum aluguel atrasado.");
        }

        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("| AluguelID | ClienteID | JogoID |       DataDevolução       |");
        Console.WriteLine("--------------------------------------------------------------");

        foreach (var item in jogosDisponiveis)
        {
            Console.WriteLine($"| {item.AluguelId,-9} | {item.ClienteId,-9} | {item.JogoId,-6} | {item.DataDevolucao,-25} |");
        }
    }

    public static bool Confirmar()
    {
        try
        {
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("|                 DESJA CONFIRMAR A SUA ACÃO?                |");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("| 1 - Confirmar                                              |");
            Console.WriteLine("| 2 - Cancelar                                               |");
            Console.WriteLine("--------------------------------------------------------------");

            var opcao = Enum.TryParse<EnumConfirmar>(Console.ReadLine(), out var opcaoConfirmar);

            Console.Clear();

            if (!opcao)
            {
                throw new Exception("Opção inválida. Digite uma opção válida.");
            }

            if (opcaoConfirmar == EnumConfirmar.Confirmar)
            {
                return true;
            }

            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao confirmar ação: {ex.Message}");
            return Confirmar();
        }

    }

}