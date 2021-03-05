using System;
using System.Collections.Generic;
using System.Text;

namespace solutie
{
    public abstract class Camera
    {
        public decimal pret { get; private set; }

        public bool ocupat = false;

        public decimal PretTotal(int n)
        {
            var calc = CalculeazaPretCamera(n);
            pret += calc;
            ocupat = true;
            return pret;
        }

        protected abstract decimal CalculeazaPretCamera(int n);
    }
}
