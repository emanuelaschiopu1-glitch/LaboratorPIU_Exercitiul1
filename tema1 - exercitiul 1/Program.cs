using System;

class Program
{
    static void Main()
    {
        // 1. Citirea datelor
        Console.Write("Introduceti numarul de ore lucrate: ");
        int oreLucru = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Introduceti tariful pe ora: ");
        double tarifore = double.Parse(Console.ReadLine() ?? "0");

        // 2. Calcule
        double salariu = oreLucru * tarifore;
        string mesaj = "Salariul este: " + salariu + " lei";

        // 3. Obtinere dimensiuni consola pentru centrare
        int windowWidth = Console.WindowWidth;
        int windowHeight = Console.WindowHeight;

        Console.Clear();

        //4.Verificare

        string verificare;

        if (salariu > 3000)
        {
            verificare = "Salariu mare";
        }
        else
        {
            verificare = "Ati lucrat prea putine ore pentru a avea un salariu mare!";
        }

        // 5. Setare culoare
        Console.ForegroundColor = ConsoleColor.Yellow;

        // Centrare mesaj salariu
        Console.SetCursorPosition((windowWidth - mesaj.Length) / 2, windowHeight / 2);
        Console.WriteLine(mesaj);

        Console.SetCursorPosition((windowWidth - verificare.Length) / 2, windowHeight / 2 + 2);
        Console.WriteLine(verificare);

        Console.ResetColor();

        // 5. IMPORTANT: Aceasta linie tine consola deschisa ca sa vezi rezultatul
        Console.WriteLine("\n\nApasa orice tasta pentru a iesi...");
        Console.ReadKey();
    }
}