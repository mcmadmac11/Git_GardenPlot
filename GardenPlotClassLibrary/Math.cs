using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlotProgram
{
    public abstract class Math
    {
        PlotDimensions DimensionComparisonList = new PlotDimensions();


        public void PlotCompare(List<int> dimensionComparisonList)
        {
            int MaxValue = dimensionComparisonList.Max();
            int MinValue = dimensionComparisonList.Min();

        }


        public int GetPerimeterOfPlot(int _x, int _y, int _width, int _height)
        {

            int perimeterOfPlot = (_width + _height) * 2;

            return perimeterOfPlot;

        }


        public int GetPerimeterOfAllPlots(int MinValue, int MaxValue)
        {
            int totalPerimeter = (MinValue + MaxValue) * 2;
            return totalPerimeter;
        }

        public int CalculateAreaOfPlot(int width, int height)
        {
            int area = width * height;
            return area;
        }



        
    }

}
