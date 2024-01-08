// exceções são geradas quando o sistema tem algum tipo de erro, é comum dentro da comunicação, inclusive pode ser tratada e ter a mensagem de erro customizada.

// o try/catch é uma forma de tratamento de exceções, primeiro o compilador tenta executar o código dentro do try, se acontecer algum erro, cai no catch e acontece o tratamento.
// é possivel e até recomendado ter mais de 1 catch para as exceções. 

try
{
  int[] array = new int[2] { 0, 1 };

  // for (int i = 0; i < 10; i++)
  // {
  //   Console.WriteLine(array[i]);
  // }

  Validando("");
}
catch (IndexOutOfRangeException ex)
{
  Console.WriteLine("O for excedeu o limite do array.");
  Console.WriteLine(ex.Message);
}
catch (ArgumentNullException ex)
{
  Console.WriteLine("O texto não pode ser vazio.");
  Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
  Console.WriteLine("Alguma coisa deu errado.");
  Console.WriteLine(ex.Message);
}

// as exceções são boas para validação dos dados
void Validando(string texto)
{
  if (string.IsNullOrEmpty(texto))
  {
    throw new ArgumentNullException();
  }
}