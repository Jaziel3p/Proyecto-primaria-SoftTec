
namespace Primaria
{
    partial class FrmBajaAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBajaAlumno));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxGrupo = new System.Windows.Forms.ListBox();
            this.txtGrado = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatoAlumno = new System.Windows.Forms.TextBox();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrado)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(467, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Baja de un Alumno";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Grado:";
            // 
            // listBoxGrupo
            // 
            this.listBoxGrupo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGrupo.FormattingEnabled = true;
            this.listBoxGrupo.ItemHeight = 20;
            this.listBoxGrupo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.listBoxGrupo.Location = new System.Drawing.Point(231, 25);
            this.listBoxGrupo.Name = "listBoxGrupo";
            this.listBoxGrupo.Size = new System.Drawing.Size(85, 24);
            this.listBoxGrupo.TabIndex = 32;
            // 
            // txtGrado
            // 
            this.txtGrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrado.Location = new System.Drawing.Point(80, 24);
            this.txtGrado.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.txtGrado.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(77, 26);
            this.txtGrado.TabIndex = 31;
            this.txtGrado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Grupo:";
            // 
            // txtDatoAlumno
            // 
            this.txtDatoAlumno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDatoAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatoAlumno.Location = new System.Drawing.Point(334, 23);
            this.txtDatoAlumno.Name = "txtDatoAlumno";
            this.txtDatoAlumno.Size = new System.Drawing.Size(303, 26);
            this.txtDatoAlumno.TabIndex = 34;
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarAlumno.BackgroundImage")));
            this.btnBuscarAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAlumno.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAlumno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuscarAlumno.Location = new System.Drawing.Point(643, 17);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(94, 36);
            this.btnBuscarAlumno.TabIndex = 35;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarAlumno.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtDatoAlumno);
            this.panel1.Controls.Add(this.btnBuscarAlumno);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtGrado);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBoxGrupo);
            this.panel1.Location = new System.Drawing.Point(93, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 75);
            this.panel1.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Primaria.Properties.Resources.descarga__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1064, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(871, 59);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 64);
            this.btnEliminar.TabIndex = 40;
            this.btnEliminar.Text = "Dar de baja en el sistema";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // FrmBajaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 578);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBajaAlumno";
            this.Text = "FrmBajaAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.txtGrado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxGrupo;
        private System.Windows.Forms.NumericUpDown txtGrado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatoAlumno;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEliminar;
    }
}