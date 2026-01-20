using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::");
Console.WriteLine(":::::::: EJERCICIO SERIE DE TAYLOR ::::::::");
Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::");
do
{
    try
    {
        var a = ConsoleExtension.GetDouble("Ingrese el valor de a: ");
        var b = ConsoleExtension.GetDouble("Ingrese el valor de b: ");
        var c = ConsoleExtension.GetDouble("Ingrese el valor de c: ");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar [S]í, [N]o?.....: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("::::: GAME OVER :::::");

public class