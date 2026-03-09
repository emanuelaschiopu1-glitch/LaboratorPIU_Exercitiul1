using System;

namespace MyDay
{
    public class DailyGoal
    {
        public string ObiectivZilnic { get; set; }
        public bool EsteFinalizat { get; set; }

        public DailyGoal()
        {
            ObiectivZilnic = "";
            EsteFinalizat = false;
        }

        public void MarcatFinalizat()
        {
            EsteFinalizat = true;
        }

        public string Info()
        {
            return $"Obiectiv zilnic: {ObiectivZilnic} | Finalizat: {EsteFinalizat}";
        }
    }
}