
namespace POO
{
    public class Gaseosa : Bebida
    {
        //Sección de propiedades de la clase Gaseosa
        public bool TieneAzucar;

        //Sección de métodos:

        //Método Constructor
        public Gaseosa(string nombre, double cantidadMililitros, bool tieneAzucar) : base(nombre, cantidadMililitros)
        {
            TieneAzucar = tieneAzucar;
        }

        public void MostrarContenidoAzucar()
        {
            if (TieneAzucar)
            {
                Console.Write("La bebida " + Nombre + " tiene azúcar.");
            }
            else
            {
                Console.Write("La bebida " + Nombre + " no tiene azúcar.");
            }
        }

        //Aplicamos polimorfismo con el método EsEmbriagante()
        public override bool EsEmbriagante()
        {
            //return false;
            return base.EsEmbriagante(); //Este base me retorna el valor de la clase padre
        }
    }
}
