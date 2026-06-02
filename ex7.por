programa {
  inclua biblioteca Matematica 

  funcao inicio() {
    real CotacaoDolar, Dolar, Real 

    escreva ("Digite a cotação do Dolar para reais: ")
    leia (CotacaoDolar)

    escreva ("Digite o valor em dolares: ")
    leia (Dolar)

    Real = Matematica.arredondar(Dolar * CotacaoDolar, 2)

    escreva ("O valor em reais é de R$ ", Real)
  }
}
