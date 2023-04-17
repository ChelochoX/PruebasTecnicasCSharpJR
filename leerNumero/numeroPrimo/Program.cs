
using System;

namespace numeroPrimo
{

    class Program
    {
        public static int leerNumero()
        {
          int numero = 0;
          bool valido = false;
          while (!valido)
          {
            Console.WriteLine("Ingrese un numero entero mayor a cero");
            var valorEntrada = Console.ReadLine();
            valido = int.TryParse(valorEntrada,out numero);
            if(!valido)
              Console.Write("El numero ingresado no es valido");
          }
        return numero;
        }

        public static bool esNumeroPrimo(int valor)
        {
          for(int i=valor-1; i>1;i--)
          {
            if(valor % i == 0)
             return false;
          }
          return true;
        }

      static void Main(string[] args)
      {
        int valor = leerNumero();
        var esPrimo = (esNumeroPrimo(valor)) ? "El valor ingresado es un numero primo" + valor : "El valor ingresado NO es un numero primo " + valor;

        Console.Write(esPrimo);

      }

    }


}
