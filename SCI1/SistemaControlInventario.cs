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
    public partial class SistemaControlInventario : Form
    {
        public SistemaControlInventario()
        {
            InitializeComponent();
            
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
                formulario.FormClosed += new FormClosedEventHandler(CerrarFormularios);
            }
            //Si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void btnIAreas_Click(object sender, EventArgs e)
        {
            if (panelAreas.Visible == false)
            {
                panelAreas.Visible = true;
            }
            else
            {
                panelAreas.Visible &= false;
            }
            //this.btnIAreas.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void btnAltas_Click(object sender, EventArgs e)
        {

            if (panelAltas.Visible == false)
            {
                panelAltas.Visible = true;
            }
            else
            {
                panelAltas.Visible &= false;
            }
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            if (panelBajas.Visible == false)
            {
                panelBajas.Visible = true;
            }
            else
            {
                panelBajas.Visible &= false;
            }
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Resumen>();
            this.btnResumen.BackColor = Color.FromArgb(240, 128, 128);
        }
        private void btnRequisicion_Click(object sender, EventArgs e)
        {
            AbrirFormulario<EnviarRequisicon>();
            this.btnRequisicion.BackColor = Color.FromArgb(240, 128, 128);

        }
        private void btnCIS_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InventarioCIS>();
            this.btnCIS.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void btnITN_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InventarioITN>();
            this.btnITN.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void btnMNT_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InventarioMNT>();
            this.btnMNT.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void btnSGR_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InventarioSGR>();
            this.btnSGR.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void btnLBC_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InventarioLBC>();
            this.btnLBC.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void btnAMT_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InventarioAMT>();
            this.btnAMT.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void btnAñadirExistencia_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AñadirStock>();
            this.btnAñadirExistencia.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void btnAñadirArticulo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<NuevoArticulo>();
            this.btnAñadirArticulo.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<EliminarArticulo>();
            this.btnEliminarArticulo.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void btnDisminuirExistencia_Click(object sender, EventArgs e)
        {
            AbrirFormulario<DisminuirStock>();
            this.btnDisminuirExistencia.BackColor = Color.FromArgb(240, 128, 128);
        }

        private void CerrarFormularios(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Resumen"] == null)
                this.btnResumen.BackColor = Color.FromArgb(240, 240, 240);
            if (Application.OpenForms["EnviarRequisicion"] == null)
                this.btnRequisicion.BackColor = Color.FromArgb(240, 240, 240);
            if (Application.OpenForms["InventarioCIS"] == null)
                this.btnCIS.BackColor = Color.FromArgb(240, 240, 240);
            if (Application.OpenForms["InventarioITN"] == null)
                this.btnITN.BackColor = Color.FromArgb(240, 240, 240);
            if (Application.OpenForms["InventarioMNT"] == null)
                this.btnMNT.BackColor = Color.FromArgb(240, 240, 240);
            if (Application.OpenForms["InventarioSGR"] == null)
                this.btnSGR.BackColor = Color.FromArgb(240, 240, 240);
            if (Application.OpenForms["InventarioLBC"] == null)
                this.btnLBC.BackColor = Color.FromArgb(240, 240, 240);
            if (Application.OpenForms["InventarioAMT"] == null)
                this.btnAMT.BackColor = Color.FromArgb(240, 240, 240);
            if (Application.OpenForms["NuevoArticulo"] == null)
                this.btnAñadirArticulo.BackColor = Color.FromArgb(240, 240, 240);
            if (Application.OpenForms["AñadirStock"] == null)
                this.btnAñadirExistencia.BackColor = Color.FromArgb(240, 240, 240);
            if (Application.OpenForms["EliminarArticulo"] == null)
                this.btnEliminarArticulo.BackColor = Color.FromArgb(240, 240, 240);
            if (Application.OpenForms["DisminuirStock"] == null)
                this.btnDisminuirExistencia.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void SistemaControlInventario_Load_1(object sender, EventArgs e)
        {
            this.btnResumen_Click(sender, e);
            //MessageBox.Show("¡Hola! Bienvenido al Sistema de control de inventario ITSAV Unidad Académica Lerdo de Tejada");
        }
    }
}
