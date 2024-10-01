namespace m01._2_tipos_y_clases_herencia
{
    internal class _2_tipos_y_clases_herencia
    {

        // Los tipos en C# son:

        // Tipo clase: Las clases son tipos de referencia que encapsulan datos y comportamientos relacionados. Las clases se definen mediante la palabra clave class y pueden contener campos, propiedades, métodos, eventos y constructores.

        // Las clases son tipos de referencia porque almacenan la dirección de memoria de los objetos en lugar de los datos reales. Cuando se crea una instancia de una clase, se asigna memoria en el montón y se devuelve la dirección de memoria de la instancia.

        // Tipo estructura: Las estructuras son tipos de valor que encapsulan datos relacionados. Las estructuras se definen mediante la palabra clave struct y pueden contener campos, propiedades, métodos y constructores.

        // Las estructuras son tipos de valor porque almacenan los datos reales en lugar de la dirección de memoria de los objetos. Cuando se crea una instancia de una estructura, se asigna memoria en la pila y se almacenan los datos reales de la instancia.

        public struct Factura
        {
            public int Numero { get; set; }
            public DateTime Fecha { get; set; }
            public double Total { get; set; }
        }

        // Tipo interfaz: Las interfaces son tipos de referencia que definen un contrato que deben cumplir las clases que las implementan. Las interfaces se definen mediante la palabra clave interface y pueden contener propiedades, métodos, eventos y indexadores.

        // Porque usar interfaces: Las interfaces permiten definir un contrato que deben cumplir las clases que las implementan. Esto promueve la cohesión y el bajo acoplamiento, ya que las clases pueden interactuar entre sí mediante interfaces en lugar de depender de implementaciones concretas.


        // Que es cohesión?: La cohesión es un principio de diseño de software que se refiere a la medida en que los elementos de un módulo están relacionados entre sí. Una alta cohesión indica que los elementos de un módulo están fuertemente relacionados y trabajan juntos para lograr un objetivo común. Una baja cohesión indica que los elementos de un módulo están débilmente relacionados y realizan tareas independientes.

        // Que es acoplamiento?: El acoplamiento es un principio de diseño de software que se refiere a la medida en que los módulos de un sistema dependen entre sí. Un bajo acoplamiento indica que los módulos de un sistema son independientes y pueden modificarse sin afectar a otros módulos. Un alto acoplamiento indica que los módulos de un sistema están fuertemente interconectados y cualquier cambio en un módulo puede afectar a otros módulos.

        // Que es un contrato: Un contrato es un conjunto de reglas y especificaciones que definen cómo deben interactuar dos o más partes. En el contexto de la programación orientada a objetos, un contrato es un conjunto de métodos y propiedades que deben ser implementados por las clases que lo firman.

        public interface IPersona
        {
            string Nombre { get; set; }
            string Apellido { get; set; }
            int Edad { get; set; }

            void Saludar();
        }

        // Tipo enumeración: Las enumeraciones son tipos de valor que representan un conjunto de constantes con nombre. Las enumeraciones se definen mediante la palabra clave enum y pueden contener campos, propiedades, métodos y constructores.

        public enum Categoria
        {
            Alimentos,
            Bebidas,
            Ropa,
            Tecnologia
        }

        // Tipo delegado: Los delegados son tipos de referencia que representan referencias a métodos. Los delegados se definen mediante la palabra clave delegate y pueden contener métodos y constructores.

        // Todas las clases heredan de System.Objet y pueden heredar de una sola clase base. Las clases pueden implementar múltiples interfaces.

        // Que es la clase System.Object: La clase System.Object es la clase base de todas las clases en el marco de trabajo de .NET. La clase System.Object define los miembros comunes que todas las clases heredan, como los métodos Equals, GetHashCode y ToString.


        // CLASES Y OBJETOS EN POO

        // Clase: Una clase es una plantilla que define la estructura y el comportamiento de un tipo de objeto. Las clases encapsulan los atributos y métodos que definen las propiedades y el comportamiento de los objetos.

        public class Persona
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Edad { get; set; }

            public void Saludar()
            {
                Console.WriteLine("Hola, soy " + Nombre + " " + Apellido + " y tengo " + Edad + " años.");
            }
        }

        // Clase derivada:
        // La clase derivada es la clase que hereda los atributos y comportamientos de la clase base. Una clase puede tener múltiples clases derivadas.
        public class Empleado : Persona
        {
            public string Puesto { get; set; }
            public double Salario { get; set; }

            public void Trabajar()
            {
                Console.WriteLine("Estoy trabajando como " + Puesto + " y mi salario es de " + Salario + " dólares.");
            }
        }
        public void DemoClase()
        {             
            // Objeto: Un objeto es una instancia de una clase. Los objetos se crean a partir de una clase mediante la palabra clave new y pueden acceder a los atributos y métodos de la clase.

            Persona Persona1 = new Persona();
            Persona1.Nombre = "Juan";
            Persona1.Apellido = "Perez";
            Persona1.Edad = 30;
            Persona1.Saludar();

            Persona Persona2 = new Persona();
            Persona2.Nombre = "Maria";
            Persona2.Apellido = "Gomez";
            Persona2.Edad = 25;
            Persona2.Saludar();
        }

        // Miembros de una clase:
        // Los miembros de una clase son los atributos y métodos que definen las propiedades y el comportamiento de los objetos.


        // PROPIEDES DE LA POO

        // Herencia:
        // La herencia permite crear nuevas clases a partir de clases existentes, heredando sus atributos y comportamientos. Esto promueve la reutilización de código y facilita la creación de jerarquías de clases que reflejan relaciones del mundo real.



        // Clase abstracta:
        // Una clase abstracta es una clase que no puede ser instanciada y que puede contener métodos abstractos. Los métodos abstractos son métodos que no tienen implementación y deben ser implementados por las clases derivadas.

        public abstract class PersonaAbstracta
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Edad { get; set; }

            public abstract void Saludar();
        }
        public class Cliente : PersonaAbstracta
        {
            public string Direccion { get; set; }
            public string Telefono { get; set; }

            public override void Saludar()
            {
                Console.WriteLine("Hola, soy " + Nombre + " " + Apellido + " y soy un cliente.");
            }
        }
        // Clase sellada:
        // Una clase sellada es una clase que no puede ser heredada. Las clases selladas se definen mediante la palabra clave sealed.

        public sealed class Vendedor : PersonaAbstracta
        {
            public string Puesto { get; set; }
            public double Salario { get; set; }

            public override void Saludar()
            {
                Console.WriteLine("Hola, soy " + Nombre + " " + Apellido + " y soy un vendedor.");
            }
        }

        public class SuperVendedor: Vendedor
        {
            public string Area { get; set; }
        }

        public void demo2()
        {
            // PersonaAbstracta persona = new PersonaAbstracta(); // Error: No se puede instanciar una clase abstracta

            Cliente cliente = new Cliente();
            cliente.Nombre = "Ana";
            cliente.Apellido = "Lopez";
            cliente.Edad = 35;
            cliente.Saludar();
            cliente.Direccion = "Calle 123";
            cliente.Telefono = "555-1234";

            Vendedor vendedor = new Vendedor();
            vendedor.Nombre = "Pedro";
            vendedor.Apellido = "Garcia";
            vendedor.Edad = 40;
            vendedor.Saludar();
        }
    }
}
