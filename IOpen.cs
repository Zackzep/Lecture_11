using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_11
{
    internal interface IOpen
    {
        //Can have fields but they have to be constant
        const double _maxRotationalValue = 90;
        const double _minValue = 0;
        
        
        //Method signature(just name no body)
        public void Open();

    }
}
