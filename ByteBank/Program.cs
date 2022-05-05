// See https://aka.ms/new-console-template for more information

using ByteBank;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

Console.WriteLine("ByteBank");

//CalcularBonificacao();
UsarSistema();

static void UsarSistema()
{
    SistemaInterno sistemainterno = new SistemaInterno();

    Diretor roberta = new Diretor("159.753.398-04");
    roberta.Nome = "Roberta";
    roberta.Senha = "123";
        
    GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
    camila.Nome = "Camila";
    camila.Senha = "abc";

    ParceiroComercial parceiro = new ParceiroComercial();
    parceiro.Senha = "123456";

    sistemainterno.Logar(parceiro, "123456");
    
    sistemainterno.Logar(camila, "abc");

    sistemainterno.Logar(roberta, "123");
}

/*static void CalcularBonificacao()
{
    GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

    Designer pedro = new Designer("833.222.048-39");
    pedro.Nome = "Pedro";

    Diretor roberta = new Diretor("159.753.398-04");
    roberta.Nome = "Roberta";

    Auxiliar igor = new Auxiliar("981.198.778-53");
    igor.Nome = "Igor";

    GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
    camila.Nome = "Camila";

    Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
    guilherme.Nome = "Guilherme";


    gerenciadorBonificacao.Registrar(pedro);
    gerenciadorBonificacao.Registrar(roberta);
    gerenciadorBonificacao.Registrar(igor);
    gerenciadorBonificacao.Registrar(camila);
    gerenciadorBonificacao.Registrar(guilherme);

    Console.WriteLine($"Total de bonificações no mês = {gerenciadorBonificacao.GetTotalBonificacao()}");   
}*/
