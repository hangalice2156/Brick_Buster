using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brick_Buster
{
    class Brick
    {
        private int Width, Height;

        public Brick(int W, int H)
        {
            Width = W;
            Height = H;
        }

        public int getWidth()
        {
            return Width;
        }
        public int getHeigth()
        {
            return Height;
        }
        public void setWidth(int W)
        {
            Width = W;
        }
        public void setHeight(int H)
        {
            Height = H;
        }
    }
}
