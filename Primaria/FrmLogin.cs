
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primaria
{
    public partial class FrmLogin : Form
    {
        Conexion conecta = new Conexion();
        
        MySqlConnection sqlCnn = new MySqlConnection(Conexion.cadena);
        MySqlCommand sqlCmd;
        MySqlDataReader myReader;
        MySqlCommand sqlCmd1;
        MySqlCommand sqlCmd2;
        Usuario usu;
        public FrmLogin()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contra = txtPassword.Text;
            if (usuario.Equals(string.Empty)&&contra.Equals(string.Empty))
            {
                MessageBox.Show("Campos vacios");
            }
            else
            {
                verificar1();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            conecta.establecerConexion();
        }

        private void verificar1()
        {
            try
            {
                //AQUI
                lista_usuarios.Clear();
                string verif = ("select verificar('" + txtUsuario.Text + "','" + txtPassword.Text + "');");
                string sql = ("SELECT Nombre,idUsuario FROM softteci_primaria.usuario where CORREO like '" + txtUsuario.Text + "';");
                sqlCnn.Open();


                sqlCmd = new MySqlCommand(verif, sqlCnn);
                sqlCmd1 = new MySqlCommand(sql, sqlCnn);
                sqlCmd.CommandType = CommandType.Text;
                int result = Convert.ToInt32(sqlCmd.ExecuteScalar());
                string ingre = ("select BitacoraIngreso(" + result + ");");
                sqlCmd2 = new MySqlCommand(ingre, sqlCnn);
                sqlCmd2.ExecuteScalar();
                sqlCnn.Close();
                if (result == 0) { MessageBox.Show("Usuario o Contraseña Incorrecto"); }
                else if (result == 2)
                {
                    sqlCnn.Open();

                    MySqlDataReader sqlReader = sqlCmd1.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        
                        string nombre = sqlReader["Nombre"].ToString();
                        /* usu.clave = sqlReader["Contrasena"].ToString();*/
                        int idee = Int32.Parse(sqlReader["idUsuario"].ToString());
                        usu = new Usuario(nombre, idee, true);
                        
                        MessageBox.Show("Bienvenido Director " + nombre);

                    }


                    sqlReader.Close();
                    sqlCnn.Close();



                    // Menu f = new Menu(this, admi, lista_empleados, false);

                    FrmPrincipal f = new FrmPrincipal(usu);
                    this.Hide();
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                    f.Visible = true;
                     // oculta el login
                }
                else if (result == 1)
                {
                    sqlCnn.Open();

                    MySqlDataReader sqlReader = sqlCmd1.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        string nombre = sqlReader["Nombre"].ToString();
                        /* usu.clave = sqlReader["Contrasena"].ToString();*/
                        int idee = Int32.Parse(sqlReader["idUsuario"].ToString());
                        usu = new Usuario(nombre, idee, false);
                        if (result == 1) { MessageBox.Show("Bienvenida Secretaria: " + nombre); }


                    }


                    sqlReader.Close();
                    sqlCnn.Close();
                    this.Hide(); // oculta el login

                   // bool registro_1 = false;
                   // Menu f = new Menu(this, usu, lista_empleados, registro_1);
                    /* empleados_disponibles.Text = ""; */
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                    FrmPrincipal f = new FrmPrincipal(usu);
                    f.Visible = true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hubo un error! Revisa tu conexion " + ex.ToString());
            }
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                verificar1();
        }
    }
}
