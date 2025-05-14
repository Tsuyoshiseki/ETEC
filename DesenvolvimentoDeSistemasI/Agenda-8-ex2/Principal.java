
//author Luã Tsuyoshi Borges Seki 

/*
Faça um Programa em Java para calcular a soma dos dígitos de um número.
Por exemplo: N°: 21 -> 2+1 = 3

*/

import javax.swing.JOptionPane;

public class Principal {

    public static void main(String[] args) {
        //Variável
       int num, soma;
       
        //Entrada
      num = Integer.parseInt(JOptionPane.showInputDialog("Entre com um número inteiro: "));
      
        //Processamento
        soma= (num%10);
        
        while (num>0) {
            num/=10;
            soma = soma + (num%10);
        }
        
        JOptionPane.showMessageDialog(null, soma);
        
    }        
}
    
