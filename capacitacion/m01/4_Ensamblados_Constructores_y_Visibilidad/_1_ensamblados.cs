namespace m01._4_Ensamblados_Constructores_y_Visibilidad
{
	internal class _1_ensamblados 
	{
		// Ensamblados:
		// Un ensamblado es un archivo que contiene un conjunto de tipos y recursos que forman una unidad lógica y funcional en .NET. Los ensamblados pueden ser de dos tipos: ensamblados de ejecución y ensamblados de biblioteca.


		// Using:
		// La directiva using se utiliza para importar un espacio de nombres en un archivo de código. La directiva using permite utilizar tipos y miembros de un espacio de nombres sin tener que calificarlos con el nombre completo.

		// La directiva using se puede utilizar en un archivo de código o en un bloque de código. La directiva using se puede utilizar para importar un espacio de nombres específico o todos los espacios de nombres de un ensamblado.


		// using System;
		// using System.Collections.Generic;
		// using System.Linq;


		// Using Como instrucción:
		// La instrucción using se utiliza para crear un ámbito en el que se pueden utilizar recursos de forma segura. La instrucción using se utiliza para liberar recursos no administrados, como archivos, conexiones de red y conexiones de base de datos.

		/*
		class Program
		{
			static void Main(string[] args)

			{
				using (var conexion = new SqlConexion())
				{
					var cliente = new Cliente();
					cliente.Nombre = "Juan";
					cliente.Apellido = "Perez";
					cliente.Direccion = "Calle 123";
					cliente.Telefono = "555-1234";
					cliente.Saludar();
				}
			}
		}
		*/
	}
}
