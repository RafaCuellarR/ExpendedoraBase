using System;
using System.Threading;

namespace ExpendedoraBase
{
    class Expendedora
    {
        string marca;
        byte temperatura;
        string codigo; //Atributo
        float precio;

        public Expendedora()
        {
            saludar();
            marca = "AMS";
            Console.WriteLine("Marca: " + marca);
            ControlarTiempoDisplay();
            temperatura = 14;
            Console.WriteLine("Temperatura: " + temperatura + "°C");
            ControlarTiempoDisplay();
            codigo = MostrarCodigoDeProductos();
            ControlarTiempoDisplay();
            MostrarPrecio(codigo);
        }

        void saludar()
        {
            Console.WriteLine("Bienvenido");
        }

        string MostrarCodigoDeProductos()
        {
            Console.WriteLine("A1: Kinder Delice\tB2: Takis\tC3: Donitas");
            Console.WriteLine("Ingrese el código de producto: ");
            string codigo = Console.ReadLine(); //variable local
            return codigo;
        }

        void ControlarTiempoDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }

        void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "A1":
                    Console.WriteLine("{0}", precio);
                    break;

                case "B2":
                    Console.WriteLine("{0}", precio);
                    break;

                case "C3":
                    Console.WriteLine("{0}", precio);
                    break;

                default:
                    Console.WriteLine("Código desconocido");
                    break;
            }
        }
    }
}
