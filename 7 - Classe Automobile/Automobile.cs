using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _7___Classe_Automobile
{
    public class Automobile
    {
        protected bool _accensione;
        protected int _marcia; 
        protected int _velocita;
        protected int _limite;
        protected int _rangeSu;
        protected int _rangeGiu;

        public bool Accensione
        {
            get { return _accensione; }
            set { _accensione = value; }
        }

        public int Marcia
        {
            get { return _marcia; }
            set 
            {
                if (value > 0 && value < 7)
                    _marcia = value;
                else
                    _marcia = 1;
                    //throw new ArgumentOutOfRangeException("value", "Valore non consentito");
            }
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

        public int RangeSu
        {
            get { return _rangeSu; }
            set 
            {
                if (value > 0)
                    _rangeSu = value;
                else
                    _rangeSu = 30;
                    //throw new ArgumentOutOfRangeException("value", "Valore non consentito");
            }
        }

        public int RangeGiu
        {
            get { return _rangeGiu; }
            set 
            {
                if (value > 0)
                    _rangeGiu = value;
                else
                    _rangeGiu = 150;
                    //throw new ArgumentOutOfRangeException("value", "Valore non consentito");
            }
        }

        public Automobile()
        {
            Accensione = false;
            Marcia = 0;
            Velocita = 0;
            Limite = 180;
            RangeSu = 30;
            RangeGiu = 150;
        }

        public Automobile(bool accensione, int marcia, int velocita, int limite, int rangeSu, int rangeGiu)
        {
            Accensione = accensione;
            Marcia = marcia;
            Velocita = velocita;
            Limite = limite;
            RangeSu = rangeSu;
            RangeGiu = rangeGiu;
        }

        public Automobile(Automobile autoPrec)
        {
            Accensione = autoPrec.Accensione;
            Marcia = autoPrec.Marcia;
            Velocita = autoPrec.Velocita;
            Limite = autoPrec.Limite;
            RangeSu = autoPrec.RangeSu;
            RangeGiu = autoPrec.RangeGiu;
        }

        public string Accesa()
        {
            string ret;

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

        public virtual string Accelerazione()
        {
            string ret = "La macchina è spenta.\n";

            if (Accensione)
            {
                if (Velocita + 10 <= Limite)
                {
                    Velocita += 10;
                    ret = $"Hai accelerato. La tua velocità è ora di {Velocita}Km/h.\n";
                }
                else
                {
                    ret = $"Condizioni per accelerare non rispettate. La tua velocità è ora di {Velocita} Km/h.\n";
                }
            }

            return ret;
        }

        public virtual string Freno()
        {
            string ret = "La macchina è spenta.\n";

            if (Accensione)
            {
                if (Velocita > 0 && Velocita - 10 >= 0)
                {
                    Velocita -= 10;
                    ret = $"Hai frenato. La tua velocità è ora di {Velocita} Km/h.\n";
                }
                else
                {
                    ret = $"Condizioni per frenare non rispettate. La tua velocità è ora di {Velocita} Km/h.\n";
                }
            }
            
            return ret;
        }

        public virtual string MarceSu()
        {
            string ret = "La macchina è spenta.\n";

            if (Accensione)
            {
                for (int i = Marcia; i < 7; i++)
                {
                    if (Velocita == RangeSu)
                    {
                        Marcia += 1;
                        ret = $"Marcia scalata correttamente. Sei in {Marcia}^.\n";
                        RangeSu += 30;
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

        public virtual string MarceGiu()
        {
            string ret = "La macchina è spenta.\n";

            if (Accensione)
            {
                for (int i = 0; i < 7; i++)
                {
                    if (Velocita == RangeGiu)
                    {
                        Marcia -= 1;
                        ret = $"Marcia scalata correttamente. Sei in {Marcia}^.\n";
                        RangeGiu -= 30;
                        break;
                    }

                    ret = $"Condizioni per scalare marcia non rispettate. Sei in {Marcia}^.\n";
                    RangeGiu -= 30;
                }
            }

            return ret;
        }
    }
}
