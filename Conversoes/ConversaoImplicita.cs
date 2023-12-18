// conversão implicita é usada com passagem de dados, quando uma variavel de menor bits é passada para uma com maior bits ou equivalentes.
// double numeroDouble = 24.5;
// int numeroInt = 10;

// double ocupa 64 bits, podendo armazenar uma váriavel do tipo int, que ocupa 32 bits. 
// numeroDouble = numeroInt;

// se eu tentar o contrário, dará erro, pois é impossivel um tipo int (32 bits) armazenar uma variável do tipo double (64 bits). Para isso é necessário efetuar a conversão explicita.
// numeroInt = numeroDouble;

// essa conversão só é feita com tipos compativeis, é impossivel converter uma variavel do tipo string no tipo double e vice versa. 
// string menor = "menor";
// numeroDouble = menor;
// menor = numeroDouble;