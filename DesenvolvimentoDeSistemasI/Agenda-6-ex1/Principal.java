
//author Luã Tsuyoshi Borges Seki

// Vanessa precisa desenvolver um programa em que ao se digitar o código de um produto cadastrado da
// papelaria "Lápis Colorido" este retorne o nome do produto. Se o código do produto não estiver
// cadastrado, o programa deve exibir a mensagem produto não cadastrado. A tabela a seguir descreve os
//códigos e os produtos cadastrados:

import javax.swing.JOptionPane;

public class Principal {

    public static void main(String[] args) {
        //Variável
        int opcao;
                
        //Entrada
        opcao = Integer.parseInt(JOptionPane.showInputDialog("Entre com o código do produto:"));
        
        //Processamento
        switch (opcao) { 
            
        case 100: 
            JOptionPane.showMessageDialog(null, "O produto selecionado é Lápis preto nº2"); 
                break;                 
        case 150: 
            JOptionPane.showMessageDialog(null, "O produto selecionado é Borracha branca"); 
                break; 
        case 200: 
            JOptionPane.showMessageDialog(null, "O produto selecionado é Caneta azul"); 
                break; 
        case 230: 
            JOptionPane.showMessageDialog(null, "O produto selecionado é Caneta vermelha"); 
                break; 
        case 256: 
            JOptionPane.showMessageDialog(null, "O produto selecionado é Giz de cera 12 unid."); 
                break; 
        case 300: 
            JOptionPane.showMessageDialog(null, "O produto selecionado é Cartolina branca"); 
                break; 
        case 310: 
            JOptionPane.showMessageDialog(null, "O produto selecionado é Resma de sulfite A4"); 
                break; 
        case 400: 
            JOptionPane.showMessageDialog(null, "O produto selecionado é estojo escolar verde"); 
                break; 
        case 470: 
            JOptionPane.showMessageDialog(null, "O produto selecionado é caderno univrsitário 100 fls."); 
                break; 
        case 500: 
            JOptionPane.showMessageDialog(null, "O produto selecionado é caderno brochura 50f1s.");
                break; 
        case 5:
            JOptionPane.showMessageDialog(null, "Moreca é xuxu e passou Uhulll"); 
                break; 
        default: 
            JOptionPane.showMessageDialog(null, "Produto não cadastrado!"); 
                break;
    }
    }
}
