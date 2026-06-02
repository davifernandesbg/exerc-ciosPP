programa {
  inclua biblioteca Matematica 

  funcao inicio() {
    inteiro ID, Codigo, Quantidade
    real Preco, Comissao, Total

    escreva ("Digite o ID do vendedor: ")
    leia (ID)

    escreva ("Digite o código da peça: ")
    leia (Codigo)

    escreva ("Digite o preço unitário da peça: ")
    leia (Preco)

    escreva ("Digite a quantidade de peças vendidas: ")
    leia (Quantidade)

    Total = Preco * Quantidade
    Comissao = Total * 0.05

    escreva ("ID do vendedor: ", ID, "\nCódigo da peça: ", Codigo, "\nPreço Unitário: ", Preco, "\nQuantidade Vendida: ", Quantidade, "\nComissão Do Vendedor: ", Comissao)
  }
}
