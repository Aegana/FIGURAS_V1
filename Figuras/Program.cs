using System;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 1;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("¿Desea utilizar la aplicación para el cálculo del área de alguna figura?(S/N)");
                    string valor = Console.ReadLine();
                    if (valor=="S"||valor=="s")
                    {
                        Console.WriteLine("Elije el area de la figura que desea calcular: \n" +
                                               "1.- Area de un cuadrado \n" + "2.- Area de un Rectangulo \n" + "3.-Area de un Círculo \n");
                        string opcion = Console.ReadLine();
                        Figuras figuras = new Figuras();  //instanciando a la clase figuras; 
                        switch (opcion)
                        {
                            case "1":
                                figuras.areacuadrado(); //accedemos al objeto creado
                                break;
                            case "2":
                                figuras.areaRectangulo(); //accedemos al objeto creado
                                break;
                            case "3":
                                figuras.areaCirculo(); //accedemos al objeto creado
                                break;

                            default:
                                Console.WriteLine("Fallo en la elección");
                                break;
                        }
                        n++;
                    }
                    else if (valor=="n"||valor=="N")
                    {
                        //también se podría poner (valor.toUpper()=="N")
                        return;
                    }


                }

                   
                
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("La aplicación ha fallado. Contacte con su técnico"+ex.Message);//Muestra el error resumido ex.message)
               // throw;
            }
            


        }
    }
}
