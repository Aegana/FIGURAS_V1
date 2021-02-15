using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras
{
    class Figuras
    {
        public decimal ejemplo { get; set; } //get set son de tipo lectura y escritura, sintaxis para declarar un atributo.
        decimal area;
        decimal lado;
        //decimal ancho;
        //decimal radio;

        public  void areacuadrado()
        {
            Console.WriteLine("Escribir el lado: ");
            lado = Convert.ToDecimal(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("El área del cuadrado es: "+area);

        }
    }
}
