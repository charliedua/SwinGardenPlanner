using System;
namespace Planner
{
    /// <summary>
    /// A cell for a single GardenObject to sit in.
    /// </summary>
    public class Cell
    {
        private string _x;
        private string _y;
        /*
        private string _width;
        private string _height;
        */
        private GardenObject _object;

        public bool HasObject
        {
            get;
        }
        public bool X
        {
            get;
            set;
        }
        public bool Y
        {
            get;
            set;
        }
        /*
        public bool Width
        {
            get;
            set;
        }
        public bool Height
        {
            get;
            set;
        }
        public bool Area
        {
            get;
        }
        */

        public Cell()
        {
            throw new NotImplementedException();
        }

    }
}