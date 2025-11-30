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
    public partial class cobrar : Form
    {
        private Menu menuPrincipal;
        public cobrar(Menu menu)
        {
            InitializeComponent();
            this.menuPrincipal = menu;
        }

        private void cobrarForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            menuPrincipal.AbrirFormulario(new Consulta(menuPrincipal));
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {

        }
    }
}
