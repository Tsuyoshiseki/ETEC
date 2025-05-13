
import javax.swing.JOptionPane;
      
       
//author Luã Tsuyoshi Borges Seki
 
public class Principal {

    public static void main(String[] args) {
        
    //Variável
        String boasvindas;
        int valor;
        int valor5;
        int valor10;
        int valor15;
        int desconto5;
        int desconto10;
        int desconto15;
        
    //Entrada
        boasvindas= "Olá,";
        System.out.println(boasvindas);
        
        valor= Integer.parseInt(JOptionPane.showInputDialog("Digite o valor da venda"));

        
    //Cálculo
        desconto5= valor*5/100;
        desconto10= valor*10/100;
        desconto15= valor*15/100;
        
        valor5= valor-desconto5;
        valor10= valor-desconto10;
        valor15= valor-desconto15;

        
    //Processamento
            if(valor < 200){
                JOptionPane.showMessageDialog(null, "O desconto total da compra foi de 5% totalizando o valor de R$"+valor5+",00");
        }else{
            if(valor >=200 && valor<300){
                JOptionPane.showMessageDialog(null, "O desconto total da compra foi de 10% totalizando o valor de R$"+valor10+",00");
        }else{
             if(valor>=300){
                JOptionPane.showMessageDialog(null, "O desconto total da compra foi de 15% totalizando o valor de R$"+valor15+",00");

             }
         }
             
         }
            
         }
}    