using System;
using System.Collections.Generic;
using System.Text;

namespace Solutie
{
    class CameraDublaVedereMunte : Camera
    {
        protected override decimal CalculeazaPretCamera(int n)
        {
            return 150m * n;
        }
    }
}
