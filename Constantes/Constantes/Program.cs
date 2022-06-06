using System;

namespace Constantes
{
    //Ya trabajamos con variables osea cosas que pueden alterar su valor durante el programa es hora de trabjar con aquellas que no xd
    class Program
    {
        //Estos no los haremos dentro del metodo, si no dentro de la clase
        //asi de esta manera van a aplicar para todos los metodos
        const double PI = 3.1416; //Este es un valor xd, no es pi exacto
        const int dias = 365;
        const int uno = 1, dos = 2; //Tambien se puede definir varias variables o constantes en la misma linea
        static void Main(string[] args)
        {
            //y ya por si ejemplo quiero cambiar el valor de esa madre me marcara error pq quiero cambiar el valor de una constante
            //se puede hacer constante con todo, string, ints, sbyte, long, double y asi
            Console.WriteLine("El valor de pi es : {0}", PI );//esto es otra forma mamadora de concatenamiento
            Console.WriteLine("El la cantidad de dias en un año es : {0}", dias );//esto es otra forma mamadora de concatenamiento
            //Marca error si le pongo un 1 asi que pongale un 0, el indice de eso siempre debe ser igual o mayor a 0 pero en la mayoria de caso que sea 0 o menor al de mi lista de args
            Console.Read();                        //ese 0 es un parametro que despues con una coma le digo al programa que va a ir ahi 
        }
    }
}
