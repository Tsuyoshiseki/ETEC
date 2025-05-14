
//author Luã Tsuyoshi Borges Seki 

/*

 Desenvolva um programa que leia 5 valores de um vetor e os exiba na ordem inversa da qual foram
cadastrados.


*/
import javax.swing.JOptionPane;

public class Principal {

    public static void main(String[] args) {
        
       //Variável
       int[] numeros = new int[5];
       int contador;
       String resultado;
       
       //Entrada
       resultado= "Os números digitados em ordem inversa são: ";
       for(contador = 0; contador<5; contador ++){
           numeros[contador]=Integer.parseInt(JOptionPane.showInputDialog(
                   "Digite o " + (contador+1) + " número"));
       }
       for(contador=4; contador>=0; contador--){
           resultado = resultado + String.valueOf(numeros[contador]) + " ";
       }
       
       //Processamento
       JOptionPane.showMessageDialog(null, resultado);
       

    }
    
}
