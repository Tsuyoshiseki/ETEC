import javax.swing.JOptionPane;

public class Ag10ex01 {
    
        public static void main(String[] args) {
            
            //Variável
            int mat[][] = { {1,2}, {3,4} };
                    
            //Processamento
            for (int linha=0; linha<2; linha++) {
                for(int coluna=0; coluna<2; coluna++) {
                    JOptionPane.showMessageDialog(null,
                            "Matriz ["+ linha +"] coluna["+ coluna +"] = "+ mat[linha][coluna]);
                }
            }
            
        }
}
