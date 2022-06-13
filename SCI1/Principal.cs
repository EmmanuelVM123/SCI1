using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCI1
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void OcultarSubMenus()
        {
            if (subMenu.Visible == false)
                subMenu.Visible = false;
            if (panel1.Visible == false)
                panel1.Visible = false;
            if (panel2.Visible == false)
                panel2.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenus();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }
        private void AbrirFormulario<MiFormulario>() where MiFormulario : Form, new()
        {
            Form formulario;
            formulario = panelContenedor.Controls.OfType<MiFormulario>().FirstOrDefault(); //Busca en la coleción el formulario
            //Si el formulario/instancia no exite
            if (formulario == null)
            {
                formulario = new MiFormulario();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formulario);
                panelContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //Si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnIrCIS_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InventarioCIS>();
        }

        private void btnInventarioAreas_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(subMenu);

        }

        private void btnITN_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InventarioITN>();
        }

        private void btnMNT_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InventarioMNT>();
        }
    }
}
