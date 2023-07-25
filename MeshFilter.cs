using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230725
{
    class MeshFilter
    {
        public MeshFilter()
        {
            //' ' == " "
            //" " = ' ' '\0'
            Shape = ' ';
        }

        ~MeshFilter() 
        {
        }

        public char Shape;
    }
}
