/*

using System.Linq.Expressions;
try
{
    Console.WriteLine("Informe seu nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Informe seu salário: ");
    decimal salario = decimal.Parse(Console.ReadLine());
    decimal novoSalario = decimal.Parse(Console.ReadLine());

    // Console.WriteLine("Bem-vinda {0}, o salário de {1}", nome, salarioStr);
    Console.WriteLine($"Bem-vinda {nome}, seu salário é de {salario:C2}");

    // informe o valor do IRPF a ser pago de acordo com o salário informado. utilize a tabela real de desconto de IRPF

    if (salario <= 2259.20m)
    {
        Console.WriteLine($"Você está isento de taxa");
    }
    else if (salario >= 2259.21m && salario <= 2826.65m)
    {
         novoSalario = salario - (salario * 0.075m - 169.21m);
        Console.WriteLine($"Seu sálário com o desconto é de {novoSalario:C2}");
    }

    else if (salario >= 2826.66m && salario <= 3751.05m)
    {
         novoSalario = salario - (salario * 0.15m - 381.44m);
        Console.WriteLine($"Seu salário com o desconto é de {novoSalario:C2}");
    }

    else if (salario >= 3751.06m && salario <= 4664.68m)
    {
         novoSalario = salario - (salario * 0.225m - 662.67m);
        Console.WriteLine($"Seu salário com o desconto é de {novoSalario:C2}");
    }

    else
    {
         novoSalario = salario - (salario * 0.275m - 896m);
        Console.WriteLine($"Seu salário com o desconto é de {novoSalario:C2}");
    }

}
catch (FormatException) //erro específico
{
    Console.WriteLine("O salário deve ser informado em formato numérico.");
}

catch (Exception e) //qualquer tipo de erro
{
    Console.WriteLine("Ocorreu um erro. Informe ao suporte técnico");
    Console.WriteLine(e.StackTrace);


*/

using ConceitosBasicos.uteis;

SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();
int resultado = somaDoisNumeros.Somar(20, 22);
Console.WriteLine(resultado);

int milimetros = MetrosMilimetros.Converter(2);                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         