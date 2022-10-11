using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Primaria
{
    public partial class FrmEliminarSecretaria : Form
    {
        Conexion conecta = new Conexion();
        MySqlConnection sqlCnn = new MySqlConnection(Conexion.cadena);
        MySqlCommand sqlCmd;
        MySqlDataReader myReader;
        public FrmEliminarSecretaria()
        {
            InitializeComponent();
        }

        private void FrmEliminarSecretaria_Load(object sender, EventArgs e)
        {
            actualiza();
           
        }
        private void vacia()
        {
            ID1.Text = ""; id2.Text = ""; id3.Text = "";
            nombre1.Text = ""; nombre2.Text = ""; nombre3.Text = "";
            correo1.Text = ""; correo2.Text = ""; correo3.Text = "";

        }
        private void limpia()
        {
            if (nombre1.Text.Equals("") && correo1.Text.Equals(""))
            {
                button1.Visible = false;
                label1.Visible = false;
            }
            if (nombre2.Text.Equals("") && correo2.Text.Equals(""))
            {
                button2.Visible = false;
                label2.Visible = false;
            }
            if (nombre3.Text.Equals("") && correo3.Text.Equals(""))
            {
                button3.Visible = false;
                label3.Visible = false;
            }
        }
        private void actualiza()
        {
            
            vacia();
            
            int conta = 0;
            try
            {

                string sql = "call softteci_primaria.mostrarSecretarias();";
                sqlCnn.Open();
                sqlCmd = new MySqlCommand(sql, sqlCnn);
                myReader = sqlCmd.ExecuteReader();
                while (myReader.Read())
                {
                    string id, nombre, apepat, apemat, correo;



                    id = myReader["ID"].ToString();
                    nombre = myReader["Nombre"].ToString();
                    apepat = myReader["ApellidoP"].ToString();
                    apemat = myReader["ApellidoM"].ToString();
                    correo = myReader["Correo"].ToString();

                    if (conta == 0) {ID1.Text = id; nombre1.Text = nombre + " " + apepat + " " + apemat; correo1.Text = correo; }
                    if (conta == 1) { nombre2.Text = nombre + " " + apepat + " " + apemat; id2.Text = id; correo2.Text = correo; }
                    if (conta == 2) { nombre3.Text = nombre + " " + apepat + " " + apemat; id3.Text = id; correo3.Text = correo; }
                    /*
                    Productos.Items.Add(nombre);
                    Productos_cantidad.Items.Add(cantidad);
                    Productos_precio.Items.Add(precio);
                    Productos_ID.Items.Add(id); */
                    conta++;

                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Ocurrio un error, revisa tu conexion" + ex.ToString());
            }
            sqlCnn.Close();
            limpia();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtDatoSecre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void correo1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void id1_Click(object sender, EventArgs e)
        {

        }

        public void EliminarSecre (string IDText)
        {
            string id = IDText;
            bool elimina = false;
            try
            {
                string sql = "call softteci_primaria.eliminaUsuario('" + id + "');";
                sqlCnn.Open();
                sqlCmd = new MySqlCommand(sql, sqlCnn);
                sqlCmd.ExecuteNonQuery();
                elimina = true;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1644) { MessageBox.Show("La secretaria no existe"); }


                else
                {
                    MessageBox.Show("Ha ocurrido un error, revisa tu conexion ");
                }

                sqlCnn.Close();
                elimina = false;


            }
            if (elimina.Equals(true)) { MessageBox.Show("Secretaria Eliminada"); }
            sqlCnn.Close();
            actualiza();
          // txtDatoSecre.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EliminarSecre(ID1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarSecre(id2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarSecre(id3.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
