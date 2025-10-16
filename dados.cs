//Valores embutidos em código são valores constantes e inalterados durante a execução do programa. Por exemplo, talvez seja necessário imprimir uma mensagem para o usuário quando alguma operação for bem-sucedida. Uma mensagem de "sucesso" provavelmente seria 
//a mesma sempre que o aplicativo for executado. Esse valor embutido em código também pode ser chamado de constante ou um valor literal.

//Se você quiser apenas um caractere alfanumérico impresso na tela, poderá criar um char literal usando um caractere alfanumérico entre aspas simples. O termo char é uma abreviação de caractere. Em C#, esse tipo de dados é oficialmente chamado de "char",
//mas frequentemente chamado de "caractere".
Console.WriteLine('b');

//Se você quiser exibir um valor numérico inteiro (sem frações) no console de saída, poderá usar um literal int. O termo int é uma abreviação de "inteiro", que você pode reconhecer ao estudar matemática. Em C#, esse tipo de dados é oficialmente chamado de 
//"int", mas frequentemente chamado de "inteiro". Um int literal não requer outros operadores como o string ou char.
Console.WriteLine(123);

//Um número de ponto flutuante é um número que contém uma decimal, por exemplo, 3.14159. O C# dá suporte a três tipos de dados para representar números decimais: float, doublee decimal. Cada tipo dá suporte a diferentes graus de precisão.
//Float Type    Precision
//----------------------------
//float         ~6-9 digits
//double        ~15-17 digits
//decimal        28-29 digits
//Para criar um float literal, acrescente a letra F após o número. Nesse contexto, o F é denominado sufixo literal. O sufixo literal informa ao compilador que você deseja trabalhar com um valor do tipo float. Você pode usar um f minúsculo ou um F 
//maiúsculo como sufixo literal para um float.
Console.WriteLine(0.25F);

//Para criar um double literal, basta inserir um número decimal. O compilador usa como padrão um double literal quando um número decimal é inserido sem um sufixo literal.
Console.WriteLine(2.625);

//Para criar um literal decimal, acrescente a letra m após o número. Nesse contexto, o m é denominado sufixo literal. O sufixo literal informa ao compilador que você deseja trabalhar com um valor do tipo decimal. Você pode usar um m minúsculo ou um 
//M maiúsculo como sufixo literal para um decimal
Console.WriteLine(12.39816m);

//Se você quisesse imprimir um valor que representasse true ou false, você poderia usar um literal booleano.
//O termo bool é curto para Boolean. No C#, eles são oficialmente chamados de "bool", mas geralmente os desenvolvedores usam o termo "Boolean".
Console.WriteLine(true);
Console.WriteLine(false);

//Anteriormente, você viu que strings e chars são usados para "apresentação, não cálculo". Se você precisar executar uma operação matemática em valores numéricos, deverá usar um int ou decimal. Se você tiver dados usados para apresentação ou manipulação
//de texto, deverá usar um tipo de dados string ou char.
Console.WriteLine("123");
Console.WriteLine(123);
Console.WriteLine("true");
Console.WriteLine(true);


//DECLARAR UMA VARIAVEL
//Para criar uma nova variável, primeiro você deve declarar o tipo de dados da variável e, em seguida, dar-lhe um nome.
string firstName;
//Você pode escolher qualquer nome desde que ele adere a algumas regras de sintaxe C# para variáveis de nomenclatura.
//Os nomes de variáveis podem conter caracteres alfanuméricos e o caractere de sublinhado. Caracteres especiais como o símbolo # de hash (também conhecido como símbolo de número ou símbolo de libra) ou símbolo $ de dólar não são permitidos.
//Nomes de variáveis devem começar com uma letra alfabética ou um sublinhado, não um número.
//Os nomes de variáveis diferenciam maiúsculas de minúsculas, o que significa que string Value; e string value; são duas variáveis diferentes.
//OS nomes de variáveis não podem ser uma palavra-chave do C#. Por exemplo, você não pode usar as seguintes declarações de variável: decimal decimal; ou string string;.
//Nomes de variáveis devem usar camelCase, que é um estilo de escrita que usa uma letra minúscula no início da primeira palavra e uma letra maiúscula no início de cada palavra subsequente. Por exemplo, string thisIsCamelCase;.
//Os nomes das variáveis devem começar com uma letra alfabética. Os desenvolvedores usam o sublinhado para uma finalidade especial, portanto, tente não usá-lo por enquanto.
//Os nomes de variáveis devem ser descritivos e significativos em seu aplicativo. Escolha um nome para sua variável que represente o tipo de dados que ele conterá.
//Os nomes de variáveis devem ser uma ou mais palavras inteiras acrescentadas. Não use contrações ou abreviações porque o nome da variável (e, portanto, sua finalidade) pode não estar claro para outras pessoas que estão lendo seu código.
//Nomes de variáveis não devem incluir o tipo de dados da variável. Você pode ver alguns conselhos para usar um estilo como string strValue;. Esse conselho não é mais atual.
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;


//PARA RECUPERAR UM VALOR AMARZENADO:
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);

string firstName;
firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);


//DECLARAÇÃO DE VARIAVEIS LOCAIS
//Uma variável local digitada implicitamente é criada usando a var palavra-chave seguida de uma inicialização de variável. Por exemplo:
var message = "Hello world!";

//A var palavra-chave foi amplamente adotada na comunidade C#. É provável que, se você examinar um exemplo de código em um livro ou online, verá a var palavra-chave usada em vez do nome do tipo de dados real, portanto, é importante entender seu uso.

//A var palavra-chave tem um uso importante em C#. Muitas vezes, o tipo de uma variável é óbvio de sua inicialização. Nesses casos, é mais simples usar a var palavra-chave. A var palavra-chave também pode ser útil ao planejar o código para um aplicativo.
//Quando você começa a desenvolver código para uma tarefa, talvez não saiba imediatamente qual tipo de dados usar. Usar var pode ajudá-lo a desenvolver sua solução de forma mais dinâmica.
//À medida que você começa, é recomendável que você continue a usar o nome do tipo de dados real ao declarar variáveis até ficar mais confortável trabalhando com código. Usar o tipo de dados ao declarar variáveis ajudará você a ser proposital ao escrever seu código.

var nome = "Bob";
var num = 3;
var deci = 34.4;

Console.Write("Hello, "+nome+"! "+"You have "+num+"messages in your inbox. The temperature is "+deci+" celsius.");
