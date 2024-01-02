namespace CSharp.Calculadoraa;
class Calculadora
{
  public double total;

  public Calculadora()
  {
    Console.WriteLine("CALCULADORA AVANSSADIÇIMA\n");
    Console.WriteLine("Digite o número inicial");
    double numeroTotal = double.Parse(Console.ReadLine()!);
    total = numeroTotal;
  }

  public void Soma()
  {
    Console.Clear();
    Console.WriteLine($"Digite um número para efetuar a soma. Total = {total}");
    double numero = double.Parse(Console.ReadLine()!);
    total += numero;
    Console.WriteLine($"\nNovo total = {total}");
  }

  public void Subtracao()
  {
    Console.Clear();
    Console.WriteLine($"Digite um número para efetuar a subtração. Total = {total}");
    double numero = double.Parse(Console.ReadLine()!);
    total -= numero;
    Console.WriteLine($"\nNovo total = {total}");
  }

  public void Divisao()
  {
    Console.Clear();
    Console.WriteLine($"Digite um número para efetuar a divisão. Total = {total}");
    double numero = double.Parse(Console.ReadLine()!);
    total /= numero;
    Console.WriteLine($"\nNovo total = {total}");
  }

  public void Multiplicacao()
  {
    Console.Clear();
    Console.WriteLine($"Digite um número para efetuar a multiplicação. Total = {total}");
    double numero = double.Parse(Console.ReadLine()!);
    total *= numero;
    Console.WriteLine($"\nNovo total = {total}");
  }
}