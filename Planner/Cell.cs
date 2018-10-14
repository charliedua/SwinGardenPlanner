using System;

namespace Planner
{
    /// <summary>
    /// A cell for a single GardenObject to sit in.
    /// </summary>
    public class Cell
    {
        private int _x;
        private int _y;
        /*
        private string _width;
        private string _height;
        */
        private GardenObject _object;

        public bool HasObject
        {
            get => _object != null;
        }

        public GardenObject Object { get => _object; set => _object = value; }
        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        /* public bool Width { get; set; } public bool Height { get; set; } public bool Area { get; } */

        public Cell(int X, int Y, GardenObject gardenObject = null)
        {
        }
    }
}