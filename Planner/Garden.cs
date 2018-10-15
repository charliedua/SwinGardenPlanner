using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planner
{
    public class Garden
    {
        private int _height;
        private int _width;
        private Cell[][] _cells;

        public Garden(int size)
        {
            _height = size;
            _width = size;
            _cells = new Cell[size][];
            for (int i = 0; i < _cells.Length; i++)
            {
                _cells[i] = new Cell[size];
                for (int j = 0; j < _cells[i].Length; j++)
                {
                    _cells[i][j] = new Cell(i, j);
                }
            }
        }

        public int Height { get => _height; set => _height = value; }

        public int Width { get => _width; set => _width = value; }
        public Cell[][] Cells { get => _cells; set => _cells = value; }

        public int GetArea()
        {
            int _area = _height * _width;
            return _area;
        }
    }
}