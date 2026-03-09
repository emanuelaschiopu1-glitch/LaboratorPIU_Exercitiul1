using System;
using System.Collections.Generic;

namespace MyDay
{
    public class Planner
    {
        private List<Task> listaTaskuri = new List<Task>();

        public void AdaugaTask(Task task)
        {
            listaTaskuri.Add(task);
        }

        public int CountTasks()
        {
            return listaTaskuri.Count;
        }

        public void MarcheazaTask(int index)
        {
            if (index >= 0 && index < listaTaskuri.Count)
            {
                listaTaskuri[index].MarcatFinalizat();
                Console.WriteLine($"Task-ul {index + 1} a fost marcat ca finalizat!");
            }
            else
            {
                Console.WriteLine("Număr task invalid!");
            }
        }

        public void AfiseazaTaskuri()
        {
            Console.WriteLine("\nLista task-uri:");
            for (int i = 0; i < listaTaskuri.Count; i++)
            {
                Console.WriteLine($"Task {i + 1}: {listaTaskuri[i].Info()}");
            }
        }
    }
}