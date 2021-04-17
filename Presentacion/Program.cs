using System;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Menue();
        }

        private static void Menue()
        {
            int opc = 0;

            Console.WriteLine("1 registro");
            Console.WriteLine("2 modificar");
            Console.WriteLine("3 eliminar");
            Console.WriteLine("4 informe");

            switch (opc)
            {
                case 1:
                    Registro();
                    break;
                case 2:
                    Modificar();
                    break;
                case 3:
                    Eliminar();
                    break;
                case 4:
                    Informe();
                    break;
                case 5:
                    break;
            }
        }


        private static void Registro()
        {
            
        }

        private static void Modificar()
        {
            
        }

        private static void Eliminar()
        {

        }

        private static void Informe()
        {
            
        }


    }
}
