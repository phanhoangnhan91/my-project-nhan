using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectClosestPair
{
    public class IPoint : IComparable
    {
        private int _x;

        public int _X
        {
            get { return _x; }
            set { _x = value; }
        }
        private int _y;

        public int _Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public int CompareTo(Object obj)
        {
            if (obj is IPoint)
            {
                IPoint other = (IPoint)obj;
                if (this._x == other._X)
                {
                    return this._y.CompareTo(other._Y);
                }
                return this._x.CompareTo(other._Y);
            }
            else
                throw new ArgumentException("This is not a point");
        }
        public IPoint()
        {
            _X = _Y = 0;
        }

        public IPoint(int x, int y)
        {
            this._X = x;
            this._Y = y;
        }
    }
}
