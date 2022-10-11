
namespace Primaria
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStripInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuAltas = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuBusqueda = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuBajas = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCalificaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuAsentarCalif = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuVisualizarCalif = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuVisualizarBoletas = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuModificarCalif = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSecretarias = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarSecretariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarSecretariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoUsuario = new System.Windows.Forms.Label();
            this.BtnMaximizar = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripInicio,
            this.menuStripAlumnos,
            this.menuStripCalificaciones,
            this.menuStripBitacora,
            this.menuStripSecretarias,
            this.menuStripEstadisticas,
            this.menuStripCerrarSesion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1600, 64);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStripInicio
            // 
            this.menuStripInicio.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripInicio.Image = global::Primaria.Properties.Resources.casaprin;
            this.menuStripInicio.Name = "menuStripInicio";
            this.menuStripInicio.Size = new System.Drawing.Size(139, 60);
            this.menuStripInicio.Text = "INICIO";
            this.menuStripInicio.Click += new System.EventHandler(this.menuStripInicio_Click);
            // 
            // menuStripAlumnos
            // 
            this.menuStripAlumnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuAltas,
            this.subMenuBusqueda,
            this.subMenuBajas,
            this.subMenuModificar});
            this.menuStripAlumnos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripAlumnos.Image = global::Primaria.Properties.Resources.alu;
            this.menuStripAlumnos.Name = "menuStripAlumnos";
            this.menuStripAlumnos.Size = new System.Drawing.Size(186, 60);
            this.menuStripAlumnos.Text = "ALUMNOS";
            // 
            // subMenuAltas
            // 
            this.subMenuAltas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuAltas.Name = "subMenuAltas";
            this.subMenuAltas.Size = new System.Drawing.Size(335, 32);
            this.subMenuAltas.Text = "Dar de alta a un alumno";
            this.subMenuAltas.Click += new System.EventHandler(this.subMenuAltas_Click);
            // 
            // subMenuBusqueda
            // 
            this.subMenuBusqueda.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuBusqueda.Name = "subMenuBusqueda";
            this.subMenuBusqueda.Size = new System.Drawing.Size(335, 32);
            this.subMenuBusqueda.Text = "Búsqueda de datos";
            // 
            // subMenuBajas
            // 
            this.subMenuBajas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuBajas.Name = "subMenuBajas";
            this.subMenuBajas.Size = new System.Drawing.Size(335, 32);
            this.subMenuBajas.Text = "Dar de baja a un alumno";
            this.subMenuBajas.Click += new System.EventHandler(this.subMenuBajas_Click);
            // 
            // subMenuModificar
            // 
            this.subMenuModificar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuModificar.Name = "subMenuModificar";
            this.subMenuModificar.Size = new System.Drawing.Size(335, 32);
            this.subMenuModificar.Text = "Modificar Datos";
            this.subMenuModificar.Click += new System.EventHandler(this.subMenuModificar_Click);
            // 
            // menuStripCalificaciones
            // 
            this.menuStripCalificaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuAsentarCalif,
            this.subMenuVisualizarCalif,
            this.subMenuVisualizarBoletas,
            this.subMenuModificarCalif});
            this.menuStripCalificaciones.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripCalificaciones.Image = global::Primaria.Properties.Resources.calif;
            this.menuStripCalificaciones.Name = "menuStripCalificaciones";
            this.menuStripCalificaciones.Size = new System.Drawing.Size(285, 60);
            this.menuStripCalificaciones.Text = "CALIFICACIONES";
            // 
            // subMenuAsentarCalif
            // 
            this.subMenuAsentarCalif.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuAsentarCalif.Name = "subMenuAsentarCalif";
            this.subMenuAsentarCalif.Size = new System.Drawing.Size(337, 32);
            this.subMenuAsentarCalif.Text = "Asentar Calificaciones";
            this.subMenuAsentarCalif.Click += new System.EventHandler(this.subMenuAsentarCalif_Click);
            // 
            // subMenuVisualizarCalif
            // 
            this.subMenuVisualizarCalif.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuVisualizarCalif.Name = "subMenuVisualizarCalif";
            this.subMenuVisualizarCalif.Size = new System.Drawing.Size(337, 32);
            this.subMenuVisualizarCalif.Text = "Visualizar Calificaciones";
            this.subMenuVisualizarCalif.Click += new System.EventHandler(this.subMenuVisualizarCalif_Click);
            // 
            // subMenuVisualizarBoletas
            // 
            this.subMenuVisualizarBoletas.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuVisualizarBoletas.Name = "subMenuVisualizarBoletas";
            this.subMenuVisualizarBoletas.Size = new System.Drawing.Size(337, 32);
            this.subMenuVisualizarBoletas.Text = "Visualizar Boletas";
            // 
            // subMenuModificarCalif
            // 
            this.subMenuModificarCalif.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuModificarCalif.Name = "subMenuModificarCalif";
            this.subMenuModificarCalif.Size = new System.Drawing.Size(337, 32);
            this.subMenuModificarCalif.Text = "Modificar Calificaciones";
            this.subMenuModificarCalif.Click += new System.EventHandler(this.subMenuModificarCalif_Click);
            // 
            // menuStripBitacora
            // 
            this.menuStripBitacora.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripBitacora.Image = global::Primaria.Properties.Resources.bitacora;
            this.menuStripBitacora.Name = "menuStripBitacora";
            this.menuStripBitacora.Size = new System.Drawing.Size(193, 60);
            this.menuStripBitacora.Text = "BITÁCORA";
            this.menuStripBitacora.Click += new System.EventHandler(this.menuStripBitacora_Click);
            // 
            // menuStripSecretarias
            // 
            this.menuStripSecretarias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarSecretariaToolStripMenuItem,
            this.eliminarSecretariaToolStripMenuItem});
            this.menuStripSecretarias.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripSecretarias.Image = global::Primaria.Properties.Resources.secre;
            this.menuStripSecretarias.Name = "menuStripSecretarias";
            this.menuStripSecretarias.Size = new System.Drawing.Size(238, 60);
            this.menuStripSecretarias.Text = "SECRETARIAS";
            // 
            // registrarSecretariaToolStripMenuItem
            // 
            this.registrarSecretariaToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarSecretariaToolStripMenuItem.Name = "registrarSecretariaToolStripMenuItem";
            this.registrarSecretariaToolStripMenuItem.Size = new System.Drawing.Size(289, 32);
            this.registrarSecretariaToolStripMenuItem.Text = "Registrar Secretaria";
            this.registrarSecretariaToolStripMenuItem.Click += new System.EventHandler(this.registrarSecretariaToolStripMenuItem_Click);
            // 
            // eliminarSecretariaToolStripMenuItem
            // 
            this.eliminarSecretariaToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarSecretariaToolStripMenuItem.Name = "eliminarSecretariaToolStripMenuItem";
            this.eliminarSecretariaToolStripMenuItem.Size = new System.Drawing.Size(289, 32);
            this.eliminarSecretariaToolStripMenuItem.Text = "Eliminar Secretaria";
            this.eliminarSecretariaToolStripMenuItem.Click += new System.EventHandler(this.eliminarSecretariaToolStripMenuItem_Click);
            // 
            // menuStripEstadisticas
            // 
            this.menuStripEstadisticas.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripEstadisticas.Image = global::Primaria.Properties.Resources.estadisticas;
            this.menuStripEstadisticas.Name = "menuStripEstadisticas";
            this.menuStripEstadisticas.Size = new System.Drawing.Size(243, 60);
            this.menuStripEstadisticas.Text = "ESTADÍSTICAS";
            this.menuStripEstadisticas.Click += new System.EventHandler(this.menuStripEstadisticas_Click);
            // 
            // menuStripCerrarSesion
            // 
            this.menuStripCerrarSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuStripCerrarSesion.BackColor = System.Drawing.SystemColors.Window;
            this.menuStripCerrarSesion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripCerrarSesion.Image = global::Primaria.Properties.Resources.cerrarsesion;
            this.menuStripCerrarSesion.Name = "menuStripCerrarSesion";
            this.menuStripCerrarSesion.Size = new System.Drawing.Size(195, 60);
            this.menuStripCerrarSesion.Text = "CERRAR SESIÓN";
            this.menuStripCerrarSesion.Click += new System.EventHandler(this.menuStripCerrarSesion_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1605, 28);
            this.menuStrip2.TabIndex = 15;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCerrar.Location = new System.Drawing.Point(1517, -1);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(88, 31);
            this.BtnCerrar.TabIndex = 19;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(16, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1568, 711);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // infoUsuario
            // 
            this.infoUsuario.AutoSize = true;
            this.infoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.infoUsuario.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoUsuario.Location = new System.Drawing.Point(113, 0);
            this.infoUsuario.Name = "infoUsuario";
            this.infoUsuario.Size = new System.Drawing.Size(151, 28);
            this.infoUsuario.TabIndex = 21;
            this.infoUsuario.Text = "Info de usuario";
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.BackgroundImage = global::Primaria.Properties.Resources.maximizar;
            this.BtnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMaximizar.Location = new System.Drawing.Point(1432, 0);
            this.BtnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(91, 31);
            this.BtnMaximizar.TabIndex = 18;
            this.BtnMaximizar.UseVisualStyleBackColor = true;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnMinimizar.BackgroundImage = global::Primaria.Properties.Resources.menos;
            this.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.Location = new System.Drawing.Point(1348, 0);
            this.BtnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(88, 31);
            this.BtnMinimizar.TabIndex = 17;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1605, 837);
            this.Controls.Add(this.infoUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnMaximizar);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripInicio;
        private System.Windows.Forms.ToolStripMenuItem menuStripAlumnos;
        private System.Windows.Forms.ToolStripMenuItem subMenuAltas;
        private System.Windows.Forms.ToolStripMenuItem subMenuBusqueda;
        private System.Windows.Forms.ToolStripMenuItem subMenuBajas;
        private System.Windows.Forms.ToolStripMenuItem subMenuModificar;
        private System.Windows.Forms.ToolStripMenuItem menuStripCalificaciones;
        private System.Windows.Forms.ToolStripMenuItem subMenuAsentarCalif;
        private System.Windows.Forms.ToolStripMenuItem subMenuVisualizarCalif;
        private System.Windows.Forms.ToolStripMenuItem subMenuVisualizarBoletas;
        private System.Windows.Forms.ToolStripMenuItem subMenuModificarCalif;
        private System.Windows.Forms.ToolStripMenuItem menuStripBitacora;
        private System.Windows.Forms.ToolStripMenuItem menuStripSecretarias;
        private System.Windows.Forms.ToolStripMenuItem registrarSecretariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarSecretariaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button BtnMaximizar;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem menuStripEstadisticas;
        private System.Windows.Forms.ToolStripMenuItem menuStripCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label infoUsuario;
    }
}