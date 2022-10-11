using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaria
{
    public partial class FrmAltaSecretaria : Form
    {
        Conexion conecta = new Conexion();
        MySqlConnection sqlCnn = new MySqlConnection(Conexion.cadena);
        MySqlCommand sqlCmd;
        MySqlDataReader myReader;
        string sql;
        public FrmAltaSecretaria()
        {
            InitializeComponent();
        }

        private void btnRegistroSecre_Click(object sender, EventArgs e)
        {

            bool registro = false;
            string nombre = txtNombre.Text;
            string apellidoPat = txtApellidoP.Text;
            string apellidoMat = txtApellidoM.Text;
            string correo = txtCorreo.Text;
            string contrasena = txtContraseña.Text;
            if (txtCorreo.Text.Equals("")) { MessageBox.Show("Hay campos vacios"); }
            else if (validarEmail(txtCorreo.Text) == true) {
                try
                {
                    //call primaria.crearUsuario('nombre', 'apellidoPat', 'apellidoMat', 'correo', 'contraseña');
                    string sql = "call softteci_primaria.crearUsuario('" + nombre + "','" + apellidoPat + "','"
                        + apellidoMat + "','" + correo + "','" + contrasena + "');";
                    sqlCnn.Open();
                    sqlCmd = new MySqlCommand(sql, sqlCnn);
                    sqlCmd.ExecuteNonQuery();
                    registro = true;

                }
                catch (MySqlException ex)
                {
                    //  if (ex.Code == 80004005) { MessageBox.Show("El nombre de usuario ya existe");}
                    //1062
                    if (ex.Number == 1062) { MessageBox.Show("El correo dado ya existe "); }
                    if (ex.Number == 1644) { MessageBox.Show("Solo se pueden registrar máximo 3 secretarias"); }
                    else { MessageBox.Show("Ha ocurrido un error, revisa tu conexion " + e.ToString()); }
                    registro = false;
                }
               
                if (registro)
                {
                    MessageBox.Show("Registro Exitoso");
                    limpia();
                }
                else { MessageBox.Show("Formato de correo no valido"); }

            }
            
                sqlCnn.Close();


        }
        private void limpia()
        {
            txtApellidoM.Text = "";
            txtApellidoP.Text = "";
            txtContraseña.Text = "";
            txtCorreo.Text = "";
            txtNombre.Text = "";
           
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtApellidoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        static bool validarEmail(string email)
        {
            try
            {
               
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
