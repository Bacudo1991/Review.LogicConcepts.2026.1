using Shared;

var response = string.Empty;
Console.WriteLine("::::: EJERCICIO DE MÚLTIPLOS :::::");
do
{
    try
    {
        var number1 = ConsoleExtension.GetInt("Ingrese el primer número : ");
        var number2 = ConsoleExtension.GetInt("Ingrese el segundo número: ");
        if (number2 % number1 == 0)
        {
            Console.WriteLine($"{number1} es múltiplo de {number2}");
        }
        else
        {
            Console.WriteLine($"{number1} no es múltiplo de {number2}");
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