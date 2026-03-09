using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDay
{
    public class Task
    {
        public string Obiectiv { get; set; }
        public bool EsteFinalizat { get; set; }

        //constructor fara parametrii
        public Task()
        {
            Obiectiv = "";
            EsteFinalizat = false;
        }
        public void MarcatFinalizat()
        {
            EsteFinalizat = true;
        }
        public string Info()
        {
            return $"Task: : {Obiectiv} | Finalizat: {EsteFinalizat} ";
        }


    }
}
