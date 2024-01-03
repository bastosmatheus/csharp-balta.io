// no C# o tipo primitivo string tem alguns métodos para fazer comparação.

// string corinthians = "o Sport Club Corinthians Paulista vai ganhar pelo menos um titulo em 2024.";

// contains => verifica se determinada palavra existe dentro de uma string, se existir retorna true.
// Console.WriteLine(corinthians.Contains("Corinthians"));

// // ignorando o case sensitive do método Contains.
// Console.WriteLine(corinthians.Contains("CORINTHians", StringComparison.OrdinalIgnoreCase));

// compareto => compara toda a string e retorna um número, 0 (true) e 1 (false). 
// // o método CompareTo não ignora o case sensitive em momento nenhum.
// Console.WriteLine(corinthians.CompareTo("o Sport Club Corinthians Paulista vai ganhar pelo menos um titulo em 2024."));

// startswith => compara o inicio de uma string, se for igual, retorna true.
// Console.WriteLine(corinthians.StartsWith("o Sport Club Corinthians Paulista"));

// // ignorando o case sensitive do método StartsWith.
// Console.WriteLine(corinthians.StartsWith("o SPORT CLUB CORINTHIANS PAULISTA", StringComparison.OrdinalIgnoreCase));

// endswith => compara o fim de uma string, se for igual, retorna true.
// Console.WriteLine(corinthians.EndsWith("2024."));

// // ignorando o case sensitive do método StartsWith.
// Console.WriteLine(corinthians.EndsWith("EM 2024.", StringComparison.OrdinalIgnoreCase));

// equals => compara toda a string, se for igual, retorna true.
// Console.WriteLine(corinthians.Equals("o Sport Club Corinthians Paulista vai ganhar pelo menos um titulo em 2024."));

// // ignorando o case sensitive do método Equals.
// Console.WriteLine(corinthians.Equals("o Sport Club Corinthians Paulista vai ganhar pelo menos um TITULO EM 2024.", StringComparison.OrdinalIgnoreCase));