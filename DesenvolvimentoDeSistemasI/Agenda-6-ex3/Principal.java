

//author Luã Tsuyoshi Borges Seki

/**Crie um programa para uma calculadora com cinco operações básicas (soma, subtração, multiplicação,
divisão e resto da divisão) em que dois números reais devem ser inseridos e, posteriormente, em um menu, o
usuário escolha qual operação deve ser realizada. Após a execução da operação selecionada o resultado deve
ser apresentado na tela do computador.
*/

import javax.swing.JOptionPane;

public class Principal {
    
    public static void main(String[] args) {

        //Variável
        int num1;
        int num2;
        int opcao;
        double adicao;
        double subtracao;
        double multiplicacao;
        double divisao;
        double resto;
        
        //Entrada
        num1 = Integer.parseInt(JOptionPane.showInputDialog("Digite um número"));
        num2 = Integer.parseInt(JOptionPane.showInputDialog("Digite um número"));
        opcao = Integer.parseInt(JOptionPane.showInputDialog
                ("Digite a operação desejada: " +
                "\n1 - Adição (+)" +
                "\n2 - Subtração (-)" + 
                "\n3 - Multiplicação (*)" +
                "\n4 - Divisão (/)" + 
                "\n5 - Resto da divisão ($)"));
        adicao= num1+num2;
        subtracao= num1+num2;
        multiplicacao= num1*num2;
        divisao= num1/num2;
        resto= num1%num2;
        
        //Processamento
        switch (opcao){
             case 1:
                JOptionPane.showMessageDialog(null,"A adição da conta: "+num1 +" + "+num2 +" é "+adicao);
                    break;
            case 2:
                JOptionPane.showMessageDialog(null,"A subtração da conta: "+num1 +" - "+num2 +" é "+subtracao);
                    break;
            case 3:
                JOptionPane.showMessageDialog(null,"A multiplicação da conta: "+num1 +" * "+num2 +" é "+multiplicacao);
                    break;
            case 4:
                JOptionPane.showMessageDialog(null,"A divisão da conta: "+num1 +" / "+num2 +" é "+divisao);
                    break;
            case 5:
                JOptionPane.showMessageDialog(null,"O resto da conta: "+num1 +" $ "+num2 +" é "+resto);
                    break;
            default:
                JOptionPane.showMessageDialog(null,"Operação inválida");
                    break;    
        }
       

                
    }
    
}
