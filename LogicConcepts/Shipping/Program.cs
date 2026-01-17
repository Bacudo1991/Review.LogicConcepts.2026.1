using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
Console.WriteLine("::::: EJERCICIO ENVÍO DE MERCANCIAS :::::");
do
{
    try
    {
        var weigth = ConsoleExtension.GetFloat("Peso de la mercancía..........: ");
        var value = ConsoleExtension.GetDecimal("Valor de la mercancía..........:");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("::::: GAME OVER :::::");