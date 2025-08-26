# programação orientada a objeto, explicando seus quatro mais importantes componentes:
#abstração, encapsulamento, herança e polimorfismo. 

# ABSTRAÇÃO: processo de aproximar o mundo real do mundo da programação, sendo o seu objetivo, 
# simplificar um problema difícil a abstração se concentra apenas nas informações que são 
# importantes para o seu propósito. Dessa forma, ela mantém suas classes o mais simples
# possível, concentrando-se apenas no que é importante para uma determinada finalidade. EXEMPLO: 
# Vamos supor que você está desenvolvendo um código com a classe “ser humano”. Essa classe é
# composta por inúmeras variantes (atributos), como por exemplo: altura, peso, cor da pele,
# cor do olho, CPF, nome, endereço etc. O objetivo do seu código é tratar o "ser humano" como
# cliente. Para cada cliente é preciso obter as informações de CPF, Nome e Endereço.
# As outras informações que pode obter na classe "ser humano", como cor da pele, cor do olho, 
# altura, peso etc. não são importantes para esta situação. Portanto, podemos abstrair estas 
# informações e considerar somente o que importa.

# ENCAPSULAMENTO: Ao encapsular algo, você está colocando um objeto dentro de um recipiente,
# igual a um remédio de cápsula. O encapsulamento é uma das principais técnicas da programação
# orientada a objetos. Quando você encapsula um objeto, você está criando uma proteção e um padrão.
# Com isso, o propósito é de proteger o desenvolvedor do código e o código do desenvolvedor. EXEMPLO:
# Para entender melhor esse processo, pense, por exemplo, nas máquinas de café expresso nas padarias.
# Como ela é feita, não é algo que precisamos saber para poder obter o resultado do processo 
# (nosso café quentinho). Por isso, a máquina é um objeto encapsulado, onde os ingredientes e 
# o mecanismo do preparo do café ficam escondidos atrás da interface externa da máquina, composta 
# por botões de comando (como ligar, desligar, tipos de bebida etc.) que auxiliam na preparação.

# HERANÇA: Assim como no mundo real, a herança na POO também diz respeito à ação de herdar. 
# Ela nada mais é do que um objeto poder ser criado em uma outra classe, levando consigo todos 
# os atributos já existentes em sua classe de origem.
# No organograma (ORGONAGRAMA.JPG), mostra um exemplo de herança. Ao analisá-la, percebe-se que 
# as classes herbívoro, carnívoro e onívoro podem herdar quaisquer atributos necessários da 
# classe animal: tamanho, raça, cor etc. Da mesma forma, as classes leão, hiena, homem e coelho 
# podem herdar atributos das classes herbívoro, carnívoro ou onívoro.

# POLIMORFISMO: é utilizado para que duas classes façam uso do mesmo método, implementando-o de 
# formas diferentes. Ele permite que o programador desenvolva o código de forma ampla ao invés de 
# perder muito tempo no desenvolvimento de códigos específicos. Ou seja, o polimorfismo permite 
# que sistemas sejam escritos de forma a processar objetos que compartilham a mesma superclasse 
# (classe já existente), como se eles fossem parte direta dela.
# Se pensarmos na superclasse Animal, estabelecemos o método “emitir o som do objeto animal”, 
# ou seja, os objetos pato, cachorro e gato, por exemplo, devem emitir um som ao comando do método, 
# mas cada um fará isso de um jeito diferente.
# Agora observe no fluxo (FLUXO.SVG), mais um exemplo de que o polimorfismo foi este processo de 
# implementar métodos (mover).