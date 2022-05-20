//Receive input

Console.WriteLine("Ingrese diez numeros: ");

int[] numbers = new int[10];

for (int i = 0; i < 10; i++)
{
    
    Console.WriteLine($"Por favor ingrese el numero {i+1}:");
    numbers[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("");

//Show input

Console.Write("Los numeros ingresados son: ");

for (int i = 0; i < 10; i++)
{
    Console.Write($"{numbers[i]}, "); //find out how to set different instructions for final loop.
}

Console.WriteLine("");

//Operations
//Addition

int addition = 0;

for (int i = 0; i < 10; i++)
{
    addition += numbers[i];
}

//average

double average = addition / 10;

Console.WriteLine("");
Console.WriteLine($"La suma de todos los numeros ingresados es {addition}.");
Console.WriteLine("");
Console.WriteLine($"El promedio de todos los valores ingresados es {average}.");

//Smallest-Biggest

Console.WriteLine("");
Console.WriteLine($"El menor numero ingresado es {numbers.Min()}.");
Console.WriteLine();                                                    //Now THESE two are practical!
Console.WriteLine($"El mayor numero ingresado es {numbers.Max()}.");

Console.ReadLine(); 






