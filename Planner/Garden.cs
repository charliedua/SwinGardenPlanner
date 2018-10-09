using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    public class Garden
    {
        private string _name;
        private int _height;
        private int _width;
        private Plant[] _plants;

        public Garden()
        {

        }

        public string Name { get => _name; set => _name = value; }

        public int Height { get => _height; set => _height = value; }

        public int Width { get => _width; set => _width = value; }

        public Plant[] Plants { get => _plants; set => _plants = value; }

        public int Area
        {
            get
            {
                int _area = _height * _width;
                return _area;
            }
        }
    }
}
