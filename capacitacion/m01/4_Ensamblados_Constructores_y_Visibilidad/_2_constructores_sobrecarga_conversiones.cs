using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m01._4_Ensamblados_Constructores_y_Visibilidad
{
	public static class _2_constructores_sobrecarga_conversiones
	{

		// Variables de instancia:
		// Las variables de instancia son variables que pertenecen a una instancia específica de una clase. Las variables de instancia se definen con la palabra clave public, protected, private o internal. Las variables de instancia se acceden a través de una referencia a la instancia.


		// Variables de miembros estáticos:
		// Las variables de miembros estáticos son variables que pertenecen a la clase en lugar de a una instancia específica de la clase. Las variables de miembros estáticos se definen con la palabra clave static. Las variables de miembros estáticos se acceden a través del nombre de la clase.

		class Persona
		{
			public static int Contador;

            public Persona()
            {
                 Contador++;
			}
            public string Nombre { get; set; }
			public string Apellido { get; set; }
			
			public int Edad { get; set; }

			private string nombrecompleto;

			public void Saludar()
			{
				nombrecompleto = Nombre + " " + Apellido;
				Console.WriteLine("Hola, soy " + nombrecompleto + " y tengo " + Edad + " años." + Contador);
			}
		}

		public static void DemoVariables()
		{
			Persona persona1 = new Persona();
			persona1.Nombre = "Juan";
			persona1.Apellido = "Perez";
			persona1.Edad = 30;
			persona1.Saludar();

			Persona persona2 = new Persona();
			persona2.Nombre = "Maria";
			persona2.Apellido = "Gomez";
			persona2.Edad = 25;
			persona2.Saludar();
		}

		// Constantes:
		// Las constantes son valores que no cambian durante la ejecución de un programa. Las constantes se definen con la palabra clave const. Las constantes se utilizan para definir valores que son conocidos en tiempo de compilación y que no cambian durante la ejecución de un programa.

		private const decimal IVA = 21.00m;


		// Campos:
		// Los campos son variables que almacenan datos. Los campos se definen con la palabra clave field. Los campos se utilizan para almacenar datos que son específicos de una instancia de una clase.

		// Propiedades:
		// Las propiedades son atributos de una clase que definen sus características. Las propiedades se definen con la palabra clave property. Las propiedades se utilizan para encapsular los campos y proporcionar un acceso controlado a ellos.

		public class Cliente()
		{
			private string nombreCliente;
            public string  Codigo { get; set; }
        }

		// Indexadores (indexers):
		// Los indexadores son propiedades que permiten acceder a los elementos de una colección mediante un índice. Los indexadores se definen con la palabra clave this y pueden tener uno o varios parámetros.

	}

    public class  OtrosConceptos
    {
		private string[] clientes = new string[10];
		private string[] vendedores = new string[10];

		public string this[int index]
		{
			get { return clientes[index]; }
			set { clientes[index] = value; }
		}

		// Métodos:
		// Los métodos son funciones que definen el comportamiento de una clase. Los métodos se definen con la palabra clave method. Los métodos se utilizan para realizar operaciones sobre los datos de una clase.

		// modificadores ref:
		// El modificador ref se utiliza para pasar un argumento por referencia a un método. El modificador ref se utiliza para permitir que un método modifique el valor de una variable que se pasa como argumento.

		public void ModificarNombreRef(ref string nombre)
		{
			nombre = "Nuevo nombre";
		}

		public void DemoRef()
		{
			string nombre = "Antiguo nombre";
			ModificarNombreRef(ref nombre);
			Console.WriteLine(nombre);
		}


		// modificadores out:
		// El modificador out se utiliza para devolver un valor desde un método. El modificador out se utiliza para permitir que un método devuelva múltiples valores.

		public void ObtenerNombreOut(out string nombre)
		{
			nombre = "Juan Perez";
		}

		public void DemoOut()
		{
			string nombre;
			ObtenerNombreOut(out nombre);
			Console.WriteLine(nombre);
		}


		// Sobrecarga de métodos:
		// La sobrecarga de métodos es la capacidad de definir varios métodos con el mismo nombre pero con diferentes parámetros. La sobrecarga de métodos se utiliza para proporcionar una interfaz consistente y fácil de usar para los usuarios de una clase.

        public void AgregarVendedor(string nombre)
		{
			// Agregar vendedor a la lista de vendedores
		}

		public void AgregarVendedor(string nombre, string codigo)
		{
			// Agregar vendedor a la lista de vendedores con código
		}


		public int Suma(params int[] intArr)
		{
			int sum = 0;
			foreach (int i in intArr) sum += i;
			return sum;
		}

		public void DemoParametros()
		{
			int sum1 = Suma(13, 87, 34);
			Console.WriteLine(sum1);

			int sum2 = Suma(13, 87, 34, 6);
			Console.WriteLine(sum2);
		}

        // Constructores:
        // Un constructor es un método especial que se utiliza para inicializar una instancia de una clase. Los constructores tienen el mismo nombre que la clase y no tienen tipo de retorno.

        public OtrosConceptos()
        {
        }


		// Destructor:
		// Un destructor es un método especial que se utiliza para liberar los recursos utilizados por una instancia de una clase. Los destructores tienen el mismo nombre que la clase precedido por el signo ~ y no tienen parámetros ni tipo de retorno.

		~OtrosConceptos()
		{
			// Destructor
		}

	}
}
