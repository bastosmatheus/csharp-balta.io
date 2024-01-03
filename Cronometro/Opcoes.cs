namespace CSharp.Cronometroo;

class Opcoes
{
  public void MenuOpcoes()
  {
    Console.Clear();
    Console.WriteLine("Escolha o que deseja utilizar para a contagem no cronômetro.\n");
    Console.WriteLine("S || s = Segundos");
    Console.WriteLine("M || m = Minutos");
    Console.WriteLine("Q || q = Sair da aplicação.\n");

    string escolha = Console.ReadLine()!.ToLower();

    if (escolha == "q")
    {
      Console.Clear();
      Console.WriteLine("Aplicação finalizada!");
      return;
    }

    Console.Clear();
    Console.WriteLine("Quanto tempo deseja contar no cronômetro?");

    int tempo = int.Parse(Console.ReadLine()!);

    OpcaoEscolhida(escolha, tempo);
  }

  public void OpcaoEscolhida(string escolha, int tempo)
  {
    switch (escolha)
    {
      case "s":
        Cronometro.ContadorDeTempo(tempo);
        break;
      case "m":
        int TransformandoMinutosEmSegundos = tempo * 60;
        Cronometro.ContadorDeTempo(TransformandoMinutosEmSegundos);
        break;
      default:
        Console.WriteLine("Digite uma opção válida.");
        Thread.Sleep(2000);
        Console.Clear();
        break;
    }

    MenuOpcoes();
  }
}