using System; //Invoca un chorro de codigo que podemos utiizar para luego xd


//int Num; //De momento no ha jalado lo de incluir variabes globales

namespace _2practicaCsharp //Si algo de codigo esta en blanco es que lo estamos utilizando 
{
    class Practica2
    {
        static void Main(string[] args)
        {
            string Texto; //tiene el mismo tipo de variables como en c++
            Console.ForegroundColor = ConsoleColor.DarkBlue;   //Propiedad que establece el color de la consola en el primer plano, ConsoleColor especific la constante del priemr plano 
            /* En el caso de arriba el ForegroundColor seran los colores de las letras de las consola 
             * Hasta los pishis comentarios son iguales
             * Puedo asiganarle valores a cosas con el igual
             *
             */
            Console.BackgroundColor = ConsoleColor.Cyan; //Si no estoy mal esto sera el color del fondo de pantalla
            //Si y no subrayo el texto en colo cyan xd
            //Si queremos que pinte toda la consola hay que darle una orden mas
            Console.Clear(); //Con esto ya pinta toda la consola con el color que quiero 
            //Esto hace que se limpie las ordenews anteriores y ponga las nuevas, algo que ver con los buffers
            Texto = "Holi"; //Parece que asi se asigana cosas o valores a variables, que pro lo logre y sin videos, ahora a ver videos.
            //Variables locales
            int Num;
            int Num2;
            Num = 1;
            Num2 = 10;
            int NumRes;
            NumRes = Num + Num2;
            //Tambien para usar console puede hacer la misma que en c++ tipo std::cour
            //en este caso System.Console y el metodo o lo que quiero pero que hueva ponerlo siempre no mames xd 
            Console.WriteLine(Texto);
            Console.WriteLine("A continuacion pondre un ejemplo de como no hacer una simple suma: " + Num + Num2 /*Ponerlo de esta manera va a concatenar los numeros osea en esste caso 110 no suma */);
            Console.WriteLine("De momento para sumar se me hace que tendra que sumarse poniendo el resultado en otra variable : " + NumRes /*Esperemos y si */);
            Console.WriteLine("Y si de momento asi se realiza una suma simple en c#");
            
            Console.Read();
            //En console, las cajas son metodos, los rayos son eventos, y las llaves inglesas son propiedades

        }
    }
}
