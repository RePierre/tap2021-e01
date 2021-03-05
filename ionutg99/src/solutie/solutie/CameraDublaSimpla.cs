using System;
using System.Collections.Generic;
using System.Text;

namespace solutie
{
    public  class CameraDublaSimpla:Camera
    {
        protected override decimal CalculeazaPretCamera(int n)
        {
            return 120m * n;
        }
    }
}
