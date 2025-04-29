namespace POO
{
    public class Cerveza : Bebida
    {
        //Sección de propiedades de la clase Cerveza
        public double PorcentajeAlcohol;

        //Sección de métodos:
        //Método Constructor

        public Cerveza(string nombre, double cantidadMililitros, double porcentajeAlcohol) : base(nombre, cantidadMililitros)
        {
            PorcentajeAlcohol = porcentajeAlcohol;
        }

        public void MostrarAlcohol()
        {
            //Console.Write("La cerveza " + Nombre + " tiene " + PorcentajeAlcohol + "% de alcohol.");
            Console.Write(String.Format("La cerveza {0} tiene {1}% de alcohol.", Nombre, PorcentajeAlcohol));
        }

        //El método EsEmbriagante() se sobreescribe para la clase Cerveza
        //Hay dos palabras reservadas para aplicar polimorfismo: Override y Virtual
        //La palabra Override se utiliza para sobreescribir un método de una clase base, o sea que va
        //en el método heredado de la clase hija:
        public override bool EsEmbriagante()
        {
            //Aquí voy a sobreescribir la lógica, porque papá retorna un "false", pero este hijo
            //debe retornar un "true".
            return true;
        }
    }
}
