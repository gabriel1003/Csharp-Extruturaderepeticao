using System;
using System.Collections.Generic;

namespace Csharp_Extruturaderepeticao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i+=2)
            //Console.WriteLine($"o valor de 1 é: {i}");

//criando um lup infinito.

            //while (true)
            //Console.Write("oi besta.");

//construindo um while.

// int contador = 0;
// while (contador < 5)
// {
//     Console.WriteLine($" o contador do while é : {contador} ");
//     contador++;
// }

//criando um do while.

//do 
{//
    //Console.WriteLine($"o contador do do while é : {contador} ");
    //contador++;
}
//while (contador < 10);

//criando uma lista.

// List<string> listaNomes = new();
// listaNomes.Add("Gabriel Samersla");
// listaNomes.Add("Tiago Merçoni");
// listaNomes.Add("Silvana Samersla");
// listaNomes.Add("Larissa ");
// foreach(string nome in listaNomes)
// Console.WriteLine($"o nome da lista é : {nome}");

//usando try catch para imprimir fazer os tratamentos de erro.

try
{
Console.WriteLine("digite um número: ");
int numero = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine($"burro : {ex.Message} ");
}
         }
    }
}