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

namespace Primaria
{
    public partial class FrmPrincipal : Form
    {
        Conexion conecta = new Conexion();
        MySqlConnection sqlCnn = new MySqlConnection(Conexion.cadena);
        MySqlCommand sqlCmd2;
        Usuario usuario;
        public FrmPrincipal()
        {
            InitializeComponent();
            AbrirFormHija(new FrmInicio());
        }

        public FrmPrincipal( Usuario n)
        {
            usuario = n;
            InitializeComponent();
            AbrirFormHija(new FrmInicio());
        }


        private void AbrirFormHija(object formhija)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void subMenuAltas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmAltaAlumno());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(menuStripCerrarSesion_Click);
            infoUsuario.Text = usuario.getRol() + ": " + usuario.getNombre();
            if (usuario.getPrivilegio().Equals(false))
            {
                subMenuModificar.Visible = false;
                subMenuBajas.Visible = false;
                subMenuModificarCalif.Visible = false;
                menuStripBitacora.Visible = false;
                menuStripSecretarias.Visible = false;
            }
            
           Cursor = Cursors.Default;
        }

        private void menuStripInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmInicio());
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registrarSecretariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmAltaSecretaria());
        }

        private void subMenuAsentarCalif_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmAsentarCalificacion());
        }

        private void subMenuBajas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmBajaAlumno());
        }

        private void subMenuVisualizarCalif_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmVisualizarCalificacion());
        }

        private void menuStripCerrarSesion_Click(object sender, EventArgs e)
        {
            ValSalid();
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void eliminarSecretariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmEliminarSecretaria());
        }

        private void subMenuModificarCalif_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmModificarCalificacion());
        }

        public void ValSalid()
        {
            sqlCnn.Open();
            int salida;
            salida = 0;
            if (usuario.getRol() == "Secretaria")
            {
                salida = 3;

            }
            else if (usuario.getRol() == "Director")
            {
                salida = 4;

            }
            string ingre = ("select BitacoraIngreso(" + salida + ");");
            sqlCmd2 = new MySqlCommand(ingre, sqlCnn);
            sqlCmd2.ExecuteScalar();
            sqlCnn.Close();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {

            ValSalid();
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
       }


        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Minimized;
            else if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
        }

        private void menuStripBitacora_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmBitacora());
        }

        private void menuStripEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmEstadisticas());
        }

        private void subMenuModificar_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FrmModificarAlumno());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
