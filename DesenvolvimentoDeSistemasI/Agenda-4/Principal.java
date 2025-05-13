
import java.util.Scanner;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */

/**
 *
 * @author Luã Tsuyoshi Borges Seki
 */
public class Principal {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
     // OBS: Nenhuma
       
      //Variável
        String modelo;
        String boasvindas;
        double diaria;
        double dias;
        double distancia;
        double total;

    Scanner leitor = new Scanner(System.in);  

      //Comando
        boasvindas = "Olá SPCar!";
        System.out.println(boasvindas);
        
        System.out.println("Digite o Modelo do carro:");
        modelo=leitor.next();
        
        System.out.println("Digite a diária da locação:");
        diaria=leitor.nextInt();
        
        System.out.println("Quantidades de dias de locação:");
        dias=leitor.nextInt();
        
        System.out.println("Quilometragem percorrida:");
        distancia=leitor.nextInt(); 
        
        total= (diaria*dias)+(distancia*0.2);
        
        System.out.println("O valor total da locação do modelo " +modelo + " é R$" +total);
        
    }
    
}
