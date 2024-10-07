using m01._4_Ensamblados_Constructores_y_Visibilidad;

namespace m01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola, bienvenidos a .Net 8!");

			OtrosConceptos otrosConceptos = new OtrosConceptos();
            //otrosConceptos.DemoRef();

            otrosConceptos.DemoOut();

			Console.ReadLine();
		}
    }
}
