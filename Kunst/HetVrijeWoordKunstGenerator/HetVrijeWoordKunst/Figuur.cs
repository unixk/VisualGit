using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunstbryan
{
    class Figuur
    {
        private String Soort;
        private int X;
        private int Y;
        private int Width;
        private int Height;

        public Figuur(String soort, int x, int y, int width, int height)
        {
            this.Soort = soort;
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        public String _Soort
        {
            get
            {
                return Soort;
            }
        }

        public int _X
        {
            get
            {
                return X;
            }
        }

        public int _Y
        {
            get
            {
                return Y;
            }
        }

        public int _Width
        {
            get
            {
                return Width;
            }
        }

        public int _Height
        {
            get
            {
                return Height;
            }

        }
    }
}
