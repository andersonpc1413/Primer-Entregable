
using System.ComponentModel.Design;

Console.WriteLine("Digite el rango inicial: ");
int rangoi = Int32.Parse(Console.ReadLine());

Console.WriteLine("Digite el rango final: ");
int rangof = Int32.Parse(Console.ReadLine());


for(int i = rangoi; i <= rangof; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine(i + " x " + j + " = " + (i * j));  
    }
    Console.WriteLine("");
}

Random rdn = new Random();
int aleatorio = rdn.Next(1, 10);
Console.WriteLine("Ingresar el número que corresponde en el lugar del signo de interrogación");
int numero = Int32.Parse(Console.ReadLine());
do
{
    if (aleatorio == numero)
        Console.WriteLine("El número ingresado es correcto");
    else
    {
        Console.WriteLine("El número ingresado es incorrecto");
        continue;
    }
} while (aleatorio == numero);
