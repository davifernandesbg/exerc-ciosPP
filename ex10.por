programa {
  inclua biblioteca Matematica
  funcao inicio() {
    real KW, Preco, Valor

    escreva ("Digite a quantidade de quilowatts consumidos: ")
    leia (KW)

    escreva ("Digite o preço do quilowatt: ")
    leia (Preco)

    Valor = Matematica.arredondar(KW * Preco, 2)

    escreva ("O valor total da conta a ser paga é de R$ ", Valor)
  }
}
