using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using static System.Console;

/*
string nome = "vinicius";
int idade = 17;
double salario = 20151.12;
WriteLine($"\nSuas informações são: \nNome - {nome}; \nIdade - {idade}; \nSalario - R$ {salario}");



int n1 = 0;
WriteLine("insira um valor de 0 a 10: ");
n1 = Convert.ToInt32(ReadLine());
if (n1 > 10)
{
    WriteLine($"\nNumero Invalido!");
    WriteLine($"\nO numero {n1} é maior do que 10");
    return;
}
if (n1 < 0)
{
    WriteLine($"\nNumero Invalido!");
    WriteLine($"\nO numero {n1} é menor do que 0");
    return;
}
else
{
    WriteLine($"\nNumero valido!");
    WriteLine($"\nO numero {n1} está dentro dos parametros!");
}
ReadKey();




string NomeProd = " ";
double ValorProd = 0, ValorDesc = 0, vcd = 0;
double rslt = 0;

ForegroundColor = ConsoleColor.Yellow;
WriteLine("Insira o Nome do Produto: ");
NomeProd = Convert.ToString(ReadLine());
WriteLine("Insira o Preço do Produto: ");
ValorProd = Convert.ToDouble(ReadLine());
WriteLine("Insira o Preço do Desconto que deseja aplicar: ");
ValorDesc = Convert.ToDouble(ReadLine());
vcd = ValorProd * (ValorDesc / 100);
rslt = ValorProd - vcd;
ResetColor();
WriteLine("====================================================================");
ForegroundColor = ConsoleColor.Green;
WriteLine($"\nO nome do seu produto é:{NomeProd}" +
    $"\nO preço do seu produto é: R${ValorProd}" +
    $"\nO desonto que deseja aplicar é de {ValorDesc}%" +
    $"\nO valor final foi: {rslt.ToString("F")}");
ResetColor();
WriteLine("====================================================================");


*/

/*
double n1 = 0;
double n2 = 0;
char operador = '+';
double resultado = 0;
WriteLine("Digite um numero para calcular: ");
n1 = Convert.ToDouble(ReadLine());
WriteLine("Digite a operação que deseja fazer");
operador = Convert.ToChar(ReadLine());
WriteLine("Digite outro numero para calcular: ");
n2 = Convert.ToDouble(ReadLine());



switch (operador)
    {

        case '+':
            resultado = n1 + n2;
            WriteLine($"\nO resultado da expressão é: {resultado}");
            break;
        case '-':
            resultado = n1 - n2;
            WriteLine($"\nO resultado da expressão é: {resultado}");
            break;
        case '*':
            resultado = n1 * n2;
            WriteLine($"\nO resultado da expressão é: {resultado}");
            break;
        case '/':
            resultado = n1 / n2;
            WriteLine($"\nO resultado da expressão é: {resultado}");
            break;
        default:
            WriteLine("Operador Invalido!");
            return;

    }
*/

/*================================================================================================
string mes = " ";
WriteLine("Digite um mês para saber quantos dias ele tem: ");
mes = ReadLine().ToUpper();

switch (mes)
{
    case "JANEIRO":
    case "MARÇO":
    case "MAIO":
    case "JULHO":
    case "AGOSTO":
    case "OUTUBRO":
    case "DEZEMBRO":
        WriteLine($"O mês {mes} tem 31 dias!");
        break;
    case "FEVEREIRO":
        WriteLine($"O mês {mes} tem 28 dias!");
        break;
    case "ABRIL":
    case "JUNHO":
    case "SETEMBRO":
    case "NOVEMBRO":
        WriteLine($"O mês {mes} tem 30 dias!");
        break;
    default:
        WriteLine("Mês Inválido!");
        WriteLine($"O Mês {mes} não existe");
        return;




}



===========================================================================*/




//LISTA EXERCICIO ##################################################################


// ---------1---------

/*
int n1 = 0;
WriteLine("Insira um numero para descobrir se é Par ou Impar: ");
n1 = Convert.ToInt32(ReadLine());
if (n1 % 2 == 0)
{
    WriteLine($"\nO Numero {n1} é Par");
}
else
{
    WriteLine($"\nO Numero {n1} é Impar");
}

*/

// ---------2---------

/*

int idd = 0;
WriteLine("Qual a idade da pessoa: ");
idd = Convert.ToInt32(ReadLine());

if (idd > 00 && idd <= 12)
{
    WriteLine($"Idade ({idd}) Definida como: Criança (0-12)");
    return;
}
if (idd >= 13 && idd <= 17)
{
    WriteLine($"Idade ({idd}) Definida como: Adolescente (13-17)");
    return;
}
if (idd >= 18 && idd <= 59)
{
    WriteLine($"Idade ({idd}) Definida como: Adulto (18-59)");
    return;
}
if (idd < 0)
{
    WriteLine($"Idade ({idd}) invalida!");
    return;
}
if (idd > 110)
{
    WriteLine($"Idade ({idd}) invalida!");
    return;
}
else
{
    WriteLine($"Idade ({idd}) Definida como: Idoso (60+)");
    return;
}


*/


