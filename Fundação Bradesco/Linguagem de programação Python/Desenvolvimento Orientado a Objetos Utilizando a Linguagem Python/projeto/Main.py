class Main:
    pass

from Cliente import Cliente

from Conta import Conta

c1 = Cliente ("Nalu", "(14) 99999-9999")
conta=Conta(c1.nome,6565,0)

print(c1)
print(c1.nome," e ", c1.telefone)