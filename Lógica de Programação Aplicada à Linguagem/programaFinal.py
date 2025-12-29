compras = []
while resp != "s":
    compras.append(input("Digite o item da lista"))
    resp = input("Deseja continuar? s ou n")
for x in compras:
    print(x)