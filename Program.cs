using System;

namespace MyDay
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Cream Planner și DailyGoal
            Planner planner = new Planner();
            DailyGoal goal = new DailyGoal();

            Console.Write("Introdu obiectivul principal al zilei: ");
            goal.ObiectivZilnic = Console.ReadLine();

            // 2 Adăugăm task-uri în Planner
            bool continua = true;
            while (continua)
            {
                Task t = new Task();
                int nrTask = planner.CountTasks() + 1;
                t.Obiectiv = $"Task {nrTask}";

                Console.Write($"{t.Obiectiv}: ");
                string detalii = Console.ReadLine();
                t.Obiectiv += $" - {detalii}";

                planner.AdaugaTask(t);

                Console.Write("Vrei să mai adaugi un task? (da/nu): ");
                if (Console.ReadLine().ToLower() != "da")
                    continua = false;
            }

            Console.WriteLine("\nVrei să marchezi vreun task ca finalizat? (da/nu): ");
            if (Console.ReadLine().ToLower() == "da")
            {
                Console.Write("Introdu numărul task-ului pe care vrei să-l marchezi: ");
                int nr = int.Parse(Console.ReadLine());
                planner.MarcheazaTask(nr - 1); // metoda va marca task-ul din listă
            }

            // 3️ Introducere LifeStyle
            LifeStyle lifestyle = new LifeStyle();

            Console.Write("\nCâte ore ai dormit azi? ");
            lifestyle.OreSomn = int.Parse(Console.ReadLine());

            Console.Write("Câți litri de apă ai băut azi? ");
            lifestyle.CantitateApa = double.Parse(Console.ReadLine());

            // 4️ Afișăm obiectivul principal
           // Console.WriteLine("\nObiectivul zilei:");
            Console.WriteLine(goal.Info());

            // 5️ Afișăm task-urile
            planner.AfiseazaTaskuri();

            // 6️  Afișăm feedback pentru somn și apă
            lifestyle.Feedback();

            Console.WriteLine("\nApasă orice tastă pentru a închide...");
            Console.ReadKey();
        }
    }
}