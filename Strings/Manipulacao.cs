// no C# o tipo primitivo string tem alguns métodos que servem para fazer a manipulação e/ou reatribuição de valores.

// string texto = "o Corinthians é gigante!";

// // replace => usado para trocar caracter/palavras de uma string, tem como parâmetro a caracter/palavra que vai ser substituida e a nova caracter/palavra.
// Console.WriteLine(texto.Replace("gigante", "COLOSSAL!!!!"));

// // substitui todos os "a" para "COLOSSAL!!!!".
// Console.WriteLine(texto.Replace(" ", "COLOSSAL!!!!"));

// // split => usado para separar as palavras de uma string, a partir de um caracter, tem como parâmetro o caracter separador. Com a separação, é criado um array de strings. 
// string[] arrayStrings = texto.Split(" ");

// foreach (var palavra in arrayStrings)
// {
//   Console.WriteLine(palavra);
// }

// // substring => usado para criar uma nova string apenas com os caracteres passados nos parametros, tem como parâmetro o index inicial e a quantidade de caracteres que o usuario deseja ter.
// Console.WriteLine(texto.Substring(0, texto.LastIndexOf("a")));