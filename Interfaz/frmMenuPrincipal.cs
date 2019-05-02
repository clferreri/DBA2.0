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
            int cantidad = 10;
            Logica.Generador gen = new Logica.Generador();
            gen.GenerarCI(cantidad, true);
            gen.GenerarNombres(cantidad);
            gen.GenerarApellidos(cantidad);
            gen.GenerarEdades(cantidad);
            gen.GeneradorBooleano(cantidad);
            gen.GeneradorFecha(cantidad, DateTime.Today.Date, new DateTime(2019, 12, 10));
            gen.GeneradorNumericoRandom(cantidad);
            gen.GeneradorDecimalRandom(cantidad, 3);
            gen.GeneradorDecimalEntreRangos(cantidad, 1, 5, 3);
            gen.GeneradorNumericoEntreRangos(cantidad, 1, 10);

        } 


        #region Eventos
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            Logica.LogicaBase.Instancia.RutaDeEjecucion = Application.StartupPath;
            
            
        }
    }

    #endregion

}
