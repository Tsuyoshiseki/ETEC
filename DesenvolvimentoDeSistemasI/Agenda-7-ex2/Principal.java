
//author Luã Tsuyoshi Borges Seki 

/*

Giovanna adora usar computador, navegar na internet e matemática. 
Ela decidiu estudar tabuada devido a sua dificuldade durante o período de aula 
(ela apenas sabe as tabuadas dos números 0 até 05).

Ao navegar na internet, aprendeu a desenvolver alguns algoritmos e decidiu 
desenvolver algo para ajudá-la em seus estudos com tabuada.

Escreva para Giovanna um Programa em Java da Tabuada dos números 6 até 10.


*/

public class Principal {
    
    public static void main(String[] args) {

        for (int i = 6; i <= 10; i++) {
            System.out.println("Tabuada do " + i + ":");
            for (int j = 1; j <= 10; j++) {
                int resultado = i * j;
                System.out.println(i + " x " + j + " = " + resultado);
            }
            System.out.println();
        }
    }

    }
    