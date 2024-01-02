namespace CSharp.Calculadoraa;

class Opcoes
{
  private Calculadora calculadora = new Calculadora();

  public void MenuOpcoes()
  {
    Console.WriteLine("Escolha a operação que deseja realizar!\n");
    Console.WriteLine("Digite '1' para efetuar uma soma.");
    Console.WriteLine("Digite '2' para efetuar uma subtração.");
    Console.WriteLine("Digite '3' para efetuar uma divisão.");
    Console.WriteLine("Digite '4' para efetuar uma multiplicação.");
    Console.WriteLine("Digite '5' para sair da aplicação.\n");

    int numeroEscolhido = int.Parse(Console.ReadLine()!);

    OpcaoEscolhida(numeroEscolhido);
  }

  public void OpcaoEscolhida(int numeroEscolhido)
  {
    switch (numeroEscolhido)
    {
      case 1:
        calculadora.Soma();
        break;
      case 2:
        calculadora.Subtracao();
        break;
      case 3:
        calculadora.Divisao();
        break;
      case 4:
        calculadora.Multiplicacao();
        break;
      case 5:
        Console.WriteLine("Programa encerrado.\n");
        return;
      default:
        Console.WriteLine("Digite uma opção válida.");
        Thread.Sleep(2000);
        Console.Clear();
        break;
    }

    MenuOpcoes();
  }
}