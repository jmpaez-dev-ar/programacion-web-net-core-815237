namespace m01._3_propiedades_y_metodos_sobrecarga
{
    internal class _3_propiedades_y_metodos_sobrecarga
    {
        // Propiedades:
        // Las propiedades son atributos de una clase que definen sus características.

        // Las propiedades pueden ser de lectura, de escritura o de lectura y escritura. Una propiedad de lectura solo permite obtener el valor de un atributo. Una propiedad de escritura solo permite establecer el valor de un atributo.

        public class Persona
        {
            private string nombre;
            private string apellido;
            private int edad;

            public string Nombre
            {
                get { return nombre; }
                set { if (value != "") nombre = value; }
            }

            public string Apellido
            {
                get { return apellido; }
                set { apellido = value; }
            }

            // Propiedad de solo lectura
            public int Edad
            {
                get { return edad; }
            }


            //public string NombreCompleto()
            //{
            //    return Nombre + " " + Apellido;
            //}

            public string NombreCompleto() => Nombre + " " + Apellido;

            public void Saludar()
            {
                // Edad = 10; // Error: No se puede asignar un valor a una propiedad de solo lectura.
                Console.WriteLine("Hola, soy " + Nombre + " " + Apellido + " y tengo " + Edad + " años.");
            }

            public void Saludar(string mensaje)
            {
                Console.WriteLine(mensaje + " " + Nombre + " " + Apellido + " y tengo " + Edad + " años.");
            }


            // Definiciones de cuerpos de expresión
            // Los cuerpos de expresión son una característica de C# 7.0 que permite definir métodos y propiedades de forma más concisa. Los cuerpos de expresión se definen mediante la palabra clave => seguida de una expresión.

            public class ProductoCuerpoExpresion
            {
                public string Nombre { get; set; }
                public double Precio { get; set; }
                public string Categoria { get; set; }

                public ProductoCuerpoExpresion(string nombre, double precio, string categoria)
                {
                    Nombre = nombre;
                    Precio = precio;
                    Categoria = categoria;
                }

                // Propiedad de cuerpo de expresión para calcular el impuesto sobre el precio del producto
                public double Impuesto => Precio * 0.1;

                // Método de cuerpo de expresión para mostrar la información del producto
                public void MostrarInformacion() => Console.WriteLine($"Nombre: {Nombre}, Precio: {Precio}, Categoría: {Categoria}");
            }

            //  LAS PROPIEDADES AUTOIMPLEMENTADAS
            // Las propiedades autoimplementadas son propiedades que no tienen lógica adicional en los métodos get y set. Las propiedades autoimplementadas se definen mediante la palabra clave property seguida de un tipo de dato y un nombre de propiedad.
            // Las propiedades autoimplementadas son útiles cuando no se necesita realizar ninguna validación o lógica adicional en los métodos get y set de una propiedad.
            public class Producto
            {
                public string Nombre { get; set; } = "Producto";
                public double Precio { get; set; } = 0.0;
                public string Categoria { get; set; } = "Sin categoría";
            }

            // propiedades de solo lectura:
            // Las propiedades de solo lectura son propiedades que solo tienen un método get y no tienen un método set. Las propiedades de solo lectura se definen mediante la palabra clave property seguida de un tipo de dato, un nombre de propiedad y un método get.

            public class ProductoReadOnly
            {
                private readonly string _connectionString;

                public string Nombre { get; }
                public double Precio { get; }
                public string Categoria { get; }

                public ProductoReadOnly(string ConnectionString)
                {
                    _connectionString = ConnectionString;
                }
                //public void Inicializar()
                //{
                //    _connectionString = "";
                //}
            }

            // Firmas de métodos:
            // La firma de un método es la combinación de su nombre y los tipos y órdenes de sus parámetros. Dos métodos no pueden tener la misma firma en una clase, ya que esto causaría una ambigüedad en la llamada al método.

            public class Vendedor
            {
                public string Nombre { get; set; }
                public string Apellido { get; set; }
                public int Edad { get; set; }
                public string Puesto { get; set; }
                public double Salario { get; set; }

                public void Saludar()
                {
                    Console.WriteLine("Hola, soy " + Nombre + " " + Apellido + " y tengo " + Edad + " años.");
                }

                public void Saludar(string mensaje)
                {
                    Console.WriteLine(mensaje + " " + Nombre + " " + Apellido + " y tengo " + Edad + " años.");
                }
            }

            // Sobrecarga de métodos:
            // La sobrecarga de métodos es la capacidad de definir varios métodos con el mismo nombre en una clase, siempre y cuando tengan firmas diferentes. Esto permite que los métodos realicen tareas similares con diferentes tipos de datos.

        }
    }
}
