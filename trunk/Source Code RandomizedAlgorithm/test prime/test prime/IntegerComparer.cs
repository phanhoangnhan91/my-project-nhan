using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    class IntegerComparer : IComparer
    {
        private int _colIndex;
        public IntegerComparer(int colIndex)
        {
            _colIndex = colIndex;
        }
        public int Compare(object x, object y) 
        { 
            double nx = double.Parse((x as ListViewItem).SubItems[_colIndex].Text); 
            double ny = double.Parse((y as ListViewItem).SubItems[_colIndex].Text); 
            return nx.CompareTo(ny); 
        } 
    }
}
