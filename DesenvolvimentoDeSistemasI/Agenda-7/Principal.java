
//author Luã Tsuyoshi Borges Seki ♠

/*O programa deve solicitar  a digitação do nome, idade e opinião do 
entrevistado sobre o atendimento prestado, sendo: 1-EXCELENTE, 2-BOM ou 3-RUIM. 
A pesquisa deve ser feita com 50 entrevistados e o no final, o programa deverá 
exibir na tela:

a. quantidade de respostas “EXCELENTE”

b. quantidade de respostas “RUIM

Observações: utilizar a estrutura de decisão para verificação da opinião e 
realizar testes com 10 entrevistados.

*/

import javax.swing.JOptionPane;


public class Principal {

    public static void main(String[] args) {

        //Variável
        String nome;
        int idade;
        int nota;
        int i;
        int cont_ex=0,cont_bom=0,cont_ruim=0;
                
        //Entrada
        for (i=1; i<=50;i++){
        nome = JOptionPane.showInputDialog(
                "TudoWeb \n \n Digite seu nome: ");
        
        idade = Integer.parseInt(JOptionPane.showInputDialog(
                "TudoWeb \n \n Digite sua idade: "));
        
        nota = Integer.parseInt(JOptionPane.showInputDialog(
                "Olá "+nome+" como você definiria a qualidade do serviço da TudoWeb" +
                "\nDigite a operação desejada: " +
                "\n1 - Excelente" +
                "\n2 - Bom" + 
                "\n3 - Ruim"));
        
        //Processamento
            switch(nota){
                case 1:
                    cont_ex++;
                    break;
                case 2:
                    cont_bom++;
                    break;
                case 3:
                    cont_ruim++;
                    break;
                default:
                    JOptionPane.showMessageDialog(null,
                            "Opção inválida. Tente novamente.");
                    i--;
                    break;
            }
        }
                    JOptionPane.showMessageDialog(null,
                    "A quantidade de respostas excelentes é: "+ cont_ex +
                    "\nA quantidade de respostas boas é: " + cont_bom +        
                    "\nA quantidade de respostas excelentes é: " +cont_ruim);           
    }                     
}
        
        
   
