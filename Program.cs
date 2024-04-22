using BibliotecaDiária;
Console.ForegroundColor = ConsoleColor.White;   

Console.Write("Informe a data de entrada: ");
DateTime DataEntrada = Convert.ToDateTime(Console.ReadLine());

Console.Write("Inforrme a data de saida: ");
DateTime DataSaida = Convert.ToDateTime(Console.ReadLine());

Console.Write("Informe o valor da diária:R$");
double valorDiaria = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("diferença formato DateTime:" + Ferramentas.CalcularDiária(valorDiaria, DataEntrada, DataSaida));
string data = Convert.ToString(Ferramentas.CalcularDiária(valorDiaria, DataEntrada, DataSaida).TotalDays);
double valorReal = valorDiaria * Convert.ToDouble(data);

Console.WriteLine("Diferença de dias quebrado:" + data);
Console.WriteLine("O valor a ser pego pelo seu tempo de trabalho sera de:" + valorReal.ToString("C2"));
