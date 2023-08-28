using System.Reflection;
int opc;
double a = 0, b = 0, c = 0, d = 0;
do
{
    Console.WriteLine("\n --- CALCULADORA DE FRACCCIONARIOS ---");
    Console.WriteLine("Digite la operación que desea realizar:\n 1.Suma\n 2.Resta\n 3.Multiplicación\n 4.División\n 5.salir");
    opc = int.Parse(Console.ReadLine());

    switch (opc)
    {
        case 1:
            Console.WriteLine("Ingrese el valor del primer numerador: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del primer denominador: ");
            b = double.Parse(Console.ReadLine());
            if (b != 0)
                b = b;
            else { Console.WriteLine("Número no válido");
                continue;
            }
            
            Console.WriteLine("Ingrese el valor del segundo numerador: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del segundo denominador: ");
            d = double.Parse(Console.ReadLine());
            if (d != 0)
                d = d;
            else { Console.WriteLine("Número no válido");
                continue;
            }

            double resultados = ((a * d) + (b * c)) / (b * d);
            Console.WriteLine($"El resultado es:" + resultados);
            break;


        case 2:
            Console.WriteLine("Ingrese el valor del primer numerador: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del primer denominador: ");
            b = double.Parse(Console.ReadLine());
            if (b != 0)
                b = b;
            else { Console.WriteLine("Número no válido");
                continue;
            }
       
            Console.WriteLine("Ingrese el valor del segundo numerador: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del segundo denominador: ");
            d = double.Parse(Console.ReadLine());
            if (d != 0)
                d = d;
            else { Console.WriteLine("Número no válido");
                continue;
            }

            double resultador = ((a * d) - (b * c)) / (b * d);
            Console.WriteLine($"El resultado es:" + resultador);
            break;


        case 3:
            Console.WriteLine("Ingrese el valor del primer numerador: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del primer denominador: ");
            b = double.Parse(Console.ReadLine());
            if (b != 0)
                b = b;
            else { Console.WriteLine("Número no válido");
                continue;
            }

            Console.WriteLine("Ingrese el valor del segundo numerador: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del segundo denominador: ");
            d = double.Parse(Console.ReadLine());
            if (d != 0)
                d = d;
            else { Console.WriteLine("Número no válido");
                continue;
            }

            double resultadom =(a * c) / (b * d);
            Console.WriteLine($"El resultado es:" + resultadom);
            break;


        case 4:
            Console.WriteLine("Ingrese el valor del primer numerador: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del primer denominador: ");
            b = double.Parse(Console.ReadLine());
            if (b != 0)
                b = b;
            else { Console.WriteLine("Número no válido");
                continue;
            }

            Console.WriteLine("Ingrese el valor del segundo numerador: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del segundo denominador: ");
            d = double.Parse(Console.ReadLine());
            if (d != 0)
                d = d;
            else { Console.WriteLine("Número no válido");
                continue;
            }

            double resultadod = (a * d) / (b * c);
            Console.WriteLine($"El resultado es:" + resultadod);
            break;


        case 5:
            Console.WriteLine("Finalizado");
            break;


        default:
            Console.WriteLine("Opción no válida");
            break;
    }
} while (opc != 5);
    