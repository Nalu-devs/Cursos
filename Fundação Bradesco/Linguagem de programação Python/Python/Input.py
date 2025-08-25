# Para exemplificar a entrada de dados, vamos criar uma classe chamada Exemplo2, utilizando o menu New – Python.
#Vamos acrescentar a função input na classe.

fruta = input ("Digite o nome de uma fruta: ")
print(fruta)

# Quando utilizamos a entrada de dados por meio da função input, essa será considerada do tipo string.
# Assim, caso seja necessário realizar a entrada de valores numéricos,temos de converter o tipo de dado,
# de acordo com o tipo que desejamos armazenar na variável.

codigo = int(input("Digite o codigo do funcionario"))
nome = input("Digite o nome do funcionario")
salario = float(input("Digite o salario do funcionario"))
ativo = True

print("Código: %d "% codigo)
print("Nome: %s "% nome)
print("Código %.2f "% salario)
print("Código %r "% ativo)