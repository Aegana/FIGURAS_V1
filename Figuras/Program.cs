using System;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Figuras figuras = new Figuras();  //instanciando a la clase figuras;      
            figuras.areacuadrado(); //accedemos al objeto creado
            figuras.areaRectangulo(); //accedemos al objeto creado
            figuras.areaCirculo(); //accedemos al objeto creado
            Console.ReadKey();


        }
    }
}
