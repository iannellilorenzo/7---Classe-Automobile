using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Classe_Automobile
{
    public class Cambio : Automobile
    {
        private int _giri;
        private int contAcc;
        private int contFre;

        public int Giri
        {
            get { return _giri; }
            set 
            {
                if (value > 0)
                    _giri = value;
                else
                    _giri = 0;
                    //throw new ArgumentOutOfRangeException("value", "Valore non consentito");
            }
        }

        public Cambio()
        {
            Giri = 0;
        }

        public Cambio(int giri, bool accensione, int marcia, int velocita, int limite, int rangeSu, int rangeGiu) : base(accensione, marcia, velocita, limite, rangeSu, rangeGiu)
        {
            Accensione = false;
            Marcia = 0;
            Velocita = 0;
            Limite = 180;
            Giri = giri;
        }

        public override string Accelerazione()
        {
            string ret = "La macchina è spenta.\n";
            int giri = Giri;

            if (!Accensione)
            {
                return ret;
            }

            if (Velocita + 10 <= Limite && (giri != 4500 && giri != 9000 && giri != 13500 && giri != 18000 && giri != 22500 && giri != 27000) && contAcc != 3)
            {
                Velocita += 10;
                Giri += 1500;
                Giri--;
                contAcc++;
                ret = $"Hai accelerato. La tua velocità è ora di {Velocita} Km/h.\n";
            }
            else if (Velocita + 10 > Limite)
            {
                ret = $"Condizioni per accelerare non rispettate. La tua velocità è ora di {Velocita} Km/h.\n";
            }
            else
            {
                MarceSu();
                Velocita += 10;
                Giri++;
                contAcc = 1;
                ret = $"È stata scalata la marcia automaticamente. Sei in {Marcia}. Hai accelerato. La tua velocità è ora di {Velocita}Km/h.\n";
            }

            return ret;
        }

        public override string Freno()
        {
            string ret = "La macchina è spenta.\n";
            int giri = Giri;

            if (!Accensione)
            {
                return ret;
            }

            if (Velocita > 0 && Velocita - 10 >= 0 && (giri != 4500 && giri != 9000 && giri != 13500 && giri != 18000 && giri != 22500 && giri != 27000) && contFre != 3)
            {
                Velocita -= 10;
                Giri -= 1500;
                contFre++;
                ret = $"Hai frenato. La tua velocità è ora di {Velocita} Km/h.\n";
            }
            else if (Velocita > 0 && Velocita - 10 >= 0)
            {
                MarceGiu();
                Velocita -= 10;
                contFre = 1;
                ret = $"È stata scalata la marcia automaticamente. Sei in {Marcia}. Hai frenato. La tua velocità è ora di {Velocita} Km/h.\n";
            }
            else
            {
                ret = $"Condizioni per frenare non rispettate. La tua velocità è ora di: {Velocita} Km/h.";
            }

            return ret;
        }
    }
}
