# %d ou %i	Int (inteiro)	Exibe um valor inteiro.
# %f	Float ou double	Exibe um valor decimal.
# %ld	Long Int	Exibe um número inteiro longo.
# %e ou %E	Float e double	Exibe um número exponencial (número científico).
# %c	Char (caractere)	Exibe um caractere.
# %o	Int	Exibe um número inteiro em formato octal.
# %x ou %X	Int	Exibe um número inteiro no formato hexadecimal.
# %s	Char	Exibe uma cadeia de caracteres (string).
# %r	Boolean	Exibe true ou false (verdadeiro ou falso).

codigo = 100
nome = 'Nalu'
salario = 700.00
ativo = True

print("Código: %d "% codigo)
print("Nome: %s "% nome)
print("Código %.2f "% salario)
print("Código %r "% ativo)