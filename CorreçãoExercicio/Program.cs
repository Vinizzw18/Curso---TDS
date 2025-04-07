
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
    if (num2 != 0)
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

/*


double nota1 = 0;
double nota2 = 0;
double nota3 = 0;
double media = 0;

WriteLine("Digite a 1° nota do aluno(a): ");
nota1 = Convert.ToDouble(ReadLine());
WriteLine("Digite a 2° nota do aluno(a): ");
nota2 = Convert.ToDouble(ReadLine());
WriteLine("Digite a 3° nota do aluno(a): ");
nota3 = Convert.ToDouble(ReadLine());

media = nota1 + nota2 + nota3;
media = media / 3;

if (media >= 70)
{
    ForegroundColor = ConsoleColor.Green;
    WriteLine($"\nAluno Aprovado! com a média de: {media:F2}");
    ResetColor();
}
else
{
    ForegroundColor = ConsoleColor.Red;
    WriteLine($"\nAluno Reprovado! com a média de: {media:F2}");
    ResetColor();
}


*/


// ---------7--------- FALTA RESOLVER


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////88888888888888888888888888888888888888888888888


decimal ValorTotal = 87.00m;
decimal valorCD = 0;
decimal desconto = 0;

WriteLine("Valor Total da compra: ");
ValorTotal = Convert.ToDecimal(ReadLine());
desconto = 0;

