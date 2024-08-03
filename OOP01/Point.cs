using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    internal struct Point
    {

        #region Attributes

        public int X;
        public int Y;

        #endregion

        

        #region Constructor


        public Point()
        {
            X = 1;
            Y = 2;
        }

        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }

        public Point(int Number)
        {
            X = Y = Number;


        }
        #endregion


        #region Methods

        public override string ToString()
        {
            return $"({this.X} , {this.Y})"; 
        }

        #endregion
    }
}
