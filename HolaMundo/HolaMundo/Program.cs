using System; //Importacionde librerias del dll
//A mira jala solo on el System xd
//Comentarios son con //


//Espacio de nombres; el paquete
namespace HolaMundo
{
    //UnaClase
    class Hola
    {
        //el metodo en esta funcion, es estatico, para que asi no se pueda instanciar , osea que solo se cree una vez en memoria de tipo void
        //el main es el metodo de salida, le pasamos unos parametros , en este caso solo ocupo uno que es un array de tipo string al que llamamos args
        static void Main(string[] args)  
        {
            //Console es una clase con sus metodos y atributos disponibles para poder trabajar con la consola, desde el largo de la ventana hasta como escribir en ella
            Console.WriteLine("Hola mundo, lo hice en C# mi primer programa"); //aqui tambien usamos y ocupamos el ;

            //Ahuevito, se escribe al renglon de abajo por lo que parece siempre que este abajo de esta

            Console.WriteLine("Me pregunto si se escribira abajo de ti"); //aqui tambien usamos y ocupamos el ;
            //Invocamos a un codigo existente que viene de system
            //WriteLine da la orden de que se escriba lo que tiene adentro
            //lo de arriba es para poder escribir en consola

            //Hay que darle una linea para que espere
            Console.Read();//esto hace que tenga una orden para que systeme espero una tecla o algo para cerrar el programa
            //Una vez meta lo que quiera le ody enter y se cierra, o puedo darle 2 veces enter 
        }
    }
}
