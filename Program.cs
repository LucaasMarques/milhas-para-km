
Console.WriteLine("milhas para km");      // saida
Console.Write("informe o valor em milhas:");
string entrada = Console.ReadLine()!;
double milhas = Convert.ToDouble (entrada);
double resultado = milhas * 1.609;
Console.WriteLine($"{milhas} milhas em km --> {resultado}");





