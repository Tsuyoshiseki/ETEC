
import javax.swing.JOptionPane;


//author Luã Tsuyoshi Borges Seki 

/*
Faça um Programa em Java para realizar comparação de números e informar
o número maior. Para este código será necessário solicitar ao usuário digitar a
quantidade de números que ele quer comparar e ele deverá digitar os números.


*/
public class Principal {

    public static void main(String[] args) {
        //Variável
        int num1, num2;
        
        //Entrada
        num1 = Integer.parseInt(JOptionPane.showInputDialog("Digite um número: "));
        num2 = Integer.parseInt(JOptionPane.showInputDialog("Digite um número: "));
         
        //Processamento
        if(num1>num2){
            JOptionPane.showMessageDialog(null, "O número" +num1+ " é maior que o "+num2);
        }else{
            JOptionPane.showMessageDialog(null, "O número" +num1+ " é menor que o "+num2);
            
            
        }
        }
        
    }
    
