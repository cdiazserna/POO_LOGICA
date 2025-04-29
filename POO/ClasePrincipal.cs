using POO;

public class ClasePrincipal
{
    private static void Main(string[] args)
    {
        //Esta clase principal es la que me instancia las otras clases y
        //es la que se ejecuta de primeras cuando yo corro la aplicación.

        //Variables que usaré para inicializar en los métodos constructores
        //Variables locales.
        string nombre; //Pilsen
        double cantidadMililitros;
        double porcentajeAlcohol;
        bool cantidadAzucar;

        //Esta es la forma de pedir datos por pantalla usando C#
        Console.Write("¿Cuál es el nombre de la bebida? ");
        nombre = Console.ReadLine();

        Console.Write("¿Cuál es la cantidad de ml? ");
        cantidadMililitros = Convert.ToDouble(Console.ReadLine()); //el Convert.To... me convierte el valor al tipo de dato correcto de la variable

        //Creo los dos objetos y los inicializo con el orden correcto en el constructor        
        Cerveza miCerveza = new Cerveza(nombre, cantidadMililitros, 4.5);
        Gaseosa miGaseosa = new Gaseosa(nombre, cantidadMililitros, false);

        //Ahora vamos a mostrar la información:
        Console.WriteLine("Información de la cerveza");
        Console.WriteLine("Nombre: " + miCerveza.Nombre);
        Console.WriteLine("Cantidad de ml: " + miCerveza.CantidadMililitros);
        Console.WriteLine("Cantidad de % alcohol: " + miCerveza.PorcentajeAlcohol);
        Console.WriteLine("¿Es embriagante? " + miCerveza.EsEmbriagante());
        miCerveza.MostrarAlcohol();
        miCerveza.Beber();

        Console.WriteLine("\n\n"); //Salto de línea

        Console.WriteLine("Información de la gaseosa");
        Console.WriteLine("Nombre: " + miGaseosa.Nombre);
        Console.WriteLine("Cantidad de ml: " + miGaseosa.CantidadMililitros);
        miGaseosa.MostrarContenidoAzucar();
        Console.WriteLine("¿Es embriagante? " + miGaseosa.EsEmbriagante());
        miCerveza.Beber();
    }
}
