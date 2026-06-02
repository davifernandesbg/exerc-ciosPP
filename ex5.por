programa {
  funcao inicio() {
    inteiro Codigo, Quantidade
    real Valor, ValorTotal

    escreva ("Digite o código da peça: ")
    leia (Codigo)

    escreva ("Digite o valor da peça: ")
    leia (Valor)

    escreva ("Digite a quantidade de peças: ")
    leia (Quantidade)

    ValorTotal = Quantidade * Valor

    escreva ("O valor total da peça de código ", Codigo ," é R$" , ValorTotal)
  }
}