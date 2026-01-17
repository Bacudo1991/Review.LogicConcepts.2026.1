using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
Console.WriteLine("::::: EJERCICIO DE AÑO BISIESTO :::::");
do
{
    var currentYear = DateTime.Now.Year;
    var message = string.Empty;
    var year = 0;
    try
    {
        year = ConsoleExtension.GetInt("Ingrese el año: ");
        if (year == currentYear)
        {
            message = "es";
        }
        else if (year > currentYear)
        {
            message = "va a ser";
        }
        else
        {
            message = "fue ";
        }

        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            Console.WriteLine($"El año {year} sí {message} bisiesto.");
        }
        else
        {
            Console.WriteLine($"El año {year} no {message} bisiesto.");
        }
    }
    catch (Exception)
    {
        Console.WriteLine($"Lo que ingresaste no es un año valido.");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("::::: GAME OVER :::::");