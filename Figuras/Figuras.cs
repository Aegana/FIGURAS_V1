using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras
{
    class Figuras
    {
        public decimal ejemplo { get; set; } //get set son de tipo lectura y escritura, sintaxis para declarar un atributo.
        double area =0;
        double lado =0;
        double ancho =0;
        double radio=0;

        public  void areacuadrado()
        {
            Console.WriteLine("Escribir el lado: ");
            lado = Convert.ToDouble(Console.ReadLine());
            area = lado * lado;
            Console.WriteLine("El área del cuadrado es: "+area);

        }
        public void areaRectangulo()
        {
            Console.WriteLine("Escribir el largo: ");
            lado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escribir el ancho: ");
            ancho = Convert.ToDouble(Console.ReadLine());
            area = lado * ancho;
            Console.WriteLine("El área del cuadrado es: " + area);
        }
        public void areaCirculo()
        {
            Console.WriteLine("Escribir el radio: ");
            radio = Convert.ToDouble(Console.ReadLine());
            area = Math.PI*Math.Pow(radio,2);
            Console.WriteLine("El área del cuadrado es: " + area);
        }


    }
}
