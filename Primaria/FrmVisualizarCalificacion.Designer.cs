
namespace Primaria
{
    partial class FrmVisualizarCalificacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxGrupo = new System.Windows.Forms.ListBox();
            this.txtGrado = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxCiclo = new System.Windows.Forms.ListBox();
            this.listBoxMes = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(439, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Visualizar Calificaciones";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Grado:";
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
            this.listBoxGrupo.Location = new System.Drawing.Point(291, 22);
            this.listBoxGrupo.Name = "listBoxGrupo";
            this.listBoxGrupo.Size = new System.Drawing.Size(99, 24);
            this.listBoxGrupo.TabIndex = 32;
            // 
            // txtGrado
            // 
            this.txtGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrado.Location = new System.Drawing.Point(107, 23);
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
            this.txtGrado.Size = new System.Drawing.Size(99, 26);
            this.txtGrado.TabIndex = 31;
            this.txtGrado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = "Grupo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(650, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Mes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ciclo Escolar:";
            // 
            // listBoxCiclo
            // 
            this.listBoxCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCiclo.FormattingEnabled = true;
            this.listBoxCiclo.ItemHeight = 20;
            this.listBoxCiclo.Items.AddRange(new object[] {
            "2021-2022",
            ""});
            this.listBoxCiclo.Location = new System.Drawing.Point(519, 21);
            this.listBoxCiclo.Name = "listBoxCiclo";
            this.listBoxCiclo.Size = new System.Drawing.Size(106, 24);
            this.listBoxCiclo.TabIndex = 38;
            // 
            // listBoxMes
            // 
            this.listBoxMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMes.FormattingEnabled = true;
            this.listBoxMes.ItemHeight = 20;
            this.listBoxMes.Items.AddRange(new object[] {
            "Septiembre"});
            this.listBoxMes.Location = new System.Drawing.Point(700, 21);
            this.listBoxMes.Name = "listBoxMes";
            this.listBoxMes.Size = new System.Drawing.Size(106, 24);
            this.listBoxMes.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Primaria.Properties.Resources.descarga__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1064, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listBoxMes);
            this.panel1.Controls.Add(this.txtGrado);
            this.panel1.Controls.Add(this.listBoxCiclo);
            this.panel1.Controls.Add(this.listBoxGrupo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(150, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 65);
            this.panel1.TabIndex = 41;
            // 
            // FrmVisualizarCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVisualizarCalificacion";
            this.Text = "FrmVisualizarCalificacion";
            ((System.ComponentModel.ISupportInitialize)(this.txtGrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxGrupo;
        private System.Windows.Forms.NumericUpDown txtGrado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxCiclo;
        private System.Windows.Forms.ListBox listBoxMes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}