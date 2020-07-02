using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsComponent;

namespace FactoryLayer
{
    public static class FactoryMaths
    {
        public static dynamic CreateMaths()
        {
            return new MathsLibrary();
        }




    }
}