if (ValorTotal <= 50)
{
    WriteLine("Valor menor que R$50,00! Sem desconto");
}
else if (ValorTotal > 50 && ValorTotal < 100)
{
    desconto = 0.05m;
    valorCD = ValorTotal - (ValorTotal * desconto);
    WriteLine($"Valor {ValorTotal} acima que R$50,00 e abaixo R$100,00! 5% de desconto: {valorCD:F2}");
}
else
{
    desconto = 0.10m;
    valorCD = ValorTotal - (ValorTotal * desconto);
    WriteLine($"Valor {ValorTotal} acima que R$100,00! 10% de desconto: {valorCD:F2}");
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////88888888888888888888888888888888888888888888888
///



// ---------8---------

/*

int ano = 0;
WriteLine("Informe um ano para descobrir se é bissexto ou não: ");
ano = Convert.ToInt32(ReadLine());


if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
{
    ForegroundColor = ConsoleColor.Green;
    WriteLine($"{ano} é um ano bissexto.");
    ResetColor();
}
else
{
    ForegroundColor = ConsoleColor.Red;
    WriteLine($"{ano} não é um ano bissexto.");
    ResetColor();
}

*/


// ---------9--------- / JA FEITO ANTES /

/*
 * 
 * 
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



// ---------10---------

/*

int alerta = 0;
WriteLine("Digite um número de alerta de 1 a 5: ");
alerta = Convert.ToInt32(ReadLine());

switch(alerta)
{
   case 1:
        ForegroundColor = ConsoleColor.Green;
        WriteLine("\n1: Nível de alerta baixo!");
        ResetColor();
        break;
   case 2:
        ForegroundColor = ConsoleColor.DarkGreen;
        WriteLine("\n1: Nível de alerta moderado!");
        ResetColor();
        break;
   case 3:
        ForegroundColor = ConsoleColor.Yellow;
        WriteLine("\n1: Nível de alerta elevado!");
        ResetColor();
        break;
   case 4:
        ForegroundColor = ConsoleColor.DarkRed;
        WriteLine("\n1: Nível de alerta crítico!");
        ResetColor();
        break;
   case 5:
        ForegroundColor = ConsoleColor.Red;
        WriteLine("\nEMERGÊNCIA!");
        ResetColor();
        break;
   default:
        WriteLine("Nível Inválido!");
        break;
}

*/


// ---------11---------


/*

int var1 = 0;
int var2 = 0;
int var3 = 0;


WriteLine("Insira 3 numeros e descubra qual é o maior deles: ");
WriteLine("Primeiro Numero: ");
var1 = Convert.ToInt32(ReadLine());
WriteLine("Segundo Numero: ");
var2 = Convert.ToInt32(ReadLine());
WriteLine("Terceiro Numero: ");
var3 = Convert.ToInt32(ReadLine());

if  (var1 > var2)
{
    if (var1 > var3)
    {
        ForegroundColor = ConsoleColor.Green;
        WriteLine($"\nO numero maior é o 1°: {var1}");
        ResetColor();
    }
}
else if (var2 > var1)
{
    if (var2 > var3)
    {
        ForegroundColor = ConsoleColor.Green;
        WriteLine($"\nO numero maior é o 2°: {var2}");
        ResetColor();
    }
}
else if (var3 > var1)
{
    if (var3 > var2)
    {
        ForegroundColor = ConsoleColor.Green;
        WriteLine($"\nO numero maior é o 3°: {var3}");
        ResetColor();
    }
}
else
{
    ForegroundColor = ConsoleColor.Yellow;
    WriteLine("\nOs números são iguais.");
    ResetColor();
}




*/


// ---------12---------

/*

int lado1 = 0;
int lado2 = 0; 
int lado3 = 0;
WriteLine("Insira o valor dos lados de um triangulo: ");
WriteLine("Valor 1° Lado: ");
lado1 = Convert.ToInt32(Console.ReadLine());
WriteLine("Valor 2° Lado: ");
lado2 = Convert.ToInt32(Console.ReadLine());
WriteLine("Valor 3° Lado: ");
lado3 = Convert.ToInt32(Console.ReadLine());


if ((lado1 + lado2) > lado3)
{
    ForegroundColor = ConsoleColor.Green;
    WriteLine("Triângulo Válido!");
    ResetColor();
}
else
{
    ForegroundColor = ConsoleColor.Red;
    WriteLine("Triângulo Inválido!");
    ResetColor();
}

*/


// ---------13--------- FALTA RESOLVER


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////88888888888888888888888888888888888888888888888
/*

double notaAluno = 0;
WriteLine("Insira a nota do Aluno(a): ");
notaAluno = Convert.ToDouble(ReadLine());

switch (notaAluno)
{
  
}
*/

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////88888888888888888888888888888888888888888888888

// ---------14---------

/*

int Number1 = 0;
int Number2 = 0;

int result = 0;

WriteLine("Insira 2 números Aleatórios");
WriteLine("Número 1: ");
Number1 = Convert.ToInt32(Console.ReadLine());
WriteLine("Número 2: ");
Number2 = Convert.ToInt32(Console.ReadLine());

if (Number1 % 2 == 0 && Number2 % 2 == 0)
{
    result = Number1 + Number2;
    ForegroundColor = ConsoleColor.Green;
    WriteLine($"\nOs dois numeros são Pares! A soma deles é: {result}");
    ResetColor();
}
else if (Number1 % 2 == 1 && Number2 % 2 == 1)
{
    result = Number1 * Number2;
    ForegroundColor = ConsoleColor.Green;
    WriteLine($"\nOs dois numeros são Impares! A multiplicação deles é: {result}");
    ResetColor();
}
else if (Number1 > Number2)
{
    if (Number1 % 2 == 0 && Number2 % 2 == 1)
    {
        result = Number1 - Number2;
        ForegroundColor = ConsoleColor.Green;
        WriteLine($"\nO 1° numero é Par, e o 2° é impar! A subtração deles é: {result}");
        ResetColor();
    }
}
else if (Number2 > Number1)
{
    if (Number2 % 2 == 0 && Number1 % 2 == 1)
    {
        result = Number2 - Number1;
        ForegroundColor = ConsoleColor.Green;
        WriteLine($"\nO 1° numero é Impar, e o 2° é par! A subtração deles é: {result}");
        ResetColor();
    }
}


*/




// ---------15---------
/*
int escolha1 = 0;
int escolha2 = 0;
int escolha3 = 0;
int escolhaUsuario = 0;

WriteLine("\n==========MENU==========");
WriteLine("\nOpção 1: Soma");
WriteLine("\nOpção 2: Subtração");
WriteLine("\nOpção 3: Sair");
escolhaUsuario = Convert.ToInt32(ReadLine());

if
    */

