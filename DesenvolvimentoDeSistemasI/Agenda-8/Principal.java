


//author Luã Tsuyoshi Borges Seki 

/*

Um cinema possui capacidade de 40 lugares e está sempre com ocupação total. 

Certo dia, cada espectador respondeu a um questionário, no qual constava:

  - idade;

  - opinião em relação ao filme, segundo as seguintes notas:

      A - Ótimo /  B - Bom / C - Regular  / D - Ruim  / E -  Péssimo.

 
Elabore a codificação em JAVA para que leia os dados, calcule e exiba na tela:

- Ler as informações de 40 espectadores (idade e opinião). 

- Quantidade de respostas "ótimo";

- A média de idade das pessoas que responderam "ruim";

- A porcentagem de respostas "péssimo".

- A média geral das notas, considerando:

    "A = 5"  /  "B = 4"  /  "C = 3"  /  "D = 2"  /  "E = 1"


*/

import javax.swing.JOptionPane;

public class Principal {


    public static void main(String[] args) {
        
        //Variável
        int idade;
        int somaidade=0;
        int nota;
        int somanota=0;
        int i;
        int cont_ot=0, cont_bom=0, cont_reg=0, cont_ruim=0, cont_pess=0;
        int cinema = 5;
        String nome;
        

        //Entrada
        for(i=0; i<cinema; i++){
            nome= JOptionPane.showInputDialog("Digite seu nome: ");
        
            idade= Integer.parseInt(JOptionPane.showInputDialog("Digite sua idade: "));
            
            nota = Integer.parseInt(JOptionPane.showInputDialog(
                "Olá "+nome +", como você definiria a qualidade do cinema\n" +
                "\nNota desejada: " +
                "\n1 - Ótimo" +
                "\n2 - Bom" +
                "\n3 - Regular" + 
                "\n4 - Ruim" + 
                "\n5 - Péssimo"));
        

        //Processamento
         switch(nota){
                case 1:
                    cont_ot++;
                    somanota += 5;
                    break;
                case 2:
                    cont_bom++;
                     somanota += 4;
                    break;
                case 3:
                    cont_reg++;
                     somanota += 3;
                    break;
                case 4:
                    cont_ruim++;
                    somaidade+=idade;
                     somanota += 2;
                    break;
                case 5:
                    cont_pess++;
                     somanota += 1;
                    break;
                default:
                    JOptionPane.showMessageDialog(null,
                            "Opção inválida. Tente novamente.");
                    i--;
                    break;
            }
        }
                JOptionPane.showMessageDialog(null,
                "A quantidade de respostas ótimas é: "+ cont_ot +
                "\nA média de idade das pessoas que responderam ruim: " +(somaidade/cinema) +        
                "\nA quantidade de respostas péssimo é: " +(cont_pess*100/cinema)+"%" +
                "\nA média geral das notas, considerando que: " +
                "A = 5, B = 4, C = 3, D = 2, e E = 1: "+somanota/cinema);           
    }                                  
}