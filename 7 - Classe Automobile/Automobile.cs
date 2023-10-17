﻿using System;
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
        private int _range;

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

        public int Range
        {
            get { return _range; }
            set { _range = value; }
        }

        public Automobile()
        {
            Accensione = false;
            Marcia = 0;
            Velocita = 0;
            Limite = 180;
            Range = 30;
        }

        public Automobile(bool accensione, int marcia, int velocita, int limite, int range)
        {
            _accensione = accensione;
            _marcia = marcia;
            _velocita = velocita;
            _limite = limite;
            _range = range;
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
            string ret;

            if (Accensione && Velocita + 10 <= Limite)
            {
                Velocita += 10;
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
            string ret;

            if (Accensione && Velocita > 0 && Velocita - 10 >= 0)
            {
                Velocita -= 10;
                ret = $"Hai frenato. La tua velocità è ora di {Velocita} Km/h.\n";
            }
            else
            {
                ret = $"Condizioni per frenare non rispettate. La tua velocità è ora di {Velocita} Km/h.\n";
            }

            return ret;
        }

        public string MarceSu()
        {
            string ret = "La macchina è spenta.\n";

            if (Accensione)
            {
                for (int i = Marcia; i < 7; i++)
                {
                    if (Velocita == Range)
                    {
                        Marcia += 1;
                        ret = $"Marcia scalata correttamente. Sei in {Marcia}^.\n";
                        Range += 30;
                        break;
                    }

                    if (i == 0)
                    {
                        ret = "Condizioni per scalare marcia non rispettate. Sei in 1^.\n";
                        break;
                    }

                    ret = $"Condizioni per scalare marcia non rispettate. Sei in {Marcia}^.\n";
                    break;
                }
            }

            return ret;
        }
    }
}
