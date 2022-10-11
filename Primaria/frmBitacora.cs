using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
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
    public partial class frmBitacora : Form
    {
        public frmBitacora()
        {
            InitializeComponent();
            CrearPDF();
            axAcroPDF1.src = "D:/SEMESTRES/SEMESTRES/SEPTIMO SEMESTRE/Gestion de proyectos/Interfaz/PrimariaAvance8/PrimariaAvance6/Primaria/bin/Debug/Reporte_BitacoraII.pdf";
        }
        private void CrearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter("Reporte_Bitacora.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(180, 80, 60, 80);
            /*var parrafoPrueba = new Paragraph("Bitacora prueba");
            documento.Add(parrafoPrueba);*/

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "Usuario", "Fecha", "Accion" };

            float[] tamanios = { 4, 6, 6 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            string sql = "select usuario, Fecha, Accion from bitacora;";

            Conexion conecta = new Conexion();
            MySqlConnection sqlCnn = new MySqlConnection(Conexion.cadena);
            sqlCnn.Open();

            MySqlCommand comando = new MySqlCommand(sql, sqlCnn);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                tabla.AddCell(new Cell().Add(new Paragraph(reader["usuario"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Fecha"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(reader["Accion"].ToString()).SetFont(fontContenido)));
            }


            documento.Add(tabla);
            documento.Close();

            /*
            CUERPO DE BITACORA 
            */

            var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("softtec-logo3.png")).SetWidth(100);//ubicacion de raiz
            var plogo = new Paragraph("").Add(logo);

            var logoPrim = new iText.Layout.Element.Image(ImageDataFactory.Create("primLogo2.jpeg")).SetWidth(100);//ubicacion de raiz
            var primlogo = new Paragraph("").Add(logoPrim);

            var titulo = new Paragraph("Bitácora");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(21);

            var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
            fecha.SetFontSize(12);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte_Bitacora.pdf"), new PdfWriter("Reporte_BitacoraII.pdf"));
            Document doc = new Document(pdfDoc);

            int numPaginas = pdfDoc.GetNumberOfPages();

            for (int i = 1; i <= numPaginas; i++)
            {
                PdfPage pagina = pdfDoc.GetPage(i);

                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 20);
                doc.ShowTextAligned(plogo, 90, y - 40, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(primlogo, 520, y - 10, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(titulo, 300, y - 45, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 520, y - 120, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("Pagina {0} de {1}", i, numPaginas)),
                    pdfDoc.GetPage(i).GetPageSize().GetWidth() / 2,
                    pdfDoc.GetPage(i).GetPageSize().GetBottom() + 30, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
            }
            doc.Close();

        }
    }
}
    

