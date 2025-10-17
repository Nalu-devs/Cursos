//Uma sequência de caracteres de escape é uma instrução especial para que o runtime insira um 
//caractere especial que afetará a saída da cadeia de caracteres. Em C#, a sequência de caracteres 
//de escape começa com uma barra invertida \ seguida pelo caractere que será escapado. Por exemplo, 
//a sequência \n adicionará uma nova linha e uma sequência \t adicionará uma guia.

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
//RESULTADO:
//Hello
//World!
//Hello   World!

Console.WriteLine("Hello \"World\"!");
//RESULTADO:
//Hello "World"!

//use \\ para exibir uma barra invertida simples.
Console.WriteLine("c:\\source\\repos");
//RESULTADO:
//c:\source\repos

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
//RESULTADO
//Generating invoices for customer "Contoso Corp" ...

//Invoice: 1021           Complete!
//Invoice: 1022           Complete!

//Output Directory:


//Um literal de cadeia de caracteres textual manterá todo o espaço em branco e os caracteres sem 
//a necessidade de escapar da barra invertida. Para criar uma cadeia de caracteres textual, use a 
//diretiva @ antes da cadeia de caracteres literal.
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");
//RESULTADO:
//c:\source\repos    
//        (this is where your code goes)


//Você também pode adicionar caracteres codificados em cadeias de caracteres literais usando a 
//sequência de escape \u e, em seguida, um código de quatro caracteres representando algum caractere 
//em Unicode (UTF-16).
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
//RESULTADO:
//こんにちは World!





//COMBINAR CAIDEIAS DE CARACTERES USANDO A CONCATENAÇÃO DE CADEIAS DE CARACTERES
//A concatenação de cadeias de caracteres consiste simplesmente na combinação de dois ou mais valores 
//string em um novo valor string. Ao contrário da adição, o segundo valor é acrescentado ao final 
//do primeiro valor e assim por diante.

//Para concatenar duas cadeias de caracteres, use o operador de concatenação de cadeia de caracteres, 
//que é o símbolo de adição +.
string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);

//É possivel concatenar varias variaveis:
string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);





//COMBINAR CADEIAS DE CARACTERES USANDO A INTERPOLAÇÃO DE CADEIAS DE CARATCETRES
//A interpolação de cadeia de caracteres combina vários valores em uma única cadeia de caracteres 
//literal usando um "modelo" e uma ou mais expressões de interpolação. Uma expressão de interpolação 
//é indicada por um símbolo de chave de abertura e fechamento { }. Você pode colocar qualquer 
//expressão C# que retorne um valor entre chaves. A cadeia de caracteres literal se torna um modelo 
//quando é prefixada pelo $ caractere.
//AO INVES DISSO:
string message = greeting + " " + firstName + "!";
//FAÇA ISSO:
string message = $"{greeting} {firstName}!";

//Suponha que você precise usar um texto literal em seu template. Você pode usar o símbolo @ de 
//prefixo literal textual e o símbolo $ de interpolação de cadeia de caracteres juntos.
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");


//exercicio:
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string englishMessage = "View English output:";
Console.WriteLine($"{englishMessage}\n"+$@"     C:\Exercise\{projectName}\data.txt"+"\n");
Console.WriteLine($"{russianMessage}\n"+$@"     C:\Exercise\{projectName}\data.txt");