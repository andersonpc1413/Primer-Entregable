
Console.WriteLine("Ingrese un número: ");
int num = Int32.Parse(Console.ReadLine());


if (num % 5 == 0 && num % 2 != 0 && num % 3 != 0 && num > 10)
    Console.WriteLine($"El número {num} ES un Número Especial");
else { Console.WriteLine($"El número {num} NO es un Número Especial"); }



