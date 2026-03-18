// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Digite o seu nome");
string nome = Console.ReadLine();

Console.WriteLine($"Seu nome tem {nome.Length} caracteres");

Console.WriteLine("Digite a data de nascimento");
DateTime dtNascimento = DateTime.Parse(Console.ReadLine());

int diasVividos = DateTime.Now.Subtract(dtNascimento).Days;

Console.WriteLine("Dias vividos: " + diasVividos);
Console.ReadKey();