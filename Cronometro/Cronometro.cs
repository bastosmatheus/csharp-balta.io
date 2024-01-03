namespace CSharp.Cronometroo;

static class Cronometro
{
  public static void ContadorDeTempo(int tempo)
  {
    for (var i = 1; i <= tempo; i++)
    {
      Console.Clear();
      Console.WriteLine(i);
      Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Cronomêtro finalizado!\nDigite qualquer tecla para voltar ao menu.");
    Console.ReadKey();
  }
}