import javax.swing.JOptionPane;

public class Ag10ex03 {
    public static void main(String[] args) {
        // Variáveis
        double[][] notas = new double[10][4];
        double media;
        int linha, coluna;
        StringBuilder resultado = new StringBuilder(); // Usar StringBuilder para a saída

        // Entrada
        JOptionPane.showMessageDialog(null, "Inserindo os valores da matriz");
        try {
            for (linha = 0; linha < 10; linha++) {
                media = 0; // Reinicia a média para cada aluno
                for (coluna = 0; coluna < 3; coluna++) {
                    notas[linha][coluna] = Double.parseDouble(
                        JOptionPane.showInputDialog("Entre a nota " + (coluna + 1) + " do " + (linha + 1) + "º aluno:"));
                    media += notas[linha][coluna]; // Acumula a soma das notas
                }
                // Calcula a média
                notas[linha][3] = media / 3; // Armazena a média na quarta coluna
            }

            // Saída
            resultado.append("Mostrando as menções:\n");
            for (linha = 0; linha < 10; linha++) {
                resultado.append("Aluno ").append(linha + 1).append(":\n");
                for (coluna = 0; coluna < 3; coluna++) {
                    resultado.append("Nota ").append(coluna + 1).append(": ").append(notas[linha][coluna]).append("\n");
                }
                resultado.append("Média: ").append(notas[linha][3]).append("\n\n");
            }

            // Exibe todos os resultados em uma única janela
            JOptionPane.showMessageDialog(null, resultado.toString());
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Entre apenas com números\nEncerrando", "ERRO", JOptionPane.ERROR_MESSAGE);
        }
    }
}
