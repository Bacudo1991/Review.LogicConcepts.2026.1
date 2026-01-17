using Shared;

var response = string.Empty;

do
{
    try
    {
        var number = ConsoleExtension.GetInt("Ingrese un número entero: ");
        if (number % 2 == 0)
        {
            Console.WriteLine($"El número {number}, es par.");
        }
        else
        {
            Console.WriteLine($"El número {number}, es impar.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.Write("Deseas continuar [S/N]? :");
    response = Console.ReadLine()!.ToUpper();
} while (response == "S");
Console.WriteLine("::::: GAME OVER :::::");