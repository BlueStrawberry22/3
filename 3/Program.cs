using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            double areacirculo, pi, r;
            double areatriangulo, Btriangulo, Htriangulo;
            double areatrapezio, Btrapezio, bmtrapezio, Htrapezio;
            int resposta;
           

            Console.Write("Lista de figuras calculáveis: \n1. Circulo\n2. Triângulo\n3. Trapézio\nEscolha uma forma para calcular a área: ");
            resposta = int.Parse(Console.ReadLine());
            Console.WriteLine();
           
            
            
            switch (resposta)
            {
                case 1:
                    pi = 3.14;
                   
                    Console.Write("Insira o raio do círculo em cm: "); 
                    r = double.Parse(Console.ReadLine());
                    areacirculo = pi * r;
                    Console.Write("A área do círculo é= " + areacirculo + "cm²" );
                   
                    break;

                case 2:
                    Console.Write("Digite a base do triângulo em cm: ");
                    Btriangulo = double.Parse(Console.ReadLine());
                    Console.Write("Agora, digite a altura do triângulo: ");
                    Htriangulo = double.Parse(Console.ReadLine());
                    areatriangulo = (Btriangulo * Htriangulo) / 2;
                    Console.Write("A área do triângulo é: " + areatriangulo + "cm²");
                   
                    break;
                case 3:
                    Console.Write("Digite a base maior do trapézio em cm: ");
                    Btrapezio = double.Parse(Console.ReadLine());
                    Console.Write("Agora, digite a base menor do trapézio em cm: ");
                    bmtrapezio = double.Parse(Console.ReadLine());
                    Console.Write("Por fim, digite a altura do trapézio, também em cm: ");
                    Htrapezio = double.Parse(Console.ReadLine());
                    areatrapezio = ((Btrapezio + bmtrapezio)* Htrapezio) / 2;
                    Console.Write("A área do trapézio é: " + areatrapezio + "cm²");
               
                    break;
                default:
                    Console.Write("O valor inserido não é válido.");
                    break;
            }
            Console.ReadKey();

        }
        }
    }
