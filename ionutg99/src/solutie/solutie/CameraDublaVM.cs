using System;
using System.Collections.Generic;
using System.Text;

namespace solutie
{
    public  class CameraDublaVM:Camera
    {

        protected override decimal CalculeazaPretCamera(int n)
        {
            return 150m * n;
        }
    }
}
