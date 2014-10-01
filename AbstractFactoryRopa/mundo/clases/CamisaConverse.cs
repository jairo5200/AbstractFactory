using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryRopa.mundo.interfaces;

namespace AbstractFactoryRopa.mundo.clases
{
    class CamisaConverse: ICamisa
    {
        public string darNombre()
        {
            return "Camisa converse";
        }
    }
}
