using System;
using System.Collections.Generic;
using System.Text;

namespace Solutie
{
    class CameraDublaNormala : Camera
    {
        protected override decimal CalculeazaPretCamera(int n)
        {
            return 120m * n;
        }
    }
}
