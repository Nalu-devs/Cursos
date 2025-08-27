# OBJETO (OU INSTANCIA):
# É uma coleção de dados(variaveis) e metodos(funções) que atuam sobre eles

# CLASSES:
# Uma classe é um modelo para um objeto
# Observe uma definição de classe simples:

class MinhaNovaClasse:
    "Isto é uma docstring. Eu a criei dentro de minha nova classe"
pass

# Assim que é definida uma classe, um novo objeto de classe é criado com o mesmo nome. 
# Esse objeto nos permite acessar os diferentes atributos, bem como instanciar novos objetos 
# dessa classe. Observe no código em outra linha:

class Pessoa:
    "Isto é uma classe nova chamada Pessoa"
idade = 15
def saudacao (self): 
    print("Olá Pessoas!")

# Output: 15
print(Pessoa.idade)
# Output: <function Pessoa.saudacao>
print(Pessoa.saudacao)
# Output: “Isto é uma classe nova chamada Pessoa”
print(Pessoa.__doc__)