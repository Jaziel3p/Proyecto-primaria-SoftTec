
namespace Primaria
{
    partial class FrmModificarCalificacion
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
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxGrupo = new System.Windows.Forms.ListBox();
            this.txtGrado = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModificarCalif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrado)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 37;
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
            this.listBoxGrupo.Location = new System.Drawing.Point(269, 13);
            this.listBoxGrupo.Name = "listBoxGrupo";
            this.listBoxGrupo.Size = new System.Drawing.Size(99, 24);
            this.listBoxGrupo.TabIndex = 36;
            // 
            // txtGrado
            // 
            this.txtGrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrado.Location = new System.Drawing.Point(79, 13);
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
            this.txtGrado.TabIndex = 35;
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
            this.label5.Location = new System.Drawing.Point(201, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Grupo:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(451, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Modificar Calificaciones";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtGrado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listBoxGrupo);
            this.panel1.Location = new System.Drawing.Point(334, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 62);
            this.panel1.TabIndex = 39;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Primaria.Properties.Resources.descarga__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1064, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btnModificarCalif
            // 
            this.btnModificarCalif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarCalif.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarCalif.BackgroundImage = global::Primaria.Properties.Resources.botonok;
            this.btnModificarCalif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarCalif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCalif.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCalif.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModificarCalif.Location = new System.Drawing.Point(733, 72);
            this.btnModificarCalif.Name = "btnModificarCalif";
            this.btnModificarCalif.Size = new System.Drawing.Size(116, 62);
            this.btnModificarCalif.TabIndex = 42;
            this.btnModificarCalif.Text = "Modificar Calificación";
            this.btnModificarCalif.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarCalif.UseVisualStyleBackColor = false;
            // 
            // FrmModificarCalificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1176, 578);
            this.Controls.Add(this.btnModificarCalif);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModificarCalificacion";
            this.Text = "FrmModificarCalificacion";
            ((System.ComponentModel.ISupportInitialize)(this.txtGrado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxGrupo;
        private System.Windows.Forms.NumericUpDown txtGrado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnModificarCalif;
    }
}