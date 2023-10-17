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

        public bool Accensione
        {
            get { return _accensione; }
            set { _accensione = value; }
        }

        public int Marcia
        { 
            get { return _marcia; }
            set { _marcia = value; }
        }

        public int Velocita
        {
            get { return _velocita; }
            set { _velocita = value; }
        }

        public Automobile()
        {
            _accensione = Accensione;
            _marcia = Marcia;
            _velocita = Velocita;
        }

        public Automobile(bool accensione, int marcia, int velocita)
        {
            _accensione = accensione;
            _marcia = marcia;
            _velocita = velocita;
        }

        public string Accesa()
        {
            string ret = "";

            if (Accensione)
            {
                ret = "La macchina è già accesa.";
            }
            else
            {
                ret = "La macchina è stata accesa.";
                Accensione = true;
            }

            return ret;
        }

        public string Accelerazione()
        {
            string ret = "";

            if (Accensione)
            {
                Velocita += 10;
            }
            else
            {
                ret = "La macchina non è accesa.";
            }

            return ret;
        }
    }
}