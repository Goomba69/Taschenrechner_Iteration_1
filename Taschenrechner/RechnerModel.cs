﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Resultat { get; private set; }
        public string Operation { get; set; }
        public double ErsteZahl { get; set; }
        public double ZweiteZahl { get; set; }

        public RechnerModel()
        {
            //Resultat = 0;
            Operation = "unbekannt";
        }

        public void Berechne()
        {
            switch (Operation)
            {
                case "+":
                    Resultat = Addiere(ErsteZahl, ZweiteZahl);
                    break;

                case "-":
                    Resultat = Subtrahiere(ErsteZahl, ZweiteZahl);
                    break;

                case "/":
                    Resultat = Dividiere(ErsteZahl, ZweiteZahl);
                    break;

                case "*":
                    Resultat = Multipliziere(ErsteZahl, ZweiteZahl);
                    break;

                default:
                    break;
            }
        }
        private double Addiere(double ersterSummand, double zweiterSummand)
        {
            double Resultat = ersterSummand + zweiterSummand;

            return Resultat;
        }

        private double Subtrahiere(double Minuend, double Subtrahend)
        {
            double Resultat = Minuend - Subtrahend;

            return Resultat;
        }

        private double Multipliziere(double Multiplikator, double Multiplikand)
        {
            double Resultat = Multiplikator * Multiplikand;

            return Resultat;
        }

        private double Dividiere(double Dividend, double Divisior)
        {
            double Resultat = Dividend / Divisior;

            return Resultat;
        }
    }
}
