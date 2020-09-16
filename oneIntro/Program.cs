using System; // usando una Libreria generica

namespace oneIntro   //espacio de nombre (carpeta del proyecto)
{
    class Program   //el archivo donde estoy codificando alguna funcionalidad especifica
    {

        static void Main(string[] args)  // un metodo
        {
            /*
            Console.WriteLine("Hola a todos, como van pues!");  //instrucciones, pasos, tareas, actividades, etc

            Console.WriteLine("Numero uno");
            int numUno = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero dos");
            int numDos = int.Parse(Console.ReadLine());
            */

            /*
            Forma estructurada
            //Console.WriteLine("El numero es: " + numUno);
            //Console.WriteLine( $"El numero es: {numUno}" );

            //int suma = numUno + numDos;
            //Console.WriteLine($"La suma de {numUno} y {numDos} es {suma}");

            Console.WriteLine($"La suma de {numUno} y {numDos} es {numUno + numDos}");
            */

            //Forma Orientada a Objetos
            //Instanciar la class Operaciones (objeto de la class)
            //Class    objeto(instancia) (= new)sonPalabrasReservadas  constructorDeLaClass()
            //Operaciones myOperacion = new Operaciones()
            /*var myOperacion = new Operaciones(){
                numeroUno = numUno,
                numeroDos = numDos
            };
            */


            //verificar (mostrar) el valor que tiene almacenado la propiedad
            //Console.WriteLine(myOperacion.numeroUno);
            
            //Llevar el valor como parametro a un metodo
            //Para hacer esto llamar el metodo de la class
            //mediante su instancia (un objeto)

            //myOperacion.nuestraSuma(myOperacion.numeroUno, myOperacion.numeroDos);
            //myOperacion.imprimirSuma();


            /**
                Ejemplo Hotel
                con OOP                
            */

            Console.WriteLine("Hotel WCG!");

            Console.WriteLine("Cantida Huespedes");
            int huespedes = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre Habitación");
            string nom_hab = Console.ReadLine();

            Console.WriteLine("Días de estadia");
            int cant_dias = int.Parse(Console.ReadLine());
            
            //Instancia

            var hotelUno = new GestionHotel(){
                habitacion = nom_hab,
                huesped = huespedes,
                dias = cant_dias
            };

            hotelUno.cuentaCobro();
        }
    }

}
