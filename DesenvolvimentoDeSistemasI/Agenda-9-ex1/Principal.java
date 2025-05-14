
//author Luã Tsuyoshi Borges Seki 

/*

Desenvolva um programa que leia 20 valores inteiros. Após a leitura, o programa deverá exibir os
números armazenados no vetor, porém, os números que estiverem em casas pares do vetor, o valor
deverá ser multiplicado por 2.


*/

import javax.swing.JOptionPane;

public class Principal {

    public static void main(String[] args) {
        
        // Variável
        int total = 5;
        int valor[] = new int[total]; 
        int contador;
        String numeros; 
        int mult;
        
        // Entrada
        for (contador = 0; contador < total; contador++) {
            valor[contador] = Integer.parseInt(JOptionPane.showInputDialog(
                "Digite o " + (contador + 1) + " valor")); 
        }
 
        // Processamento
        numeros = "Os números digitados foram: ";
        for (contador = 0; contador < total; contador++) {
            if (contador % 2 == 0) { // Índice par
                mult = valor[contador] * 2; 
                numeros += mult + " ";
            } else { 
                numeros += valor[contador] + " ";
            }
        }
        
        // Exibição
        JOptionPane.showMessageDialog(null, numeros);
    }
}

