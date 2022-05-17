using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rombo
{
    class Program
    {
        static void Main(string[] args)
        {
            int medida = 0;
            string diagonal = "";
            string espacio = ("   ");
            Console.WriteLine("Ingresa la medida de la diagonal del rombo:");
            medida = int.Parse(Console.ReadLine());

            for (int i = 0; i < medida - 1; i++)
            {
                diagonal += "*";
                diagonal += espacio;
            }

            diagonal += "*";

            int numEspacioExterno = (diagonal.Length - 1) / 2;

            string espacioExterno = "";
            for (int i = 0; i < numEspacioExterno; i++)
            {
                espacioExterno += " ";
            }

            for (int i = 0; i < medida; i++)
            {
                string linea = "";
                string lineaInterna = "";

                if (i == 0)
                {
                    lineaInterna += "*";
                }

                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        lineaInterna += "*";
                        lineaInterna += espacio;
                    }

                    lineaInterna += "*";
                }

                linea = espacioExterno + lineaInterna + espacioExterno;

                Console.WriteLine(linea);

                if (espacioExterno.Length != 0)
                {
                    espacioExterno = espacioExterno.Remove(0, 2);
                }
            }

            for (int i = medida - 1; i > 0; i--)
            {
                string linea = "";
                string lineaInterna = "";

                for (int j = 0; j < 2; j++)
                {
                    espacioExterno += " ";
                }

                for (int j = 1; j < i; j++)
                {
                    lineaInterna += "*";
                    lineaInterna += espacio;
                }
                lineaInterna += "*";

                linea = espacioExterno + lineaInterna + espacioExterno;
                Console.WriteLine(linea);
            }
        }
    }
}
