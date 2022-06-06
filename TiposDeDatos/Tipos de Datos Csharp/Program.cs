using System;


namespace Tipos_de_Datos_Csharp
{
    //Las variables pueden ser declaradas adentro o afuera de un metodo
    public class dataType
    {
        /* En c# tenemos un gran cantidad de tipos de datos, entre ellos tenemos los que ya hemos visto en otros lenguajes como c++
         * pero aun asi vale la pena recapitular cuantos tipos de datos tenemos entre ellos
         * Los tipos de datos numericos:         int tipo de dato entero
                                               // ejem int x = 200000000000
        //Puede contener numero entre -2,147,483,684 y 2,147,482,647 
         *                                       long x = 900000000000000000
         *                                       Numeros entre -9,223,327,036,854,775,808 y 9,223,327,036,854,775,807
         *                           sbyte x = 120;
         *                            Numeros enteros entre el -128 y 127
         *                           short x = 30000
         *                            Numeros enteros entre -32767 y 32767
         * El cuando usar estos diferentes tipos de datos depende de que tan pequeño sea el valor que usemos
         * El otro tipo de datos son:
         *                           float x = 99.99f favor de poner la f al final, si no el compilador va a entender que es double
         *                                            y por eso habra error al mostrar o procesar el tipo de datos
         *                            este tipo de datos tiene una preicision de 7 digitos y un rando bastante amplio
         *                             1.5 x 10**-45 hasta 3.4  10**38
         *                           double x = 1.5 este no nesecita el f al final
         *                            Decimal con mas rango y precision que el float
         *                             Precision de hasta 15 digitos
         *                           decimal x = 1.5
         *                            Decimal con mas rango que el double
         *                             Precision de 28 digitos
         * Cuando usar float, double o decimal entra en el mismo caso
         * aunque el float suele ser usado mas en apps graficas(Juegos)
         * el double para calculos o valores del mundo real(excepto calculos de dinero)
         * y el decimal suele ser usado mas para apps financieras por su alto nivel de precision
         *                          y el otro tipo de datos es el booleano
         *                          bool switch = false
         *                           solo permite 2 valores o estados
         *                            true o false
         *                         luego estan los tipos de datos de caracteres
         *                          char a = 'a' requiere las comillas simples que suelen activarse con alt + 39
         *                           solo permite almacenar un caracter o unicode
         *                          string abc = "PAPA ES EL BICHO" requiere comillas dobles y almacena una cadena de caracteres como una sola
         *                         
         *                           
         *                           
         */

        public class Num
        {
            int Holi = 1;
        }

        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear(); //esto no es nesecario tan solo queria cambiarle el color a la terminal
            double d1;
            double d2;
            d1 = 99.99;
            d2 = 12.2;
            double sumaD = d1 + d2;
            int edad = 18; //Variable de tipo entero
            //creada de manera local porque esta declarado del metodo main y solo la podre usar dentro del metodo main
            int edad2 = 5;
            int sum;
            sum = edad + edad2;
            Console.WriteLine(sum); //ahora ya no me marca la advertencia pq ya tiene valor y ya lo uso
            Console.WriteLine("Ahora vamos a trabajar con doubles o valores decimales");
            Console.WriteLine("Su dato double 1 : " + d1);
            Console.WriteLine("Su dato double 2 : " + d2);
            Console.WriteLine("La suma de estos datos da : " + sumaD);
            //Ahora que pasa si andas loco y quieres sumar un int con un double
            double sumaLocochona = d1 + edad;
            Console.WriteLine("Su desmadre es igual a : "
                + sumaLocochona); //el motivo por el que no da error es porque el resultado de esa suma esta guardado en un double
                                  //En cambio si hubiera sido int hubiera dado error ya que los int no pueden tener decimales 
                                  //en el resultado de la suma ya que no se puede hacer una conversion implicitamente a menos que hagas un casteo(casting)

            //Tambien puede cambiarle el valor asignado a una variable mas adelante
            Console.WriteLine("Ejemplo de cambio o asignacion de valores a cosas ya asignadas ");
            edad = 4;
            Console.WriteLine(edad);
            Console.WriteLine("Ahora trabajaremos con floats");
            float flotante = 4.4f;
            //luego de esto sirve para cualquier operacion es igual las demas operaciones
            Console.WriteLine(flotante + " <--  Este cabron a mi lado es un float");
            Console.WriteLine("Ahora nos meteremos a las variables de tipo de texto");
            string frase = "Hola Mundo";
            string Nombre = "Isaac Espinoza Morales ";
            //Hay un putazo de metodos para las variables, intentar luego ponerlos a jalar 
            Console.WriteLine(frase); //Pudieras concatenar con el + que es lo que vengo haciendo arriba xd
            Console.WriteLine(Nombre); //Parece que c# puede almacenar toda la cadena, no como el otro....
          
            Console.WriteLine(Nombre.ToUpper()/*el toUppper imprime la cadena en mayus*/); //Parece que c# puede almacenar toda la cadena, no como el otro....
            Console.WriteLine(Nombre.ToLower()/*el toLOWER  imprime la cadena en minus*/); //Parece que c# puede almacenar toda la cadena, no como el otro....
            Console.Read();
        }
    }
}
