/*
Roberta deseja fazer um programa que armazene somente três dados de cada um 
dos visitantes de seu restaurante: o nome completo, a cidade e o estado onde 
residem. O programa deve ser capaz de armazenar 100.000 pessoas. 
 */

import javax.swing.JOptionPane;

public class Ag10ex05 {
    public static void main (String[] args){
        
//Variável
        int x = 3;//x = pessoas
        String dados [][]  = new String [x][3];
        String saida = "Nome: ";
        int linha, coluna;

//Entrada
        for(linha=0; linha<x; linha++){
        dados[linha][0] =JOptionPane.showInputDialog("Entre com o NOME: ");
        dados[linha][1] =JOptionPane.showInputDialog("Entre com o CIDADE: ");
        dados[linha][2] =JOptionPane.showInputDialog("Entre com o ESTADO: ");

        }

//Saída
        for(linha=0; linha < x; linha++){ 
            for (coluna=0; coluna < 3; coluna++) { 
                saida = saida.concat(dados[linha][coluna]);
                if (coluna == 0){ 
                    saida= saida.concat("\nCidade: ");
                } 
                if (coluna == 1) { 
                    saida= saida.concat("\nEstado: ");
                }
            }
            JOptionPane.showMessageDialog(null, "Dados:\n" + saida); 
            saida = "Nome: ";        
        }
    }
}
