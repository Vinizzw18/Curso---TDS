
using System.Runtime.Serialization;
using System.Xml.Serialization;
using static System.Console;
using static System.Convert;

/*

List<string> nomesDig = new List<string>(10);


for (int i = 0; i < 10; i++)
{
    WriteLine($"Digite o {i + 1}° nome: ");
    nomesDig.Add(ReadLine());
}
Clear();

foreach(string item in nomesDig)
{
    WriteLine(item);
}

WriteLine($"Primeiro nome: {nomesDig[0]}");
WriteLine($"Ultimo nome: {nomesDig[9]}");

*/


//-----------------------------1-----------------------------(RESOLVIDO - CORRETO!)

/*

List<string> nomes = new List<string>();
	List<int> idades = new List<int>();

	for (int i = 0; i < 10; i++)
	{
		Write($"Digite o nome do {i + 1}º estudante: ");
		nomes.Add(ReadLine());

		Write($"Digite a idade do {i + 1}º estudante: ");
		idades.Add(int.Parse(ReadLine()));
	}


	List<(string nome, int idade)> estudantes = nomes.Zip(idades, (nome, idade) => (nome, idade)).ToList();


	estudantes.Sort((x, y) => x.idade.CompareTo(y.idade));


	(string nomeMaisNovo, int idadeMaisNovo) = estudantes.First();
	(string nomeMaisVelho, int idadeMaisVelho) = estudantes.Last();


	WriteLine($"\nEstudante mais novo: {nomeMaisNovo} ({idadeMaisNovo} anos)");
	WriteLine($"Estudante mais velho: {nomeMaisVelho} ({idadeMaisVelho} anos)");

	WriteLine("\nLista de estudantes ordenada por idade:");
	foreach ((string nome, int idade) estudante in estudantes)
	{
		WriteLine($"{estudante.nome} ({estudante.idade} anos)");
	}
*/




//-----------------------------2-----------------------------(RESOLVIDO - CORRETO!)

/*

List<string> nomes = new List<string>();
		List<double> notas = new List<double>();
	
		WriteLine("Digite os nomes e notas de 10 alunos da turma TDS:");
		for (int i = 0; i < 10; i++)
		{
			Write($"Nome do {i + 1}º aluno: ");
			nomes.Add(ReadLine());

			Write($"Nota do {i + 1}º aluno: ");
			notas.Add(double.Parse(ReadLine()));
		}

		double mediaTurma = CalcularMedia(notas);

		WriteLine($"\nMédia das notas da turma: {mediaTurma:F2}"); // Formata para 2 casas decimais

		WriteLine("\nLista de alunos e suas notas:");
		for (int i = 0; i < nomes.Count; i++)
		{
			WriteLine($"{nomes[i]}: {notas[i]:F2}"); // Formata a nota para 2 casas decimais
		}

*/


//-----------------------------3-----------------------------(RESOLVIDO - CORRETO!)

/*

List<int> idadeModeloLista = new List<int>();
List<string> NomeModeloLista = new List<string>();

for (int i = 0; i < 4; i++)
{
    WriteLine($"Digite o nome da {i + 1}° Modelo: ");
    string NomeModelo = ReadLine();
    NomeModeloLista.Add(NomeModelo);

    WriteLine($"Idade da Modelo {NomeModelo}: ");
    int IddModelo = ToInt32(ReadLine());
    idadeModeloLista.Add(IddModelo);
}

List<string> CandidatasCertas = new List<string>(); 

for (int i = 0;i < idadeModeloLista.Count;i++)
{ 
    if (idadeModeloLista[i]>= 18 && idadeModeloLista[i] <= 20)
    {
        CandidatasCertas.Add(NomeModeloLista[i]);
    }

}
Clear();

WriteLine("\nModelos Aptas: ");

foreach (string modelos in CandidatasCertas)
{
    WriteLine($"{modelos}");
}


*/



//-----------------------------4-----------------------------(RESOLVIDO - CORRETO!)

/*

List<int> valoresLista1 = new List<int>(20);
List<int> valoresLista2 = new List<int>(20);

for (int i = 0; i < 20; i++)
{
    WriteLine($"Dê o {i + 1}° Valor da Primeira Lista: ");
    int ValorDig1 = ToInt32(ReadLine());
    valoresLista1.Add(ValorDig1);
    WriteLine($"Dê outro valor para a Segunda Lista: ");
    int ValorDig2 = ToInt32(ReadLine());
    valoresLista2.Add(ValorDig2); 
}

List<int> ValoresIguais = valoresLista1.Intersect(valoresLista2).ToList();

if (ValoresIguais.Count > 0)
{
    WriteLine("\nValores em comum das listas: ");
    foreach (int item in ValoresIguais)
    {
        WriteLine(item);
    }
}

else
{ 
    WriteLine("Não há valores iguais em comum!");
}


*/



//-----------------------------5-----------------------------(RESOLVIDO - CORRETO!)

