using Control_de_inventario_de_TecnoPunto;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("CONTROL DE INVENTARIO");
        Console.WriteLine();

        Producto producto1 = LeerProducto(1);
        Producto producto2 = LeerProducto(2);
        Producto producto3 = LeerProducto(3);

        Console.WriteLine();
        Console.WriteLine("PRODUCTOS REGISTRADOS:");

        Console.WriteLine();
        producto1.MostrarInformacion();
        Console.WriteLine();
        producto2.MostrarInformacion();
        Console.WriteLine();
        producto3.MostrarInformacion();

        Console.WriteLine();
        Console.WriteLine("PRESIONE CUALQUIER TECLA PARA SALIR");
        Console.ReadKey();
    }

    static Producto LeerProducto(int numero)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Producto " + numero);

            try
            {
                Console.WriteLine("Codigo: ");
                string codigo = Console.ReadLine();

                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Precio: ");
                decimal precio;
                if (!decimal.TryParse(Console.ReadLine(), out precio))
                {
                    throw new FormatException("PRECIO INVALIDO, INGRESE UN VALOR MAYOR QUE CERO ");
                }

                Console.WriteLine("Cantidad: ");
                int cantidad;
                if (!int.TryParse(Console.ReadLine(), out cantidad))
                {
                    throw new FormatException("CANTIDAD INVALIDA, INGRESE UN VALOR MAYOR QUE CERO ");
                }

                return new Producto(codigo, nombre, precio, cantidad);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message + "Intentelo de nuevo");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message + "Intentelo de nuevo");
            }
        }
    }
}