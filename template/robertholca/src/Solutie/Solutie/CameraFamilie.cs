using System;
using System.Collections.Generic;
using System.Text;

namespace Solutie
{
    public class CameraFamilie : Camera
    {
        protected override decimal CalculeazaPretCamera(int n)
        {
            return 200m * n;
        }
    }
}