/*

List<string> AlunosLista = new List<string>();
List<double> NotasAlunoLista = new List<double>();


for (int i = 0; i < 15; i++)
{
    WriteLine($"Nome do {i + 1}° Aluno(a): ");
    string AlunoDig = ReadLine();
    AlunosLista.Add(AlunoDig);
    WriteLine($"Nota do(a) {AlunoDig}: ");
    double notasDig = ToInt32(ReadLine());
    NotasAlunoLista.Add(notasDig);
}
Clear();

double somaNotas = 0;
int alunosAcia70 = 0;
bool algumAcima50 = false;

for (int i = 0;i < NotasAlunoLista.Count; i++)
{
    somaNotas += NotasAlunoLista[i];

        if (NotasAlunoLista[i] > 70)
    {
        alunosAcia70++;
    }
        if (NotasAlunoLista[i] > 50)
    {
        algumAcima50 = true;
    }
                
}

double media = somaNotas / NotasAlunoLista.Count;
WriteLine($"Média das notas: {media}");

WriteLine($"Quantidade de alunos com nota acima de 70: {alunosAcia70}");

if (!algumAcima50)
{
    WriteLine("Não há nenhum aluno com nota acima de 50.");
}


*/



//-----------------------------6-----------------------------(RESOLVIDO - CORRETO!)


/*

List<double> TempoVoltasLista = new List<double>();

for (int i = 0; i < 12; i++)
{
    WriteLine($"Digite o numero da {i + 1}° volta: ");
    double tempoDigitado = ToDouble(ReadLine());
    TempoVoltasLista.Add(tempoDigitado);
}

double MenorTempo = TempoVoltasLista.Min();
int VoltaMenorTempo = TempoVoltasLista.IndexOf(MenorTempo) + 1;
double TempoMedio = TempoVoltasLista.Average();

Clear();

WriteLine($"\nTempo menor: {MenorTempo}");
WriteLine($"Volta do menor tempo: {VoltaMenorTempo}");
WriteLine($"Tempo Medio: {TempoMedio:F2}");


*/


//-----------------------------7-----------------------------(RESOLVIDO - CORRETO!)

/*

int QtdNumeros = 0;

WriteLine("Insira quantos numeros sua lista vai ter: ");
QtdNumeros = ToInt32(ReadLine());

List<int> NumerosLista  = new List<int>(QtdNumeros);


for (int i = 0; i < QtdNumeros; i++)
{
    WriteLine($"Insira o {i + 1}° Numero (Inteiro e Positivo): ");
    int NumDig = ToInt32(ReadLine());
    NumerosLista.Add(NumDig);
}

double MediaNum = NumerosLista.Average();
int NumeroMaior = NumerosLista.Max();

WriteLine($"\nTamanho da Lista: {QtdNumeros}");
WriteLine($"Média dos Numeros: {MediaNum}");
WriteLine($"Maior numero digitado: {NumeroMaior}");


*/

//-----------------------------8-----------------------------( RESOLVIDO - CORRETO!)

/*

int QtdAlunos = 0;

WriteLine("Insira quantos alunos vão ter na sua lista: ");
QtdAlunos = ToInt32(ReadLine());

List<double> G1 = new List<double>(QtdAlunos);
List<double> G2 = new List<double>(QtdAlunos);
List<double> mediasLista = new List<double>();

for (int i = 0; i < QtdAlunos; i++)
{
    WriteLine($"Insira a {i + 1}° Nota do Aluno (G1): ");
    double AlunoG1 = ToDouble(ReadLine());
    G1.Add(AlunoG1);
    WriteLine($"Insira a Nota do Aluno (G2): ");
    double AlunoG2 = ToDouble(ReadLine());
    G2.Add(AlunoG2);
    double media = (G1[i] + G2[i]) / 2;
    mediasLista.Add(media);
}

WriteLine("\nNotas e médias dos alunos:");
for (int i = 0; i < QtdAlunos; i++)
{
    WriteLine($"Aluno {i + 1}: G1 = {G1[i]:F2}, G2 = {G2[i]:F2}, Média = {mediasLista[i]:F2}");
}


*/

//-----------------------------9-----------------------------( - !)

int TamanhoLista = 10;
List<double> TodosNumerosLista = new List<double>(10);
List<double> NumerosParesLista = new List<double>(10);
List<double> NumerosImparesLista = new List<double>(10);


WriteLine("Insira 10 numeros: ");
for (int i = 0; i < TamanhoLista; i++)
{
    WriteLine($"{i + 1}° Numero:  ");
    double NumeroDigitado = ToDouble(ReadLine());
    TodosNumerosLista.Add(NumeroDigitado);
    if ( NumeroDigitado % 2 == 0)
    {
        NumerosParesLista.Add(NumeroDigitado);
    }
    if ( NumeroDigitado % 2 == 1)
    {
        NumerosImparesLista.Add(NumeroDigitado);
    }

}
Clear();

WriteLine($"\nNumeros Digitados: {TodosNumerosLista}");
WriteLine($"Numeros Pares da lista: {NumerosParesLista}");
WriteLine($"Numeros Impares da lista: {NumerosImparesLista}");
