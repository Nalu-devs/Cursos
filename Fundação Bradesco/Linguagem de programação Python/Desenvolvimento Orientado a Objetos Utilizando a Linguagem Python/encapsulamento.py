# A ideia de encapsular o código vem com a premissa de proteger atributos e métodos de
# uma classe (tornando-os privados), de forma que somente a classe onde as declarações 
# foram feitas tenham acesso.

# Dentro da orientação a objetos temos os modificadores Public, Protected e Private.

# PUBLIC:
# É o mais comum entre os modificadores.
# Ele permite acesso tanto de dentro, quanto de fora de uma classe.
# Sua implementação se dá por meio do uso do underline ”_” na frente do nome.

# PROTECTED: 
# Utilizando o modificador protegido, somente suas classes e subclasses terão 
# acesso ao atributo ou método.
# Para sua implementação adicione um underline ”_” antes do nome.

# PRIVATE:
# É o modificador mais restrito do desenvolvimento orientado a objetos.
# Ele permite que somente a sua classe (onde foi definido) tenha acesso a um 
# determinado atributo ou método.
# Para definir o método private adicionamos underline duplo ”__” na frente do nome.

# METODO DE ACESSO DAS INFORMAÇÕES (GET E SET)
# Para permitir o acesso aos atributos de forma controlada, a prática mais comum é 
# a utilização de dois métodos de acesso: um retornando valor e outro que muda valor.
# Getters e Setters são usados na maioria das linguagens de programação orientada 
# a objetos com o objetivo de garantir o princípio de encapsulamento de dados.
# Os métodos são utilizados para implementações que alteram os valores 
# internos da classe ou que retornam valores dela.

# GET
# Sempre retornam valores.
# O método Get é utilizado para ler os valores internos do objeto e enviá-los 
# como valor de retorno da função.
# SINTAXE:
# get_nome do atributo()
# Exemplo:
# get_idade(self):return self._idade


# SET
# Recebem valores por parâmetros.
# Os métodos Set recebem argumentos que serão atribuídos a membros internos do objeto.
# SINTAXE:
# set_nome do atributo
# (valor por parâmetro)
# Exemplo:
# def set_idade(self, valor):
# self.idade=valor