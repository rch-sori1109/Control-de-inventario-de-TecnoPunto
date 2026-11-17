using System;
using System.Collections.Generic;
using System.Text;

namespace Control_de_inventario_de_TecnoPunto
{
    public class Producto
    {
        private string _codigo;
        private string _nombre;
        private decimal _precio;
        private int _cantidad;

        public string Codigo
        {
            get { return _codigo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("EL CODIGO DEL PRODUCTO NO PUEDE ESTAR VACIO ");
                }
                _codigo = value.Trim();
            }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("EL NOMBRE DEL PRODUCTO NO PUEDE ESTAR VACIO ");
                }
                _nombre = value.Trim();
            }
        }

        public decimal Precio
        {
            get { return _precio; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("EL PRECIO DEL PRODUCTO DEBE SER MAYOR QUE CERO ");
                }
                _precio = value;
            }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("LA CANTIDAD DEL PRODUCTO DEBE SER MAYOR QUE CERO ");
                }
                _cantidad = value;
            }
        }

        public decimal ValorTotal
        {
            get { return _precio * _cantidad; }
        }

        public Producto(string codigo, string nombre, decimal precio, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine();
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine();
            Console.WriteLine($"Precio: {Precio.ToString("C")}");
            Console.WriteLine();
            Console.WriteLine($"Cantidad: {Cantidad}");
            Console.WriteLine();
            Console.WriteLine($"Valor Total: {ValorTotal.ToString("C")}");
            Console.WriteLine();
        }
    }
}
