
import javax.swing.JOptionPane;


//author Luã Tsuyoshi Borges Seki 

/*

Paulo, o estudante do Ensino Médio que você conheceu no Mergulhando no Tema, 
agora deseja criar um programa que realize a soma de todos os elementos de uma 
matriz 3x3, contendo números inteiros. Elabore a codificação em linguagem Java 
de um software que resolva o problema de Paulo.

IMPORTANTE: O programa deverá solicitar a digitação dos valores e 
armazenar numa matriz 3x3.


*/
public class Principal {

    public static void main(String[] args) {
        
//Variável
        int linha, coluna;
        int m [][] = new int[3][3];
        int soma = 0;
        
//Entrada
        JOptionPane.showMessageDialog(null,"Insira os valores para soma da Matriz");
        
        try{
            for (linha=0; linha<3; linha++){
                for(coluna=0; coluna<3; coluna++){
                    m[linha][coluna] = Integer.parseInt(JOptionPane.showInputDialog(
                        "Insira o valor da matriz[ " +linha+ " ][ " +coluna+ " ] "));
                soma += m[linha][coluna];
            }
        }
       
//Processamento
       
       
        JOptionPane.showMessageDialog(null,"A soma dos valores da matriz é: " +soma);
        }catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Entre apenas com números!", "ERRO", JOptionPane.ERROR_MESSAGE);
        }
    }
}