
String[] frases = {"El carro tiene cuatro llantas", "La universidad esta muy lejos",
                   "El bosque tiene muchos arboles", "Las tortugas son demasiado lentas",
                   "Los animales son muy inteligentes"};

Random generador = new Random();
int numeroAzar = generador.Next(0, frases.Length);
string palabraAdivinar = frases[numeroAzar];

string fraseMostrar = "";
for (int i = 2; i < palabraAdivinar.Length; i++)
    if (palabraAdivinar[i] == ' ')
        fraseMostrar += " ";
    else
        fraseMostrar += "_______";

int fallosRestantes = 10;
string palabraActual;
bool terminado = false;

do
{
    Console.WriteLine($"Palabra oculta: {fraseMostrar}");

    Console.WriteLine("Ingrese una palabra: ");
    palabraActual = Convert.ToString(Console.ReadLine());

    if (!palabraAdivinar.Contains(palabraActual))
        fallosRestantes--;

    string siguienteMostrar = "";

    for (int i = 0; i < palabraAdivinar.Length; i++)
    {
        if (palabraActual == palabraAdivinar)
            siguienteMostrar += palabraActual;
            Console.WriteLine($"Felicidades acertaste");
        else
            siguienteMostrar += fraseMostrar[i];
    }
    fraseMostrar = siguienteMostrar;

    if (!fraseMostrar.Contains("_"))
    {
        Console.WriteLine($"Felicidades adivinaste la frase\n {palabraAdivinar}");
        terminado = true;
    }
    else if(fallosRestantes == 0)
    {
        Console.WriteLine("Ya no tienes más intentos");
        terminado = true;
    }

} while (terminado);
