using System;

namespace MiPrimerProyectoCSharp1
{

// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hola Mundo 2!");
//         }
//     }
// }

//!_______________________________________________________________________________________

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         for (int i = 0; i < 10; i++)
//         {
//             Console.WriteLine("El valor de i es: " + i);
//         }
//     }
// }

//!__________________________________________________________________________________________________________________

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int num1 = 5;
//         int num2 = 10;
//         int suma = num1 + num2;
//         Console.WriteLine("La suma de " + num1 + " y " + num2 + " es: " + suma);
//     }
// }



//* Sintaxis:

  class Program
  {
      static void Main(string[] args)
      {
  //       // Variables:
  //     int numeroEntero = 0;
  //     decimal numeroDecimal = 1.7M;
  //     string cadenaDeTexto = "Jose";
  //     bool verdaderoFalso = true;

  //     //Arreglos:
  //     int[] numerosEnteros = new int [5]; // [00000]
  //     int[] numeros = {1,2,3,4,5,6};
  //     string[] cantidadNombres = new string[5];
  //     string[] nombresFamilia = {"Jose", "Yohana", "Hanna", "Dora", "Asceneth"};

  //     //Entrada y Salida Consola
  //     Console.ReadLine();
  //     Console.WriteLine("Hello, World");

  //     //consicionales

  //       int numeroAlAzar = 5;

  //     if (numeroAlAzar < 20.0)
  //     {
  //         Console.WriteLine("Cold.");
  //     }
  //     else
  //     {
  //         Console.WriteLine("Hot!");
  //     }

  //     Console.WriteLine("Escriba algo aqui:");

  //     string entrada = Console.ReadLine();

  //     int numero;

  //     if (int.TryParse(entrada, out numero)){
  //       Console.WriteLine("Eso es un numero");
  //     } 
  //     else{
  //       Console.WriteLine("Eso es una cadena de texto");
  //     }

  //     Console.WriteLine("Uste escribio:" + entrada);

  int[] numeros = {2,3,4,5,6};
  int suma = 0;

    for (int i = 0; i < numeros.Length; i++)
    {
    suma += numeros[i];
    }
      Console.WriteLine(suma);
     }
   }
}
