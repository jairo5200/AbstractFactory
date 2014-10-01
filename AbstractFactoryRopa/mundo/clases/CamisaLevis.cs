using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryRopa.mundo.interfaces;

namespace AbstractFactoryRopa.mundo.clases
{
    class CamisaLevis: ICamisa
    {
        public string darNombre()
        {
            return "Camisa Levis";
        }
    }
}
