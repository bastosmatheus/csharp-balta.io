// // não existe alguma classe/struct que defina moedas, a criação de uma váriavel é feita na mão, geralmente trabalhando com decimal.

// using System.Globalization;

// decimal valorSalario = 1025m;

// // o cultureinfo serve também para a formatação de valores.
// // o "C" formata o valor já com a moeda do pais definido na cultureinfo.
// // R$ 1.025,00
// Console.WriteLine(valorSalario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

// // 1.025,00 €
// Console.WriteLine(valorSalario.ToString("C", CultureInfo.CreateSpecificCulture("de-DE")));

// // o "N" pega apenas o valor, não formata com a moeda.

// // 1.025,00
// Console.WriteLine(valorSalario.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));

// Console.WriteLine(Math.Round(valorSalario));

// List<string> array = new List<string>() { "matriz" };
// foreach (var item in array)
// {
//   Console.WriteLine(item);
// }