using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryRopa.mundo.interfaces;
using AbstractFactoryRopa.mundo.clases;

namespace AbstractFactoryRopa.mundo.fabricas
{
    class FabricaLevis: IFabricaRopa
    {
        public ICamisa crearCamisa()
        {
            return new CamisaLevis();
        }

        public IPantalon crearPantalon()
        {
            return new PantalonLevis();
        }

        public IZapatos crearZapatos()
        {
            return new ZapatosLevis();
        }
    }
}
