# A estrutura de decisão, também conhecida como estrutura condicional,
# tem como finalidade comparar e efetuar um desvio de processamento do programa

idade = int(input("Digite sua idade: "))
if idade>18:
    print("Maior de idade")
elif idade>16:
    print("Infanto juvenil")
else:
    print("Menor de idade")


a = input("Informe um valor para a variavel a")
b = input("Informe um valor para a variavel b")
if(a>b):
    aux=a;
    a=b;
    b=aux;
print("O valor da variavel a agr é", a);
print("O valor da variavel b agr é", b);