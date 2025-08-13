Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Informe seu salário: ");
decimal salario = decimal.Parse (Console.ReadLine());

// Console.WriteLine("Bem-vinda {0}, o salário de {1}", nome, salarioStr);
Console.WriteLine($"Bem-vinda {nome}, seu salário é de {salario:C2}");

// informe o valor do IRPF a ser pago de acordo com o salário informado. utilize a tabela real de desconto de IRPF

if (salario <= 2259.20m)
{
    Console.WriteLine($"Você está isento de taxa");
}
else if  (salario >= 2259.21m &&  salario <= 2826.65m)
{
    decimal novoSalario = salario - (salario * 0.075m);
    Console.WriteLine($"Seu sálário com o desconto é de {novoSalario:C2}");
}

else if (salario >= 2826.66m && salario <= 3751.05m)
{
    decimal novoSalario = salario - (salario * 0.15m);
    Console.WriteLine($"Seu salário com o desconto é de {novoSalario:C2}");
}

else if (salario >= 3751.06m && salario <= 4664.68m)
{
    decimal novoSalario = salario - (salario * 0.225m);
    Console.WriteLine($"Seu salário com o desconto é de {novoSalario:C2}");
}

else
{
    decimal novoSalario = salario - (salario * 0.275m);
    Console.WriteLine($"Seu salário com o desconto é de {novoSalario:C2}");
}
