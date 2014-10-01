using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryRopa.mundo.interfaces;
using AbstractFactoryRopa.mundo.clases;


namespace AbstractFactoryRopa.mundo.fabricas
{
    class FabricaConverse: IFabricaRopa
    {
       
        public ICamisa crearCamisa()
        {
            return new CamisaConverse();
        }

        public IPantalon crearPantalon()
        {
            return new PantalonConverse();
        }

        public IZapatos crearZapatos()
        {
            return new ZapatosConverse();
        }
    }
}
