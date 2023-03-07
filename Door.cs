using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_11
{
    internal class Door : Chest, IOpen, IClose
    {


        //Method signature
        public void Close()
        {
            throw new NotImplementedException();
        }
    }
}
