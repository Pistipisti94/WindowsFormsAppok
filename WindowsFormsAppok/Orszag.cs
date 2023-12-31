﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppok
{
    internal class Orszag
    {
        string orszagNev;
        double terulet;
        public Orszag(string line)
        {
            string[] sor = line.Split(';');
            orszagNev = sor[0].ToLower();
            Terulet = double.Parse(sor[1].Trim().Replace('.', ','));
        }

        public string OrszagNev { get => orszagNev; set => orszagNev = value; }
        public double Terulet { get => terulet; set => terulet = value; }
        public override string ToString()
        {
            return orszagNev + " területe: " + terulet.ToString("#,##0.0");
        }
    }
}
