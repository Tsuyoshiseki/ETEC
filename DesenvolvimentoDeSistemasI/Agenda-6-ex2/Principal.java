//author Luã Tsuyoshi Borges Seki

/** 
 Eliberto deseja fazer um menu de seleção de um programa utilizando o 
 comando de seleção múltipla. O menu consiste nas opções de:
1. Cadastrar usuário
2. Alterar dados
3. Excluir Usuário

* Além do menu apresentado na questão anterior, Eliberto precisa fazer alguns submenus com a seguinte
estrutura:
1. Cadastrar usuário
2. Alterar dados
3. Alterar nome
4. Alterar Endereço
5. Alterar telefone
6. Alterar RG
7. Excluir usuário

*/
import javax.swing.JOptionPane;

public class Principal {
    
    public static void main(String[] args) {
        //Variável
        int opcao;
        int submenu;
        
        //Entrada
        opcao = Integer.parseInt(JOptionPane.showInputDialog(
                "Entre com a opção desejada:" +
                "\n1 - Cadastrar usuário" +
                "\n2 - Alterar dados" +
                "\n3 - Excluir usuário"));
        
        //Processamento
        switch (opcao){
            case 1:
                JOptionPane.showMessageDialog(null,"Cadastrando usuário");
                    break;
            case 2:
                submenu = Integer.parseInt(JOptionPane.showInputDialog(
                        "Menu alteração de dados" +
                        "\n Selecione a opção desejada:" + 
                        "\n1 - Alterar nome" +
                        "\n2 - Alterar endereço" +                       
                        "\n3 - Alterar telefone" +
                        "\n4 - Alterar RG" ));
                    
        //2º switch  
        switch (submenu){           
            case 1:
                JOptionPane.showMessageDialog(null,"Alterando nome");
                    break;
            case 2:
                JOptionPane.showMessageDialog(null,"Alterando endereço");
                    break;
            case 3:
                JOptionPane.showMessageDialog(null,"Alterando telefone");
                    break;
            case 4:
                JOptionPane.showMessageDialog(null,"Alterando RG");
                    break;
            default: 
                JOptionPane.showMessageDialog(null,"Opção inválida");
                    break;
        }
                
    }
    }
}
