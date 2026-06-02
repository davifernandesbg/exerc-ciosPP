programa {
  funcao inicio() {
    inteiro Quantidademin, Quantidademax
    real EstoqueMedio

    escreva ("Digite a quantidade mínima de peças no estoque: ")
    leia (Quantidademin)

    escreva ("Digite a quantidade máxima de peças no estoque: ")
    leia (Quantidademax)

    EstoqueMedio = (Quantidademin + Quantidademax) / 2

    escreva ("O estoque médio de peças no estoque é de:", EstoqueMedio)
  }
}