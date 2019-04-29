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
            Random random = new Random();
            double numero;
            numero = random.Next(0, 2);
            MessageBox.Show(numero.ToString().Replace(",", "."));

        }


        #region Eventos
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            Logica.LogicaBase.Instancia.RutaDeEjecucion = Application.StartupPath;
            
            
        }
    }

    #endregion

}
