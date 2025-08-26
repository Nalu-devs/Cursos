# algumas linguagens de programação que utilizam o paradigma orientado a objetos, como Java, C# e C++

# LINGUAGEM JAVA: Esse nome é muito conhecido por ter sido escolhido devido a uma ilha da Indonésia, 
# onde há uma produção de café exótico. Essa linguagem de programação foi criada nos anos 90, baseada 
# na linguagem C. Ela foi desenvolvida pela empresa Sun Microsystems, que tem James Gosling como 
# seu CEO. Mas atualmente a empresa Oracle comprou a linguagem. O diferencial da linguagem Java é ser
# multiplataforma, ou seja, um mesmo programa pode funcionar perfeitamente em Windows, Linux,
# Android e iOS. Atualmente ela é muito utilizada em desenvolvimento da Internet da Coisas
# (IoT), aplicações para celular, além de jogos on-line, aplicativos para Android, páginas 
# da Internet, documentos interativos etc. Observe no código a seguir, um exemplo de uma classe 
# desenvolvida em linguagem Java. Note que esta linguagem faz uso dos pilares da POO. Não se 
# esqueça de selecionar as setas para ver todas as informações.

# public class Exercicio {
#     public static void main (String args[]){
#         int x = 4;
#         do{
#             x - -;
#         }while(x>5);
#         System.out.println(x);
#     }
# }

# VANTAGENS: 
# Portabilidade: pode ser executada em várias plataformas como Windows, Mac, Linux, Unix, entre outras
# Multi-Threaded: suporta multiprocessamentos, ou seja, permite realizar mais de um processo ao mesmo tempo.
# Criação de jogos: quando falamos em desenvolvimento de jogos, Java é a primeira linguagem a ser lembrada, já que ela possui vários recursos que facilitam a produção de inúmeros tipos de jogos.
# Gratuidade: a linguagem e seus ambientes de desenvolvimento são totalmente gratuitos
# Utilização: a sua utilização atualmente tem amplitude mundial, sendo aplicada até mesmo em bancos e instituições do governo
# Independência: Java é independente de qualquer plataforma, pois ela se conecta em diversas aplicações e sistemas.

# DESVANTAGENS:
# Para que seja realizada uma simples instrução é preciso muitas linhas de codigo
# A linguagem faz uso do Bytecode a segurança do codigo fica comprometida sendo possivel outros desenvolvedores verem o que vc fez


# LINGUAGEM C++: Ela foi criada no início de 1980, por Bjame Stroustrup, no Bell Laboratories. 
# A C++ possui diversos recursos que embelezam a linguagem C, principalmente trazendo a 
# possibilidade da programação orientada a objetos. Com isso, surge a possibilidade da 
# linguagem poder ser utilizada em grandes projetos com diversos programadores colaborando 
# simultaneamente.

# DESVANTAGENS:
# A primeira coisa que podemos citar como desvantagem é o gerenciamento manual da memória. 
# Contudo, tenha atenção: mesmo que possa ser visto como uma vantagem, ele também pode causar 
# problemas, já que é um processo que não é fácil. Se não for realizado com eficiência, ele 
# pode trazer problemas na aplicação a ser desenvolvida.
# Em função disso, é relevante frisar que tal gerenciamento manual pode gerar insegurança, 
# ou seja, tal fato pode fazer com que ela não seja tão segura como as outras linguagens, 
# por exemplo: a Java. A capacidade que a linguagem tem de realizar basicamente tudo, faz 
# com que o risco de algo ilícito ou errado acontecer aumente.
# Observe o código a seguir, que apresenta uma classe criada em linguagem C++, com o nome 
# “minha classe”. Note que o Loop For é quem vai ajudar na realização dos cálculos.

#include <iostream>
#include <string>
# class Minha Classe
# {
#       public:
#       int ni, n2, n3;
#       void Calcular(int);
# };
# void Minha Classe::Calcular(int x = 1)
# { 
#       n1 = 0 ;
#       n2 = 1;
#       std::cout << n1 << “ “ << n2;
#       for (int i = 1; i<= x-2; i++) {
#           n3 = n1 + n2;
#           std::cout << “ “ « n3;
#           n1 = n2;
#           n2 = n3;
#       }
# }

# int main()
# {
#       int numero = 5;
#       Minhaclasse objeto;
#       objeto.Calcular();
# }


# LINGUAGEM C#: o nome da linguagem foi escolhido, pois o símbolo # é utilizado para se 
# referir ao sustenido, no meio musical. O sustenido indica meio tom acima de uma determinada 
# nota musical. E já que o C# possui uma sintaxe elegante, expressiva e orientada a objetos, 
# foi o nome escolhido pela Microsoft quando foi desenvolvida como parte da plataforma .NET.

# public class Cachorro
# {
#       public Cachorro(string nome, int idade)
#       {
#           Nome = nome;
#           Idade = idade;
#       }
#       public string Nome { get; protected set; } =
# “Canelinha”;
#       public int Idade { get; set; } = 1;
#       public void IncrementaIdade() => Idade++;

#       public int IdadeDoCachorroEmAnos() => Idade * 7;
# }