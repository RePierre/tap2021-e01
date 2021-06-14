using System;
using System.Collections.Generic;
using System.Text;

namespace Solutie
{
    public abstract class Camera
    {
        public decimal pret { get; private set; }

        public int nr_nopti { get; set; }

        public decimal Rezerva(int n)
        {
            var calc = CalculeazaPretCamera(n);
            pret += calc;
            return pret;
        }

        protected abstract decimal CalculeazaPretCamera(int n);
    }
}


