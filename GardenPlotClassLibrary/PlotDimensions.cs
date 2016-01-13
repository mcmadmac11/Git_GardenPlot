namespace GardenPlotProgram
{
    using System.Collections.Generic;


    public class PlotDimensions
    {


        public List<string> DimensionList = new List<string>();
        public List<string> dimensionList(string x, string y, string width, string height)
        {


            DimensionList.Add(x);
            DimensionList.Add(y);
            DimensionList.Add(width);
            DimensionList.Add(height);

            return DimensionList;
        }
        public List<string> dimensionList(int x, int y, int width, int height)
        {
            return dimensionList(x.ToString(), y.ToString(), width.ToString(), height.ToString());

        }



        public PlotDimensions()
        {
            this.DimensionList = new List<string>();
        }


        //public bool BoxesIntersect(const Box2D &a, const Box2D &b)
        //{
        //f (a.max.x<b.min.x) return false; // a is left of b
        //if (a.min.x > b.max.x) return false; // a is right of b
        //if (a.max.y<b.min.y) return false; // a is above b
        //f (a.min.y > b.max.y) return false; // a is below b
        //return true; // boxes overlap

    }
}
