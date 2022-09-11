using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace SCI1
{
    public partial class SistemaControlInventario : Form
    {
        public SistemaControlInventario()
        {
            InitializeComponent();
        }
        private void SistemaControlInventario_Load_1(object sender, EventArgs e)
        {
            this.btnMinizar.Visible = true;
            this.bntAchicar.Visible = false;
            this.btnReportes.Visible = false;
            btnResumen_Click(sender, e);
        }
        #region Arrastre
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion
        public void AbrirFormulario<MiFormulario>() where MiFormulario : Form, new()
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
            AbrirFormulario<EnviarRequisicion>();
            this.btnRequisicion.BackColor = Color.FromArgb(240, 128, 128);

        }
        private void btnReportes_Click(object sender, EventArgs e)
        {

            this.btnReportes.BackColor = Color.FromArgb(240, 128, 128);
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
            if (Application.OpenForms["Reportes"] == null)
                this.btnReportes.BackColor = Color.FromArgb(240, 240, 240);
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Está segur@ de cerrar la sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bntCerrar_Click(object sender, EventArgs e)
        {
            InicioSecion IS = new InicioSecion();
            if (MessageBox.Show("¿Está segur@ de cerrar la Sesión? y salir de la Apliación", "Cerrar sesión y salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
                IS.Close();
            }
        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panelCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bntAchicar_Click(object sender, EventArgs e)
        {
                this.Size = new Size(1370, 749);
                this.bntAchicar.Visible = false;
                this.btnAgrandar.Visible = true;   
        }

        private void btnAgrandar_Click(object sender, EventArgs e)
        {  
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;  
                this.btnAgrandar.Visible = false;
                this.bntAchicar.Visible = true;   
        }
    }
}
