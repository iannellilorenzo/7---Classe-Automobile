using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Classe_Automobile
{
    public class Automobile
    {
        private bool _accensione;
        private int _marcia; 
        private int _velocita;
        private int _limite;

        public bool Accensione
        {
            get { return _accensione; }
            set { _accensione = value; }
        }

        public int Marcia
        { 
            // controllo per il cambio manuale;
            get { return _marcia; }
            set { _marcia = value; }
        }

        public int Velocita
        {
            get { return _velocita; }
            set { _velocita = value; }
        }

        public int Limite
        {
            get { return _limite; }
            set { _limite = value; }
        }

        public Automobile()
        {
            Accensione = false;
            Marcia = 0;
            Velocita = 0;
            Limite = 150;
        }

        public Automobile(bool accensione, int marcia, int velocita, int limite)
        {
            _accensione = accensione;
            _marcia = marcia;
            _velocita = velocita;
            _limite = limite;
        }

        public string Accesa()
        {
            string ret = "";

            if (Accensione)
            {
                ret = "La macchina è stata spenta.\n";
                Accensione = false;
            }
            else
            {
                ret = "La macchina è stata accesa.\n";
                Accensione = true;
            }

            return ret;
        }

        public string Accelerazione()
        {
            string ret = "";

            if (Accensione && Velocita + 50 <= Limite)
            {
                Velocita += 50;
                ret = $"Hai accelerato. La tua velocità è ora di {Velocita}Km/h.\n";
            }
            else
            {
                ret = $"Condizioni per accelerare non rispettate. La tua velocità è ora di {Velocita} Km/h.\n";
            }

            return ret;
        }

        public string Freno()
        {
            string ret = "";

            if (Accensione && Velocita > 0 && Velocita - 50 >= 0)
            {
                Velocita -= 50;
                ret = $"Hai frenato. La tua velocità è ora di {Velocita} Km/h.\n";
            }
            else
            {
                ret = $"Condizioni per frenare non rispettate. La tua velocità è ora di {Velocita} Km/h.\n";
            }

            return ret;
        }
    }
}
