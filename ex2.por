programa {
  inclua biblioteca Matematica
  funcao inicio() {
    real Raio, Comprimento

    escreva ("Digite o raio da circunferência: ")
    leia (Raio)

    Comprimento = Matematica.arredondar(2 * 3.14 * Raio, 2)

    escreva ("O comprimento da circunferência é: ", Comprimento)

  }
}
