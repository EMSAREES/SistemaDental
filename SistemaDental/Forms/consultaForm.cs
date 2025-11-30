using SistemaDental.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaDental.Forms
{
    public partial class Consulta : Form
    {
        private Menu menuPrincipal;


        public Consulta(Menu menu)
        {
            InitializeComponent();
            this.menuPrincipal = menu;

        }


        private void btnCobrar_Click(object sender, EventArgs e)
        {
            menuPrincipal.AbrirFormulario(new cobrar(menuPrincipal));

        }

        private void motivodeconsulta_Click(object sender, EventArgs e)
        {

        }
    }
}
