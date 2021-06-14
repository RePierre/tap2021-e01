using System;
using System.Collections.Generic;
using System.Text;

namespace Solutie
{
    public class CameraMansarda : Camera
    {
        protected override decimal CalculeazaPretCamera(int n)
        {
            if (n > 3)
            {
                return 100m * 3 + 90 * (n-3);
            }
            else
            {
                return 100m * n;
            }
        }
    }
}