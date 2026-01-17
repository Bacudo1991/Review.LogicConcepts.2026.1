using Shared;

var response = string.Empty;

do
{
    try
    {
        var number1 = ConsoleExtension.GetInt("Ingrese el primer número: ");
        var number2 = ConsoleExtension.GetInt("Ingrese el segundo número: ");
        var number3 = ConsoleExtension.GetInt("Ingrese el tercer número: ");

        if (number1 > number2 && number1 > number3)
        {
            Console.WriteLine($"El número mayor es: {number1}");
        }
        else if (number2 > number1 && number2 > number3)
        {
            Console.WriteLine($"El número mayor es: {number2}");
        }
        else if (number3 > number1 && number3 > number2)
        {
            Console.WriteLine($"El número mayor es: {number3}");
        }
        else
        {
            Console.WriteLine("Los números son iguales o no se puede determinar un único mayor.");
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