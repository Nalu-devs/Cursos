//Para somar dois números, você usará o operador de adição, que é o sinal de mais +. Sim, o mesmo 
//símbolo de mais + que você usa para concatenação de cadeias de caracteres também é usado para 
//adição. A reutilização de um símbolo com várias finalidades é, às vezes, chamada de "sobrecarregar 
//o operador", e ocorre frequentemente em C#.
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

//O que acontece se você tenta usar o símbolo + com os valores string e int?
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
//Neste caso, o compilador de C# entende que você deseja usar o símbolo + para concatenar os dois 
//operandos. Ele deduz isso porque o símbolo + está rodeado por operandos dos tipos de dados string 
//e int. Sendo assim, ele tenta converter implicitamente a variável intwidgetsSold em um string 
//temporariamente, para que possa concatenar o restante da cadeia de caracteres. O compilador de 
//C# tenta ajudá-lo quando pode, mas o ideal é que você seja explícito quanto às suas intenções.

//Variação
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
//RESULTADO:
//Bob sold 77 widgets.

//O símbolo de parênteses () se torna outro operador sobrecarregado. Neste caso, os parênteses de 
//abertura e fechamento formam o operador de ordem de operações, exatamente como você usaria em uma 
//fórmula matemática. Você indica que quer que os parênteses internos sejam resolvidos primeiro, 
//resultando na adição dos valores int, widgetsSold e o valor 7. Após isso ser resolvido, ele 
//converterá implicitamente o resultado em uma cadeia de caracteres para que possa ser concatenado 
//ao restante da mensagem.
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");
//RESULTADO:
//Bob sold 14 widgets.

//soma, subtração, multiplicação e divisão
int sum = 7+5;
int difference = 7-5;
int product = 7*5;
int quotient = 7/5;

Console.WriteLine("Sum: "+sum);
Console.WriteLine("Difference: "+difference);
Console.WriteLine("Product: "+product);
Console.WriteLine("Quotient: "+quotient);

//No entanto, o quociente resultante do exemplo de divisão pode não ser o que você esperava. Os 
//valores após a casa decimal são truncados em quotient, pois ele está definido como um int e um 
//int não pode conter valores após a casa decimal.
//Para que a divisão funcione corretamente, use um tipo de dados que dê suporte a dígitos fracionários 
//após o ponto decimal, como decimal.
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");





//ADICIONAR O CODIGO PARA CONVERTER OS RESULTADOS DA DIVISAO DE NUMEROS INTEIROS
//E se você não estiver trabalhando com valores literais? Em outras palavras, e se você precisar 
//dividir duas variáveis do tipo int, mas não quiser que o resultado seja truncado? Nesse caso, 
//você precisa executar uma conversão de tipo de dados de int em decimal. A conversão é um tipo de 
//conversão de dados que instrui o compilador a tratar temporariamente um valor como se ele fosse um 
//tipo de dados diferente.
//Para converter int em decimal, você adiciona o operador de conversão antes do valor. É possível usar 
//o nome do tipo de dados entre parênteses na frente do valor para convertê-lo. Nesse caso, adicione 
//(decimal) antes das variáveis first e second.
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

//O operador de módulo % informa o resto da divisão de int. O que você realmente aprende com isso é 
//se um número é divisível por outro. Isso pode ser útil durante operações de processamento longo ao 
//percorrer em loop centenas ou milhares de registros de dados quando deseja fornecer comentários para
//o usuário final após cada 100 registros de dados terem sido processados.
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

//Conforme você aprendeu no exercício anterior, é possível usar os símbolos () como os operadores de 
//ordem das operações. No entanto, esta não é a única forma da ordem das operações ser determinada.
//Em matemática, PEMDAS é um acrônimo que ajuda os alunos a se lembrar da ordem das operações. 
//A ordem é:
//1) Parêntese (o que estiver dentro do parêntese é executado primeiro)
//2) Exponentes
//3) Multiplicação e Divisão (da esquerda para a direita)
//4) Adição e Subtração (da esquerda para a direita)
//C# segue a mesma ordem que o acrônimo PEMDAS, exceto pelos exponentes. Embora não haja um operador 
//de expoente em C#, é possível usar o método System.Math.Pow. O módulo "Chamar métodos da Biblioteca 
//de Classes .NET usando C#" apresentará esse e outros métodos.





//INCREMENTAR E DECREMENTAR
//Com frequência, você precisará incrementar e/ou diminuir valores, especialmente quando estiver 
//escrevendo uma lógica de loop ou código que interaja com uma estrutura de dados.
//O += operador adiciona e atribui o valor à direita do operador ao valor à esquerda do operador. 
//Portanto, as linhas dois e três no snippet de código a seguir são as mesmas:
int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.

//O ++ operador incrementa o valor da variável em 1. Portanto, as linhas dois e três no snippet de 
//código a seguir são as mesmas:
int value = 0;     // value is now 0.
value = value + 1; // value is now 1.
value++;           // value is now 2.



//ESCREVER CODIGO PARA INCREMENTAR E DECREMENTAR UM VALOR
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);
//RESULTADO:
//First increment: 2
//Second increment: 3
//Third increment: 4
//First decrement: 3
//Second decrement: 2
//Third decrement: 1

//Os operadores de incremento e decremento têm uma característica interessante: dependendo da 
//posição em que são usados, eles executam a operação correspondente antes ou depois de recuperarem 
//o valor. Em outras palavras, se você usar o operador antes do valor como dentro ++value, o 
//incremento ocorrerá antes que o valor seja recuperado. Da mesma forma, value++ incrementará o 
//valor depois que o valor for recuperado.




//EXERCICIO
//Para converter temperaturas em graus Fahrenheit em Celsius, primeiro subtraia 32 e, em seguida, 
//multiplique por cinco nonos (5/9).
//Exibir o resultado da conversão de temperatura em uma mensagem formatada
//Combine as variáveis com cadeias de caracteres literais transmitidas para uma série de comandos 
//Console.WriteLine() para formar a mensagem completa.
int fahrenheit = 94;
decimal celsius = (decimal)(fahrenheit-32m)*5m/9m;
Console.WriteLine("The temperature is "+celsius+" Celsius.");