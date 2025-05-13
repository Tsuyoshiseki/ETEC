

//author Luã Tsuyoshi Borges Seki

/*O escritório de Despachante Vale Card é uma empresa especializada em 
documentação de veículos atuando diretamente com os órgãos de trânsito. 
Entre suas atividades, está informar para seus clientes o mês de vencimento 
do IPVA de seus veículos. Para isso, o cliente fornece o número final da 
placa do veículo, em seguida deve ser apresentado o mês que o IPVA deve 
ser pago, conforme tabela a seguir:

Placa Final 1 __ Pagamento até 30/04

Placa Final 2 __ Pagamento até 31/05

Placa Final 3 __ Pagamento até 30/06

Placa Final 4 __ Pagamento até 31/07

Placa Final 5 __ Pagamento até 31/08

Placa Final 6 __ Pagamento até 30/09

Placa Final 7 __ Pagamento até 31/10

Placa Final 8 __ Pagamento até 30/11

Placa Final 9 ou 0 __ Pagamento até 31/12
*/

import javax.swing.JOptionPane;

public class Principal {

    public static void main(String[] args) {

        //Variável
        int placa;
        String nome;
                
        //Entrada
        
        nome= JOptionPane.showInputDialog(
                "Despachante Vale Card" + 
                "\nDigite seu nome: ");
        placa= Integer.parseInt(JOptionPane.showInputDialog("Olá "+nome + " insira o final da placa do seu veículo:"));
                
                
        //Processamento

        switch (placa){
            case 1:
                JOptionPane.showMessageDialog(null,"Seu pagamento deve ser feito até o dia 30/04");
                    break;
            case 2:
                JOptionPane.showMessageDialog(null,"Seu pagamento deve ser feito até o dia 30/05");
                    break;
            case 3:
                JOptionPane.showMessageDialog(null,"Seu pagamento deve ser feito até o dia 30/06");
                    break;
            case 4:
                JOptionPane.showMessageDialog(null,"Seu pagamento deve ser feito até o dia 30/07");
                    break;
            case 5:
                JOptionPane.showMessageDialog(null,"Seu pagamento deve ser feito até o dia 30/08");
                    break;
            case 6:
                JOptionPane.showMessageDialog(null,"Seu pagamento deve ser feito até o dia 30/09");
                    break;
            case 7:
                JOptionPane.showMessageDialog(null,"Seu pagamento deve ser feito até o dia 30/10");
                    break;
            case 8:
                JOptionPane.showMessageDialog(null,"Seu pagamento deve ser feito até o dia 30/11");
                    break;
            case 9,0:
                JOptionPane.showMessageDialog(null,"Seu pagamento deve ser feito até o dia 30/12");
                    break;
            default: 
                JOptionPane.showMessageDialog(null,"Valor não condiz");
                    break;
                
        }
    }
    
}
