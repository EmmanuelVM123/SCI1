using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace SCI1
{
    public partial class InicioSecion : Form
    {
        private readonly string conexion;
        public InicioSecion()
        {
            InitializeComponent();
            conexion = "Server=EVM\\EVM;DataBase= SCI; integrated security = true";
        }
        #region Arrastre
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion


        

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private bool Valida()
        {
            this.errorProvider.Clear();
            bool resultado = true;
            //Validar el campo Usuario
            if (this.cbxUsuario.Text.Trim() == "" || this.cbxUsuario.Text.Trim() == "Usuario")
            {
                resultado = false;
                this.errorProvider.SetError(this.cbxUsuario, "Éste campo es requerido");
            }

            //Validar el campo Contraseña
            if (this.txtContraseña.Text.Trim() == "" || this.txtContraseña.Text.Trim() == "Contraseña")
            {
                resultado = false;
                this.errorProvider.SetError(this.txtContraseña, "Éste campo es requerido");
            }

            return resultado;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(conexion);
        }

        public bool IniciarSesion(string usuario, string contraseña)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select * from Usuario where Usuario=@usuario and Contraseña=@contraseña";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

        }

        private void Acceder()
        {
            try
            {
                if (cbxUsuario.Text != "Usuario")
                {
                    if (txtContraseña.Text != "Contraseña")
                    {
                        var validarSesion = IniciarSesion(cbxUsuario.Text, txtContraseña.Text);
                        if (validarSesion == true)
                        {
                            SistemaControlInventario SCI = new SistemaControlInventario();
                            SCI.Show();
                            SCI.FormClosed += CerrarSesion;
                            this.Hide();


                        }
                        else
                        {
                            MessageBox.Show("El usuario o contraseña no coinciden", "Revise", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    this.Valida();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado: " + ex.Message.ToString(), "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            this.Acceder();
        }
        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            this.errorProvider.Clear();
            cbxUsuario.Text = "Usuario";
            cbxUsuario.ForeColor = Color.Silver;

            txtContraseña.Text = "Contraseña";
            txtContraseña.ForeColor = Color.Silver;
            txtContraseña.UseSystemPasswordChar = false;
            this.Show();
        }
        private void panelArriba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void linkRecuperarPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContraseña RC = new RecuperarContraseña();
            RC.Show();
            this.Hide();
        }

        private void InicioSecion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sCIDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.sCIDataSet.Usuario);

        }

        private void cbxUsuario_MouseEnter(object sender, EventArgs e)
        {
            if (cbxUsuario.Text == "Usuario")
            {
                cbxUsuario.Text = "";
                cbxUsuario.ForeColor = Color.White;
            }
        }

        private void cbxUsuario_MouseLeave(object sender, EventArgs e)
        {
            if (cbxUsuario.Text == "")
            {
                cbxUsuario.Text = "Usuario";
                cbxUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) == true)
            {
                this.Acceder();
            }
        }
    }
}