// ---------3---------

/*

double num1 = 0;
double num2 = 0;
char operador = '+';
double resultado = 0;
WriteLine("Digite um numero para calcular: ");
num1 = Convert.ToDouble(ReadLine());
WriteLine("Digite a operação que deseja fazer(+, -, *, /)");
operador = Convert.ToChar(ReadLine());
WriteLine("Digite outro numero para calcular: ");
num2 = Convert.ToDouble(ReadLine());

if (operador == '+')
{
    ForegroundColor = ConsoleColor.Green;
    resultado = num1 + num2;
    WriteLine($"\nO resultado da operação {num1} + {num2} é: {resultado}");
    ResetColor();
}
else if (operador == '-')
{
    ForegroundColor = ConsoleColor.Green;
    resultado = num1 - num2;
    WriteLine($"\nO resultado da operação {num1} - {num2} é: {resultado}");
    ResetColor();
}
else if (operador == '*')
{
    ForegroundColor = ConsoleColor.Green;
    resultado = num1 * num2;
    WriteLine($"\nO resultado da operação {num1} x {num2} é: {resultado}");
    ResetColor();
}
else if (operador == '/')
{
    ForegroundColor = ConsoleColor.Green;   
    resultado = num1 / num2;
    WriteLine($"\nO resultado da operação {num1} / {num2} é: {resultado}");
    ResetColor();
}
else
{
    ForegroundColor = ConsoleColor.Red;
    WriteLine($"\nOperação Invalidada!");
    ResetColor();

}

*/


// ---------4---------

/*

int dia = 0;
WriteLine("Insira um numero de 1 a 7 (dias da semana): ");
dia = Convert.ToInt32(ReadLine());
if (dia > 7)
{
    ForegroundColor = ConsoleColor.Red;
    WriteLine($"\nNumero invalido!\nDia da semana: inexistente");
    ResetColor();
}
if (dia < 0)
{
    ForegroundColor = ConsoleColor.Red;
    WriteLine($"\nNumero invalido!\nDia da semana: inexistente");
    ResetColor();
}
else
{
    switch (dia)
    {
        case 1:
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"\nNumero válido!\nDia da semana: Domingo");
            ResetColor();
            break;
        case 2:
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"\nNumero válido!\nDia da semana: Segunda - Feira");
            ResetColor();
            break;
        case 3:
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"\nNumero válido!\nDia da semana: Terça - Feira");
            ResetColor();
            break;
        case 4:
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"\nNumero válido!\nDia da semana: Quarta - Feira");
            ResetColor();
            break;
        case 5:
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"\nNumero válido!\nDia da semana: Quinta - Feira");
            ResetColor();
            break;
        case 6:
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"\nNumero válido!\nDia da semana: Sexta - Feira");
            ResetColor();
            break;
        case 7:
            ForegroundColor = ConsoleColor.Green;
            WriteLine($"\nNumero válido!\nDia da semana: Sábado");
            ResetColor();
            break;

        default:
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Dia Inválido!");
            ResetColor();
            return;


    }
}



*/

// ---------5---------

/*

char VogCons = 'a';
WriteLine("Insira qualquer letra para descobrir se é vogal ou consoante: ");
VogCons = Convert.ToChar(ReadLine().ToUpper());
switch (VogCons)
{
    case 'A':
        ForegroundColor = ConsoleColor.Magenta;
        WriteLine($"\nA letra {VogCons} é uma Vogal!");
        ResetColor();
        break;
    case 'E':
        ForegroundColor = ConsoleColor.Magenta;
        WriteLine($"\nA letra {VogCons} é uma Vogal!");
        ResetColor();
        break;
    case 'I':
        ForegroundColor = ConsoleColor.Magenta;
        WriteLine($"\nA letra {VogCons} é uma Vogal!");
        ResetColor();
        break;
    case 'O':
        ForegroundColor = ConsoleColor.Magenta;
        WriteLine($"\nA letra {VogCons} é uma Vogal!");
        ResetColor();
        break;
    case 'U':
        ForegroundColor = ConsoleColor.Magenta;
        WriteLine($"\nA letra {VogCons} é uma Vogal!");
        ResetColor();
        break;
    default:
        ForegroundColor = ConsoleColor.Blue;
        WriteLine($"\nA letra {VogCons} é uma consoante!");
        ResetColor();
        return;

}

*/



// ---------6---------