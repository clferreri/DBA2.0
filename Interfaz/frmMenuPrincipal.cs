using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Interfaz
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Logica.LogicaBase.Instancia.MotorDeBD = 2;
            int numero = Logica.LogicaBase.Instancia.MotorDeBD;
            MessageBox.Show(Logica.LogicaBase.Instancia.RutaDeEjecucion);
            Logica.LogicaBase.Instancia.ConfigurarListasAutomaticas();
        }


        #region Eventos
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            Logica.LogicaBase.Instancia.RutaDeEjecucion = Application.StartupPath;
            
            
        }
    }

    #endregion

}
