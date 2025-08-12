Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Informe seu salário: ");
decimal salarioStr = decimal.Parse (Console.ReadLine());

// Console.WriteLine("Bem-vinda {0}, o salário de {1}", nome, salarioStr);
Console.WriteLine($"Bem-vinda {nome}, seu salário é de {salarioStr}");