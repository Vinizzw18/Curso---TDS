using Microsoft.VisualBasic;
using static System.Console;

/*

string[] nomes = { "Vini", "Beto", "Parra", "Lucas" };
foreach (string pessoas in nomes)

{
    WriteLine("{0}", pessoas);
}

*/

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*

int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

foreach (int item in array)
{
    WriteLine(item);
}

*/

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*

int n1;
int resultado;

WriteLine("Digite um numero para gerar sua tabuada: ");
n1 = Convert.ToInt32(ReadLine());

for (int i = 1; i <= 10; i++)
{
    resultado = n1 * i;
    Write($"\n{n1} X {i} = {resultado}");
}

*/

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/*

string[] estados = { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins", "Distrito Federal" };

foreach (string nomes in estados)
{
    WriteLine(nomes);
}

*/

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//LISTA EXERCICIO--------------------------------------------------------

//1-----------------------------------------

/*

double n1;
double n2;

WriteLine("Digite o primeiro numero: ");
n1 = Convert.ToDouble(ReadLine());
WriteLine("Digite o segundo numero: ");
n2 = Convert.ToDouble(ReadLine());

if (n1 > n2)
{
    WriteLine($"O numero maior é o {n1}");
}
else if (n2 > n1)
{
    WriteLine($"O numero maior é o {n2}");
}
else
{
    WriteLine($"Os Numeros são iguais");
}


*/


//2-----------------------------------------

/*

double num1;
double num2;
double num3;

WriteLine("Insira 3 numeros: ");
num1 = Convert.ToDouble(ReadLine());
num2 = Convert.ToDouble(ReadLine());
num3 = Convert.ToDouble(ReadLine());

if (num1 > num2 && num1 > num3)
{
    if (num2 > num3)
    {
        WriteLine($"O {num1} é o maior e o {num3} é o menor");
    }
    else
    {
        WriteLine($"O {num1} é o maior e o {num2} é o menor");
    }
}
else if (num2 > num1 && num2 > num3)
{
    if (num1 > num3)
    {
        WriteLine($"O {num2} é o maior e o {num3} é o menor");
    }
    else
    {
        WriteLine($"O {num2} é o maior e o {num1} é o menor");
    }
}
else if (num3 > num1 && num3 > num2)
{
    if (num1 > num2)
    {
        WriteLine($"O {num3} é o maior e o {num2} é o menor");
    }
    else
    {
        WriteLine($"O {num3} é o maior e o {num1} é o menor");
    }
}

*/ 

//3-----------------------------------------



double nota;
double nota2;
double media;

WriteLine("Digite a 1° nota do aluno: ");
nota = Convert.ToDouble(ReadLine());
WriteLine("Digite a 2° nota do aluno: ");
nota2 = Convert.ToDouble(ReadLine());
media = (nota + nota2) / 2;

if (media >= 7)
{
    WriteLine($"Aluno Aprovado com a media de: {media}");
}
else if (media == 10)
{
    WriteLine($"Aluno Aprovado com Distinção com a media de: {media}");
}
else if (media <= 7)
{
    WriteLine($"Aluno Reprovado com a media de: {media}");
}
else
{
    WriteLine("Media Invalida");
}



//4-----------------------------------------

/*

double p1;
double p2;
double p3;

WriteLine("Insira o Valor(R$) dos 3 Produtos: ");
p1 = Convert.ToDouble(ReadLine());
p2 = Convert.ToDouble(ReadLine());
p3 = Convert.ToDouble(ReadLine());

    if (p1 < p2 && p1 < p3)
    {
        WriteLine($"O R${p1} é o menor valor");
}
    else if (p2 < p1 && p2 < p3)
    {
        WriteLine($"O R${p2} é o menor valor");
}
    else if (p3 < p1 && p3 < p2)
    {
    WriteLine($"O R${p3} é o menor valor");
}

*/


//5-----------------------------------------

/*

int ParImp;
WriteLine("Digite um numero para saber se é par ou ímpar: ");
ParImp = Convert.ToInt32(ReadLine());

if (ParImp % 2 == 0)
{
    WriteLine($"O número {ParImp} é Par");
}
else
{
    WriteLine($"O número {ParImp} é Ímpar");
}


*/


//6-----------------------------------------

/*

int id;
WriteLine("Para doar sangue voce precisa ter de 18 a 67 anos. Insira sua idade: ");
id = Convert.ToInt32(ReadLine());

if (id >= 18 && id <= 67)
{
    WriteLine($"Com a idade de {id} Anos, é permitido doar sangue!");
}
else
{
    WriteLine($"{id} Anos não é permitido doar sangue!");
}

*/



//7-----------------------------------------

/*

int var1 = 10;
int var2 = 20;

Write($"\nO primeiro valor de A: {var1}");
Write($"\nO primeiro valor de B: {var2}");

int varC = var1;
var1 = var2;
var2 = varC;

Write($"\n\nO segundo valor de A: {var1}");
Write($"\nO segundo valor de B: {var2}");

*/

//8-----------------------------------------

/*

int NumCarVen;
double ComssFix;
double vlTotalVendas;
double salarioFixo;
double TaxaVv = 0.05;
double salarioFinal;
double TaxaVendaMes;


WriteLine("Numeros de carros vendidos no mês: ");
NumCarVen = Convert.ToInt32(ReadLine());


WriteLine("Valor Total das vendas no mês: ");
vlTotalVendas = Convert.ToDouble(ReadLine());


WriteLine("Salário Fixo: ");
salarioFixo = Convert.ToDouble(ReadLine());


WriteLine("Taxas de vendas no mês (%): ");
TaxaVendaMes = Convert.ToDouble(ReadLine());

double comissaoCarrosFinal = NumCarVen * TaxaVendaMes;
double comissaoTotalVendas = 0.05 * vlTotalVendas;
double SalarioTotal = comissaoCarrosFinal + comissaoTotalVendas + salarioFixo;
Write($"\nO salario final do vendedor é: R${SalarioTotal:F2}");


*/


//9-----------------------------------------

/*

double temp;
double transC;

WriteLine("Insira uma temperatura em (Fahrenheit) para converter F° para C°: ");
temp = Convert.ToDouble(ReadLine());

transC = (temp - 32) * 5 / 9;
WriteLine($"\nA temperatura {temp:F2} F° convertida para C° é: {transC:F2}C°");

*/


//10-----------------------------------------

/*

int VelForn;
double resultadoKMH;

WriteLine("Insira a velocidade em M/S para transformar Km/H: ");
VelForn = Convert.ToInt32(ReadLine());

resultadoKMH = VelForn * 3.6;
WriteLine($"\nA sua velocidade transformada para Km/H é: {resultadoKMH}Km/h");


*/