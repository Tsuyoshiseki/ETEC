import javax.swing.JOptionPane;

public class Ag10ex02 {
    public static void main(String[] args) {

        //Variável
            double num [] [] = new double [4][4];
            int linha, coluna;
            String exibir = "";
            
        //Entrada
        JOptionPane.showMessageDialog (null, "Inserindo os dados na Matriz");
            for (linha = 0; linha < 4; linha++) {
                for (coluna = 0; coluna < 4; coluna++) {
                    num[linha][coluna] = Double.parseDouble(
        JOptionPane.showInputDialog("Entre com o número" + "\nlinha " +linha+ "\ncoluna" +coluna));
 }
}
        JOptionPane.showMessageDialog (null, "Mostrando os dados na Matriz");
            for (linha = 0; linha < 4; linha++) {
                for (coluna = 0; coluna < 4; coluna++) {
                    exibir += num[linha][coluna] + "|";
                }
                exibir+="\n";
                        }
            JOptionPane.showMessageDialog(null, exibir);
}
    }



