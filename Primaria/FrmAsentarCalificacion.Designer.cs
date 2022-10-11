
namespace Primaria
{
    partial class FrmAsentarCalificacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxCiclo = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxMes = new System.Windows.Forms.ListBox();
            this.numericUPGrado = new System.Windows.Forms.NumericUpDown();
            this.listBoxGrupo = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUPGrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(457, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Asentar Calificaciones";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBoxCiclo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.listBoxMes);
            this.panel1.Controls.Add(this.numericUPGrado);
            this.panel1.Controls.Add(this.listBoxGrupo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(88, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 65);
            this.panel1.TabIndex = 42;
            // 
            // listBoxCiclo
            // 
            this.listBoxCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCiclo.FormattingEnabled = true;
            this.listBoxCiclo.ItemHeight = 20;
            this.listBoxCiclo.Items.AddRange(new object[] {
            "2021-2022"});
            this.listBoxCiclo.Location = new System.Drawing.Point(494, 18);
            this.listBoxCiclo.Name = "listBoxCiclo";
            this.listBoxCiclo.Size = new System.Drawing.Size(106, 24);
            this.listBoxCiclo.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(377, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 23);
            this.label8.TabIndex = 35;
            this.label8.Text = "Ciclo Escolar:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(198, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "Grupo:";
            // 
            // listBoxMes
            // 
            this.listBoxMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMes.FormattingEnabled = true;
            this.listBoxMes.ItemHeight = 20;
            this.listBoxMes.Items.AddRange(new object[] {
            "Septiembre"});
            this.listBoxMes.Location = new System.Drawing.Point(675, 18);
            this.listBoxMes.Name = "listBoxMes";
            this.listBoxMes.Size = new System.Drawing.Size(106, 24);
            this.listBoxMes.TabIndex = 39;
            // 
            // numericUPGrado
            // 
            this.numericUPGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUPGrado.Location = new System.Drawing.Point(82, 20);
            this.numericUPGrado.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUPGrado.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUPGrado.Name = "numericUPGrado";
            this.numericUPGrado.Size = new System.Drawing.Size(99, 26);
            this.numericUPGrado.TabIndex = 31;
            this.numericUPGrado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBoxGrupo
            // 
            this.listBoxGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGrupo.FormattingEnabled = true;
            this.listBoxGrupo.ItemHeight = 20;
            this.listBoxGrupo.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.listBoxGrupo.Location = new System.Drawing.Point(266, 19);
            this.listBoxGrupo.Name = "listBoxGrupo";
            this.listBoxGrupo.Size = new System.Drawing.Size(99, 24);
            this.listBoxGrupo.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(625, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 23);
            this.label10.TabIndex = 37;
            this.label10.Text = "Mes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 23);
            this.label11.TabIndex = 33;
            this.label11.Text = "Grado:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(897, 53);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 64);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Primaria.Properties.Resources.descarga__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1064, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAsentarCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1176, 578);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAsentarCalificacion";
            this.Text = "FormAsentarCalificacion";
            this.Load += new System.EventHandler(this.FrmAsentarCalificacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUPGrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxCiclo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxMes;
        private System.Windows.Forms.NumericUpDown numericUPGrado;
        private System.Windows.Forms.ListBox listBoxGrupo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGuardar;
    }
}