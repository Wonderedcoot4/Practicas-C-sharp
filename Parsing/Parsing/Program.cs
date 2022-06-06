using System;


namespace Parsing
{
    //Qur putas es el parsing
    /*
     *   El parsing es un metodo o forma por el cual puedo convertir variables de tipo string a int 
     * 
     *   Digamos que es la forma de ver como convertir una variable tipo string de nombre isaac a no se 1 ahorita veremos
     * 
     * 
     * */

    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "15"; //si en vez de 15 pusiera 5a, ya no pudiera transformar esto con un parse, y el compilador me dira que hay un error y que el codigo o se ejecuta en la consola
            string cadena2 = "10";

            //supongamos que se me ocurre la loca idea de hacer una suma de estos
            //creo una cadena que guarde mi desmadre
            string cadena3 = cadena + cadena2;
            Console.WriteLine(cadena3/*Nos concateno el pedo*/);
            //Para estas cuestiones realizamos un proceso de parsing, donde vamos a alojar mi string transformado
            int n1 = Int32.Parse(cadena); //traduce un string en un numero
            int n2 = Int32.Parse(cadena2);
  
            int res = n1 + n2;
            Console.WriteLine(res); //Ahora si hizo la operacion de manera correcta 
            //Tryparse nos indica si una conversion se puede hacer o no, nos regresa un bool ya que no todos los string se pueden transformar
            /*Representaciones de un numero entero tipos de datos que permite almacernarnlos como signo*/
            Console.Read();
        }
    }
}
