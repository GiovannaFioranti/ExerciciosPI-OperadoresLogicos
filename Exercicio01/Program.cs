// Operadores Relacionais
int a = 10;
int b = 20;

Console.WriteLine($"O valor de A é: {a}");
Console.WriteLine($"O valor de B é: {b}");

Console.WriteLine($"A é igual a B: {a == b}");

Console.WriteLine($"A é diferente de B: {a != b}");

Console.WriteLine($"A é maior que B: {a > b}");

Console.WriteLine($"A é menor que B: {a < b}");

Console.WriteLine($"A é maior ou igual a B: {a >= b}");

Console.WriteLine($"A é menor ou igual a B: {a <= b}");

// Operadores Lógicos
// Atividade usando Condicional
int idadeUsuario;

Console.WriteLine($"Insira sua idade: ");
idadeUsuario = int.Parse(Console.ReadLine());

if (idadeUsuario < 18)
    Console.WriteLine($"Usuário ainda não pode tirar sua habilitação, pois idade igual à: {idadeUsuario} anos");
else
    Console.WriteLine($"Usuário pode tirar sua habilitação idade igual à: {idadeUsuario} anos!");

// Outra forma de fazer sem uso da condicional
int age = int.Parse(Console.ReadLine());

Console.WriteLine($"É permitido tirar sua habilitação? {age >= 18}");

// Incremento e Decremento 
int idadeUsu;

Console.WriteLine($"Insira sua idade: ");
idadeUsu = int.Parse(Console.ReadLine());

while (idadeUsu < 18)
{
    Console.WriteLine($"Você ainda não pode tirar sua habilitação, pois idade igual à: {idadeUsu}");
    idadeUsu++;
}

Console.WriteLine($"Agora você pode tirar sua habilitação pois possui {idadeUsu} anos!");

/*
// Operadores Ternários
Sintaxe testeLogico 
? 
: 
*/
int A = 10;
int B = 20;

var result = (A < B ? "true" : "false");

Console.WriteLine(result);

// Exercício
/*
1-  O usuário é administrador de uma faculdade, ele 
gostaria de saber se os alunos foram aprovados ou reprovados, logo:
> 7 aprovado
5 à 7 recuperação
< 5 reprovado
*/
Console.WriteLine($"Insira sua média: ");
double media = double.Parse(Console.ReadLine());

if (media < 5)
    Console.WriteLine($"Aluno reprovado");
else if (media > 6 && media <= 7)
    Console.WriteLine($"Aluno em recuperação");
else
    Console.WriteLine($"Aluno aprovado");

// Utilizando operador ternário
var resultMedia = (media >= 8 ? "Aprovado" : "Reprovado");

Console.WriteLine($"A situação do aluno é: {resultMedia}");