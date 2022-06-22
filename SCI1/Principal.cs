using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCI1
{
    public partial class FormularioPrincipal : Form
    {
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        public FormularioPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }

        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelInicial.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void OcultarSubMenus()
        {
            if (subMenu.Visible == true)
                subMenu.Visible = true;
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

        private void btnSGR_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InventarioSGR>();
        }

        private void btnLBC_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InventarioLBC>();
        }

        private void btnAMT_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InventarioAMT>();
        }

        private void btnNuevoingreso_Click(object sender, EventArgs e)
        {
            AbrirFormulario<InsertarInventario>();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AbrirFormulario<EliminarArticulo>();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AbrirFormulario<AñadirStock>(); 
        }

        private void btnRestarStcok_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RestarStock>();
        }
    }
}
