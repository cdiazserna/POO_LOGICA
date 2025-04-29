namespace POO
{
    public class Bebida
    {
        //Sección de Propiedades de la clase Bebida
        public string Nombre; //Pilsen

        public double CantidadMililitros;
        
        //Sección de métodos:
        //El método constructor siempre lleva el nombre de la clase:

        public Bebida(string nombre, double cantidadMililitros)
        {
            //Y las propiedades se inicializan en el constructor
            Nombre = nombre;
            CantidadMililitros = cantidadMililitros;
        }

        //Un método se compone de: modificador de acceso + tipo de retorno + nombre del método + sección de parámetros
        public void Beber()
        {
            Console.Write("Bebiendo " + Nombre + "...");
        }

        //En este caso, el método de papá que se va a sobreescribir en la clase hija, sí o sí debe llevar
        //la palabra reservada "virtual" para que la clase hija lo pueda sobreescribir.
        public virtual bool EsEmbriagante()
        {
            return false;
        }
    }
}
