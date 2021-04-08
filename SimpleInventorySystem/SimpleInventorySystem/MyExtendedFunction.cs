using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimpleInventorySystem
{
    public static class MyExtendedFunction
    {
        public static double ComputeArea(this Series s)
        {
            double area = 0;
            for (int i = 0; i < s.Points.Count-1; i++)
            {
                area += s.Points[i].YValues[0] * (s.Points[i+1].XValue - s.Points[i].XValue);
            }
            return area;
        }
    }
}
