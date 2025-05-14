/*
Como estudante do Ensino Médio, Paulo deseja fazer um software que realize a 
soma de duas matrizes 4x4.
Ele sabe que, para realizar a soma de duas matrizes, segundo a matemática, 
cada elemento da matriz A deve ser somado ao seu elemento correspondente da 
matriz B, gerando o resultado em uma terceira matriz C.


Dica: Para fazer a soma dessas duas matrizes, deve-se ler as matrizes A e B, 
cada uma de duas dimensões, com 4 linhas e 4 colunas. Construir a matriz C, 
matriz A com os elementos da matriz B e apresentar os elementos da matriz C. 
Soma de matrizes: A[1,1] + B[1,1] = C[1,1].

*/

import javax.swing.JOptionPane;
        
public class Ag10ex04 {
    public static void main (String [] args){
 
//Variável
        int linha, coluna;
        int x = 2;
        int a [][] = new int [x][x];
        int b [][] = new int [x][x];
        int c [][] = new int [x][x];

        
//Entrada

                for(linha=0; linha<x; linha++){
                    for(coluna=0; coluna<x; coluna++){
                        a[linha][coluna] = Integer.parseInt(
                                JOptionPane.showInputDialog("Entre com o elemento [" +linha+ "][" +coluna+"] da Matriz A"));
                
                    }
                }
                
                for(linha=0; linha<x; linha++){
                    for(coluna=0; coluna<x; coluna++){
                        b[linha][coluna] = Integer.parseInt(
                                JOptionPane.showInputDialog("Entre com o elemento [" +linha+ "][" +coluna+"] da Matriz B"));
                    }
                }
                
                for(linha=0; linha<x; linha++){
                    for(coluna=0; coluna<x; coluna++){
                        c[linha][coluna] = a[linha][coluna] + b[linha][coluna];
                    }
                }
                
                for(linha=0; linha<x; linha++){
                    for (coluna=0; coluna<x; coluna++){
                        System.out.println("C[" +linha+ "][" +coluna+ "] = " +c[linha][coluna]);
                    }
    
                }
    }
}
