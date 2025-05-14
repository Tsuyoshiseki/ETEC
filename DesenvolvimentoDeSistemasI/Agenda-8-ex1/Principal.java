
//author Luã Tsuyoshi Borges Seki 

/*
Faça um Programa em Java que leia 50 números, calcule e exiba a média 
aritmética dele.

*/
public class Principal {

    public static void main(String[] args) {
        //Variável
        int num = 0, soma = 0, cont = 50;
        
        
        //Entrada
        do{
            System.out.println("Número: " +num);
            soma+= num;
            num++;
            
        }
        while (num<=50);
 
        System.out.println("A média aritimética é: "+soma/cont);
        
        //Processamento
        
        }
        
    }
    
