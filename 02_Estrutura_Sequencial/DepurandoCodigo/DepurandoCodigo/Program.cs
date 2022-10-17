double salario;
double aumento = 1.10;
double bonusJantarRomantico = 500;
double antecipacaoFerias = 1.3;

Console.WriteLine("Qual seu salário?");
salario = double.Parse(Console.ReadLine());

// Adicionado um aumento de 10%
salario = salario * aumento;

// Adicionando um bônus de jantar romântico
salario = salario + bonusJantarRomantico;

// Antecipando férias
salario = salario * antecipacaoFerias;

Console.WriteLine("Salário:");
Console.WriteLine(salario);
