class Cliente:
    def __init__(self, n, fone):
        self.nome = n
        self.telefone = fone 



# Utilizamos a palavra reservada pass, quando nenhuma estrutura será definida no corpo dessa classe.
# A palavra def é utilizada para a declaração de método.
# Para definir o construtor adicionamos: underline, underline, a palavra reservada init, underline,
# underline. O init() é um método especial que será chamado sempre que criarmos um objeto da classe.
# Incluímos o parâmetro obrigatório self, que está presente em todos os métodos. Resumidamente,
# podemos afirmar que o parâmetro self, neste momento, exporta as características do objeto.