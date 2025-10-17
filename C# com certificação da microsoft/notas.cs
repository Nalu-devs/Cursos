// Nesta tarefa, você criará uma variável para cada aluno que representará a soma de suas notas de 
// tarefas. Você também exibirá a soma do aluno junto com seu nome na saída do console. Como as 
// pontuações de atribuição são representadas como Inteiros, você criará variáveis Inteiros para 
// armazenar as somas.
// Verifique se o .NET Editor está aberto e se você tem as variáveis instanciadas com as notas das
// tarefas de cada aluno.
// Na unidade de preparação para este módulo de projeto guiado, as instruções de configuração 
// permitem que você copie as notas dos alunos para o editor. Se necessário, volte e conclua as 
// instruções de Instalação.
// Role para baixo até a parte inferior do código e crie uma nova linha de código em branco.
// Para declarar uma variável Integer para cada aluno que você pode usar para somar suas pontuações, 
// insira o seguinte código:
int sophiaSum = 0;
int nicolasSum = 0;
int zahirahSum = 0;
int jeongSum = 0;
// Observe que 0 é atribuído às variáveis como parte da instrução de declaração. Em outras palavras, 
// as variáveis são inicializadas para 0. Embora a atribuição de valor não seja necessária ao declarar 
// variáveis, ela pode tornar seu código mais eficiente. A próxima etapa é exibir a saída e, como essa 
// saída incluirá uma referência a essas variáveis, elas devem ser inicializadas.
// Para criar Console.WriteLine() declarações que exibam o nome do aluno e o valor das suas pontuações 
// somadas das tarefas, insira o seguinte código:
Console.WriteLine("Sophia: " + sophiaSum);
Console.WriteLine("Nicolas: " + nicolasSum);
Console.WriteLine("Zahirah: " + zahirahSum);
Console.WriteLine("Jeong: " + jeongSum);
// Por fim, é interessante exibir a nota geral atual do aluno. Contudo, por enquanto, vamos usar essas 
// instruções Console.WriteLine() para exibir o valor dos cálculos de soma. Dessa forma, você pode 
// verificar se o código está funcionando corretamente em cada estágio do processo de desenvolvimento.
// No Editor do .NET, para executar seu código, selecione o botão Executar verde.
// Observe que você não tem problemas ao exibir seus valores inteiros, todos 0 por enquanto, usando o 
// mesmo WriteLine() método que exibe os literais de string (nomes de alunos).
// O valor numérico atual é recuperado automaticamente referenciando o nome da variável.
// Agora que você tem as Console.WriteLine() instruções prontas para exibir seus resultados, vamos 
// começar a adicionar o código que executa seus cálculos.
// Localize a seguinte linha de código: int sophiaSum = 0;
// Você escreverá o código que calcula o valor da soma para cada aluno. Primeiro, você somará as notas 
// das atividades dos alunos e, em seguida, atribuirá o valor às variáveis "soma". Vamos começar com 
// Sophia. Lembre-se de que as pontuações de Sophia são armazenadas no seguinte código:
int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;
int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// No Editor do .NET, selecione Executar.
// Sua saída agora deve mostrar que a soma de Sophia é igual a 473. Os outros ainda estarão 0. 
// Você adicionará cálculos de soma semelhantes para o restante dos alunos.
// Começando na linha de código em branco que você acabou de criar, insira o seguinte código:
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;












// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine("Student Grade\n");

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");