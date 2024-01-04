// // datetime é um struct que cria datas e fornece métodos para a manipulação das datas.

// // instanciando o datetime, é possivel passar dia, mês, ano, hora, minuto e segundo.
using System.Globalization;

DateTime dateTime = new DateTime(2003, 12, 11);

// // datetime sem instanciar, apenas como um struct e usando o método Now, para saber o horário de agora.
Console.WriteLine(DateTime.Now);

// // ambos conseguem fracionar a data e horário com métodos do próprio DateTime.
Console.WriteLine(dateTime.Day);
Console.WriteLine(dateTime.Month);
Console.WriteLine(dateTime.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

// // formatando as datas
Console.WriteLine(String.Format("{0:yyyy/MM/dd}", dateTime));
Console.WriteLine(String.Format("{0:yyyy - MM - dd}", DateTime.Now));
Console.WriteLine(dateTime.ToString("D"));
Console.WriteLine(DateTime.Now.ToString("f"));
Console.WriteLine(dateTime.ToString("s"));
Console.WriteLine(DateTime.Now.ToString("R"));

// // formatando as datas usando o cultureinfo, que serve para definir um idioma.
var pt = new CultureInfo("pt-br");
var en = new CultureInfo("en");
var de = new CultureInfo("de-DE");
Console.WriteLine(DateTime.Now.ToString("R", pt));
Console.WriteLine(dateTime.ToString("yyyy/MM/dd", de));
Console.WriteLine(dateTime.ToString("D", en));

// // adicionando valores nas datas
Console.WriteLine(DateTime.Now.AddDays(5));

Console.WriteLine(dateTime.AddDays(2));

// // caso acabe os dias no mês atual, o método "vira" o mês e continua calculando.
Console.WriteLine(DateTime.Now.AddDays(-30));

// // caso acabe os meses no ano atual, o método "vira" o ano e continua calculando.
Console.WriteLine(dateTime.AddMonths(12));

// // caso acabe as horas do dia atual, o método "vira" o dia e continua calculando.
Console.WriteLine(DateTime.Now.AddHours(10));