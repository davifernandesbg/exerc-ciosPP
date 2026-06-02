programa {
  inclua biblioteca Matematica
  funcao inicio() {
    real Fahrenheit, Celsius
    
    escreva ("Digite a temperatura em Fahrenheit: ")
    leia (Fahrenheit)

    Celsius = Matematica.arredondar (5 * (Fahrenheit - 32) / 9, 2)
    
    escreva ("A temperatura em Celsius é: ", Celsius)
  }
}
