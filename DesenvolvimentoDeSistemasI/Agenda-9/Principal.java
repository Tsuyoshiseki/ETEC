


//author Luã Tsuyoshi Borges Seki 

/*

Luana necessita de um programa para o cálculo das médias dos alunos de sua 
escola e música. Para cada módulo do curso, o aluno efetua 5 atividades. 
Caso a média destas atividadesseja maior que 5, o aluno poderá passar para o 
próximo módulo. desenvolva um programa em Java utilizando Vetores que calcule 
a média para os alunos de Luana corretamente.


*/
import javax.swing.JOptionPane;

public class Principal {

    public static void main(String[] args) {
        
       //Variável
       double media = 0;
       double nota[] = new double[5];
       int cont;
       String nome;
       
       
       //Entrada
        nome = JOptionPane.showInputDialog("Digite o nome do aluno:");
        
        for(cont=0; cont<5; cont++){
            nota[cont] = Double.parseDouble(JOptionPane.showInputDialog
                    ("Digite a "+ (cont+1) +" nota do aluno."));
        }
        for(cont=0; cont<5; cont++){
            media = media + nota[cont];
        }

       //Processamento
        media= media/5;
        if(media>=5){
            JOptionPane.showMessageDialog(null,
                    "O aluno "+nome+" tirou média: "+media+ " e foi APROVADO");
        }else{
            JOptionPane.showMessageDialog(null,
                    "O aluno "+nome+" tirou média: "+media+ " e foi REPROVADO");
            
        }
    }
}

