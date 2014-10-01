using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AbstractFactoryRopa.mundo.clases;
using AbstractFactoryRopa.mundo.fabricas;
using AbstractFactoryRopa.mundo.interfaces;

namespace AbstractFactoryRopa
{
    public partial class Cliente : Form
    {
        private IFabricaRopa fabrica;
        private ICamisa auto;
        private IPantalon motor;
        private IZapatos carroceria; 

        public Cliente()
        {
            InitializeComponent();
            lst_partes.SelectedIndex = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (rad_mazda.Checked)
                fabrica = new FabricaConverse();
            else
                fabrica = new FabricaLevis();
            auto = fabrica.crearCamisa();
            motor = fabrica.crearPantalon();
            carroceria = fabrica.crearZapatos();

            if (lst_partes.SelectedIndex == 0)
                MessageBox.Show(auto.darNombre());
            else if (lst_partes.SelectedIndex == 1)
                MessageBox.Show(motor.darNombre());
            else if (lst_partes.SelectedIndex == 2)
                MessageBox.Show(carroceria.darNombre());
        }
    }
}
