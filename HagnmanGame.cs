using System.Text;

namespace hangman;

public static class HangmanGame
{
    public static List<string> nactiSlova()
    {
        string soubor = "words.txt";
        if (File.Exists(soubor))
        {
            var nactenoZeSouboru = File.ReadAllLines(soubor);
            return new List<string>(nactenoZeSouboru);
        }
        else return new List<string>();
    }

    public static string vyberNahodneSlovo(List<string> vstup)
    {        
        Random rnd = new Random();
        int random = rnd.Next(0, vstup.Count);
        return vstup[random];
    }

    public static string vypisPokusu(List<char> seznamPokusu)
    {
        var serazenySeznamPokusu =
            from znak in seznamPokusu             
            orderby znak            
            select znak;
        
        StringBuilder sb = new StringBuilder();
        foreach (char c in serazenySeznamPokusu)
        {
            sb.Append(c);
            sb.Append(' ');
        }
        return sb.ToString();
    }

    public static string vypisSlepeSlovo(string slovo, List<char> hadaneZnaky)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in slovo)
        {
            if (hadaneZnaky.Contains(c))
            {
                sb.Append(c);
            }
            else
            {
                sb.Append("_");
            }
        }
        return sb.ToString();
    }

    public static bool bylaDosazenaVyhra(string skryteSlovo, List<char> hadaneZnaky)
    {
        foreach (char c in skryteSlovo)
        {   /*if we find at least one hidden word character that is not contained in the guessed characters then game is not yet won*/
            if (!hadaneZnaky.Contains(c))
                return false;
        }
        return true; 
    }

    public static void zakresliGrafiku(int wrong)
        {
            
            if (wrong == 0)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 1)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 2)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("O   |");
                Console.WriteLine("|   |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 3)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|  |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 4)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("    |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 5)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O  |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/   |");
                Console.WriteLine("   ===");
            }
            else if (wrong == 6)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O   |");
                Console.WriteLine("/|\\  |");
                Console.WriteLine("/ \\  |");
                Console.WriteLine("    ===");
            }
        }
}