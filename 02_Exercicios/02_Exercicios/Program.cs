string carro;
string cidadeDestino;
int carroVelocidade;
int cidadeDistancia;
double tempoTotal;

carro = Console.ReadLine();
cidadeDestino = Console.ReadLine();
carroVelocidade = int.Parse(Console.ReadLine());
cidadeDistancia = int.Parse(Console.ReadLine());

tempoTotal = (double)cidadeDistancia / carroVelocidade;

Console.WriteLine(carro + " chegará em " + cidadeDestino + " em " + 
    tempoTotal + " horas.");

Console.ReadKey();