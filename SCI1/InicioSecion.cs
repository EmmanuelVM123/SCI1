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
using System.Data;
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
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

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
            if (this.txtUsuario.Text.Trim() == "" || this.txtUsuario.Text.Trim() == "Usuario")
            {
                resultado = false;
                this.errorProvider.SetError(this.txtUsuario, "Éste campo es requerido");
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

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            
            if (txtUsuario.Text!= "Usuario")
            {
                if (txtContraseña.Text != "Contraseña")
                {
                    var validarSesion = IniciarSesion(txtUsuario.Text, txtContraseña.Text);
                    if (validarSesion == true)
                    {
                        SistemaControlInventario SCI = new SistemaControlInventario();
                        this.Hide();
                        SCI.ShowDialog();
                        this.Show();
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

            


            //if (this.Valida())
            //{
            ////Validar desde la base de datos si existen las credenciales
            ////this.usuarioTableAdapter.Fill(this.sciDataSet.Usuario, this.txtUsuario.Text.Trim(), this.txtContraseña.Text.Trim());
            //    if (this.sciDataSet.Usuario.Rows.Count > 0)
            //    {
            //        SistemaControlInventario SCI = new SistemaControlInventario();
            //        this.Hide();
            //        SCI.ShowDialog();
            //        this.Close();
            //    }
            //}

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InicioSecion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
