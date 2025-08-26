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


/*
  
SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();
int resultado = somaDoisNumeros.Somar(20, 22);
Console.WriteLine(resultado);

int milimetros = MetrosMilimetros.Converter(2);  
*/

using ConceitosBasicos.uteis;

Console.WriteLine("o que vc deseja fazer: ");
Console.WriteLine("1 - somar dois números \n2 - converter de metros para milímetros \n3 - calcular aumento \n4 - calcular desconto");
int escolha = int.Parse(Console.ReadLine());

switch (escolha){
    case 1:
        SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();
        Console.WriteLine("número 1: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("número 2: ");
        int numero2 = int.Parse(Console.ReadLine());
        int resultado = somaDoisNumeros.Somar(numero1, numero2);
        Console.WriteLine($"o resultado da soma é de {resultado}");
        break;

     case 2:
        MetrosMilimetros metrosMilimetros = new MetrosMilimetros();
        Console.WriteLine("metros a serem convertidos: ");
        int metros = int.Parse(Console.ReadLine());
        int milimetros = MetrosMilimetros.Converter(metros);
        Console.WriteLine($"milimetros: {milimetros}");
        break;

     case 3:
        CalculaAumento calculaAumento = new CalculaAumento();

        Console.WriteLine("salário: ");
        decimal salario = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("aumento: ");
        float aumento = float.Parse(Console.ReadLine());

        decimal novoSalario = calculaAumento.Calcular(salario, aumento) + salario;
        decimal valorAumento = calculaAumento.Calcular(salario, aumento);

        Console.WriteLine($"valor do antigo salario: {salario:c2}, o aumento de {valorAumento:f2}\nvalor do novo salario: {novoSalario:c2}");
        break;

    case 4:
        CalculaDesconto calculaDesconto = new CalculaDesconto();
        Console.WriteLine("valor da mercadoria: ");
        decimal mercadoria = decimal.Parse(Console.ReadLine());

        Console.WriteLine("desconto: ");
        float desconto = float.Parse(Console.ReadLine());

        decimal valorDesconto = calculaDesconto.Descontar(mercadoria, desconto);
        decimal novoValor = mercadoria - calculaDesconto.Descontar(mercadoria, desconto);

        Console.WriteLine($"valor antigo: {mercadoria} \nvalor do desconto: {valorDesconto} \nvalor com o desconto: {novoValor}");
        break;
    
}


