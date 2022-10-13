using System.Runtime.Intrinsics.Arm;
using System.Xml;

namespace DefaultNamespace;

public class InputHandler
{
    public static string HandleInput()
    {
        String input = Console.ReadLine();

        if (input == "predchozi" || input == "dalsi" || input == "novy" || input == "uloz" || input == "smaz" ||
            input == "zavri")
            return input;
        else
        {
            return "error";
        }
    }
}