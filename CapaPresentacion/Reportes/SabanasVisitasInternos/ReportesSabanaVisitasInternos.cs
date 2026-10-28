using CapaDatos;
using CommonCache;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio;

namespace CapaPresentacion.Reportes.SabanasVisitasInternos
{
    public class ReportesSabanaVisitasInternos
    {
        //VINCULOS DE LA VISITA         
        public static MemoryStream RepPdfVinculosDeLaVisita(DCiudadanoSabanaResponse dCiudadanoSabanaResponse)
        {
            MemoryStream ms = new MemoryStream();

            Document doc = new Document(PageSize.A4.Rotate(), 30, 30, 30, 30);

            PdfWriter writer = PdfWriter.GetInstance(doc, ms);
            writer.CloseStream = false; // evita cerrar el MemoryStream al cerrar el documento

            doc.Open();

            var fuenteLogo = FontFactory.GetFont(FontFactory.TIMES, 9, BaseColor.BLACK);
            var fuenteOrganismo = FontFactory.GetFont(FontFactory.TIMES, 10, BaseColor.BLACK);
            var fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, BaseColor.BLACK);
            var fuenteNormal = FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.BLACK);

            

            string organismo = CurrentUser.Instance.organismo.ToUpper();
            // Crear tabla con 2 columnas
            PdfPTable tablaEncabezado = new PdfPTable(1);
            tablaEncabezado.WidthPercentage = 35; // ocupa la mitad de la página
            tablaEncabezado.HorizontalAlignment = Element.ALIGN_LEFT; // tabla a la izquierda

            // Centrar contenido de todas las celdas
            tablaEncabezado.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            tablaEncabezado.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            tablaEncabezado.DefaultCell.Border = Rectangle.NO_BORDER;

            // Agregar celdas
            tablaEncabezado.AddCell(new Paragraph("  SERVICIO PENITENCIARIO DE LA PROVINCIA DE SALTA", fuenteLogo));
            tablaEncabezado.AddCell(new Paragraph(organismo, fuenteOrganismo));

            // Agregar tabla al documento
            doc.Add(tablaEncabezado);
            //fin logo encabezado.....................................

            //fecha
            DateTime fechaHoy = DateTime.Now;
            CultureInfo cultura = new CultureInfo("es-ES");

            // "d 'de' MMMM 'de' yyyy" → ejemplo: "9 de septiembre de 2025"
            string fechaCompleta = "Salta, " + fechaHoy.ToString("d 'de' MMMM 'de' yyyy", cultura);

            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(fechaCompleta, fuenteNormal)
            {
                Alignment = Element.ALIGN_RIGHT
            });
            //fin fecha.............................

            //CARGAR DATOS
            List<DVisitaInterno> listaVinculos = dCiudadanoSabanaResponse.listaVinculosResponse;

            //datos ciudadano
            doc.Add(new Paragraph(" Apellido y nombre: " + dCiudadanoSabanaResponse.nombre_visita, fuenteNormal));
            doc.Add(new Paragraph(" DNI: " + dCiudadanoSabanaResponse.dni, fuenteNormal));
            doc.Add(new Paragraph(" Sexo: " + dCiudadanoSabanaResponse.sexo + "      -      Edad: " + dCiudadanoSabanaResponse.edad, fuenteNormal));
            doc.Add(new Paragraph(" Domicilio: " + dCiudadanoSabanaResponse.domicilio, fuenteNormal));

            //fin datos ciudadano

            //doc.Add(new Paragraph(" "));

            Paragraph titulo = new Paragraph("Vinculos de la visita", fuenteTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.SpacingAfter = 8;
            doc.Add(titulo);

            //doc.Add(new Paragraph(" "));

            PdfPTable tablaVinculos = new PdfPTable(8);
            tablaVinculos.WidthPercentage = 100;
            tablaVinculos.SetWidths(new float[] { 2.5f, 1.0f, 1.5f, 0.6f, 0.7f, 0.7f, 0.7f, 2.6f });
            tablaVinculos.AddCell(new Paragraph("Interno", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Parentesco", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Unidad", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Vigente", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Prohibido", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Inicio", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Fin", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Detalle", fuenteTitulo));

            // Filas dinámicas
            foreach (var vinculo in listaVinculos)
            {
                tablaVinculos.AddCell(new Paragraph(vinculo.interno.apellido.ToString() + " " + vinculo.interno.nombre.ToString(), fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(vinculo.parentesco.parentesco, fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(vinculo.interno.organismo.organismo.ToString(), fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(vinculo.vigente ? "SI" : "NO", fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(vinculo.prohibido ? "SI" : "NO", fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(vinculo.fecha_inicio?.ToString("dd/MM/yyyy") ?? "", fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(vinculo.fecha_fin?.ToString("dd/MM/yyyy") ?? "", fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(vinculo.detalles_prohibicion, fuenteNormal));

            }

            doc.Add(tablaVinculos);

            doc.Close(); // Cierra el documento pero NO el MemoryStream
            ms.Position = 0;

            return ms;
        }
        //FIN VINCULOS DE LA VISITA
        //----------------------------------------------------------------------------------

        //VINCULOS DEL INTERNO         
        public static MemoryStream RepPdfVinculosDelInterno(DInternoSabanaResponse dInternoSabanaResponse)
        {
            MemoryStream ms = new MemoryStream();

            Document doc = new Document(PageSize.A4.Rotate(), 30, 30, 30, 30);

            PdfWriter writer = PdfWriter.GetInstance(doc, ms);
            writer.CloseStream = false; // evita cerrar el MemoryStream al cerrar el documento

            doc.Open();

            var fuenteLogo = FontFactory.GetFont(FontFactory.TIMES, 9, BaseColor.BLACK);
            var fuenteOrganismo = FontFactory.GetFont(FontFactory.TIMES, 10, BaseColor.BLACK);
            var fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9, BaseColor.BLACK);
            var fuenteNormal = FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.BLACK);



            string organismo = CurrentUser.Instance.organismo.ToUpper();
            // Crear tabla con 2 columnas
            PdfPTable tablaEncabezado = new PdfPTable(1);
            tablaEncabezado.WidthPercentage = 35; // ocupa la mitad de la página
            tablaEncabezado.HorizontalAlignment = Element.ALIGN_LEFT; // tabla a la izquierda

            // Centrar contenido de todas las celdas
            tablaEncabezado.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            tablaEncabezado.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            tablaEncabezado.DefaultCell.Border = Rectangle.NO_BORDER;

            // Agregar celdas
            tablaEncabezado.AddCell(new Paragraph("  SERVICIO PENITENCIARIO DE LA PROVINCIA DE SALTA", fuenteLogo));
            tablaEncabezado.AddCell(new Paragraph(organismo, fuenteOrganismo));

            // Agregar tabla al documento
            doc.Add(tablaEncabezado);
            //fin logo encabezado.....................................

            //fecha
            DateTime fechaHoy = DateTime.Now;
            CultureInfo cultura = new CultureInfo("es-ES");

            // "d 'de' MMMM 'de' yyyy" → ejemplo: "9 de septiembre de 2025"
            string fechaCompleta = "Salta, " + fechaHoy.ToString("d 'de' MMMM 'de' yyyy", cultura);

            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(fechaCompleta, fuenteNormal)
            {
                Alignment = Element.ALIGN_RIGHT
            });
            //fin fecha.............................

            //CARGAR DATOS
            List<DVisitaInterno> listaVinculos = dInternoSabanaResponse.listaVinculosResponse;

            //datos interno
            doc.Add(new Paragraph(" Apellido y nombre del interno: " + dInternoSabanaResponse.nombre_interno, fuenteNormal));
            doc.Add(new Paragraph(" prontuario: " + dInternoSabanaResponse.prontuario, fuenteNormal));

            //fin datos interno


            Paragraph titulo = new Paragraph("Vinculos del interno", fuenteTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.SpacingAfter = 8;
            doc.Add(titulo);

            //doc.Add(new Paragraph(" "));

            PdfPTable tablaVinculos = new PdfPTable(5);
            tablaVinculos.WidthPercentage = 100;
            tablaVinculos.SetWidths(new float[] { 2.5f, 1.0f, 0.6f, 2.1f, 2.6f });
            tablaVinculos.AddCell(new Paragraph("Visita", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Parentesco", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Vigente", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Prohibicion de vinculo", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Prohibiciones de ingreso", fuenteTitulo));

            // Filas dinámicas
            foreach (var vinculo in listaVinculos)
            {
                List<DProhibicionVisita> listaProhibiciones = vinculo.ciudadano.prohibiciones_visita;
                string prohibicionesIngresoAux = "";
                foreach (var prohibicion in listaProhibiciones)
                {
                    prohibicionesIngresoAux = "Inicio: " + prohibicion.fecha_inicio.ToString("dd/MM/yyyy")
                                        + ", Fin: " + prohibicion.fecha_fin.ToString("dd/MM/yyyy")
                                        + ", detalle: " + prohibicion.detalle
                                        + ", organismo: " + prohibicion.organismo.organismo
                                        + " // " + prohibicionesIngresoAux;
                }

                string prohibicionVinculoAux = "";
                if (vinculo.prohibido)
                {
                    prohibicionVinculoAux = "Inicio: " + vinculo.fecha_inicio?.ToString("dd/MM/yyyy")
                                        + ", Fin: " + vinculo.fecha_fin?.ToString("dd/MM/yyyy")
                                        + ", detalle: " + vinculo.detalles_prohibicion;
                }

                tablaVinculos.AddCell(new Paragraph(vinculo.ciudadano.apellido.ToString() + " " + vinculo.ciudadano.nombre.ToString(), fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(vinculo.parentesco.parentesco, fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(vinculo.vigente ? "SI" : "NO", fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(prohibicionVinculoAux, fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(prohibicionesIngresoAux, fuenteNormal));

            }

            doc.Add(tablaVinculos);

            doc.Close(); // Cierra el documento pero NO el MemoryStream
            ms.Position = 0;

            return ms;
        }
        //FIN VINCULOS DEL INTERNO
        //----------------------------------------------------------------------------------

        //SABANA DE LA VISITA         
        public static MemoryStream RepPdfCiudadanoSabana(DCiudadanoSabanaResponse ciudadanoSabana)
        {
            MemoryStream ms = new MemoryStream();

            Document doc = new Document(PageSize.A4, 30, 30, 30, 30);

            PdfWriter writer = PdfWriter.GetInstance(doc, ms);
            writer.CloseStream = false; // evita cerrar el MemoryStream al cerrar el documento

            doc.Open();

            var fuenteLogo = FontFactory.GetFont(FontFactory.TIMES, 9, BaseColor.BLACK);
            var fuenteOrganismo = FontFactory.GetFont(FontFactory.TIMES, 10, BaseColor.BLACK);
            var fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.BLACK);
            var fuenteNormal = FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.BLACK);
                        
            string organismo = CurrentUser.Instance.organismo.ToUpper();
            // Crear tabla con 2 columnas
            PdfPTable tablaEncabezado = new PdfPTable(1);
            tablaEncabezado.WidthPercentage = 35; // ocupa la mitad de la página
            tablaEncabezado.HorizontalAlignment = Element.ALIGN_LEFT; // tabla a la izquierda

            // Centrar contenido de todas las celdas
            tablaEncabezado.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            tablaEncabezado.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            tablaEncabezado.DefaultCell.Border = Rectangle.NO_BORDER;

            // Agregar celdas
            tablaEncabezado.AddCell(new Paragraph("  SERVICIO PENITENCIARIO DE LA PROVINCIA DE SALTA", fuenteLogo));
            tablaEncabezado.AddCell(new Paragraph(organismo, fuenteOrganismo));

            // Agregar tabla al documento
            doc.Add(tablaEncabezado);
            //fin logo encabezado.....................................

            //fecha
            DateTime fechaHoy = DateTime.Now;
            CultureInfo cultura = new CultureInfo("es-ES");

            // "d 'de' MMMM 'de' yyyy" → ejemplo: "9 de septiembre de 2025"
            string fechaCompleta = "Salta, " + fechaHoy.ToString("d 'de' MMMM 'de' yyyy", cultura);

            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(fechaCompleta, fuenteNormal)
            {
                Alignment = Element.ALIGN_RIGHT
            });
            //fin fecha.............................

            //doc.Add(new Paragraph(" "));

            //CARGAR DATOS RECIBIDOS
            List<DEntradaSalidaSabanaCiudadano> listaSabana = ciudadanoSabana.listaEntradasResponse;

            //datos ciudadano
            doc.Add(new Paragraph(" Apellido y nombre: " + ciudadanoSabana.nombre_visita, fuenteTitulo));
            doc.Add(new Paragraph(" DNI: " + ciudadanoSabana.dni, fuenteTitulo));
            //fin datos ciudadano

            Paragraph titulo = new Paragraph("Sabana de la VISITA", fuenteTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.SpacingAfter = 8;
            doc.Add(titulo);

            //doc.Add(new Paragraph(" "));

            PdfPTable tablaVinculos = new PdfPTable(6);
            tablaVinculos.WidthPercentage = 100;
            tablaVinculos.SetWidths(new float[] {0.8f, 2.0f, 0.9f, 0.7f, 2.0f, 1.5f});
            tablaVinculos.AddCell(new Paragraph("Fecha", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Interno", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Parentesco", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Entrada", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Menores", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Unidad", fuenteTitulo));

            // Filas dinámicas
            foreach (var entrada in listaSabana)
            {
                tablaVinculos.AddCell(new Paragraph(entrada.fecha_registro.ToString("dd/MM/yyyy") ?? "", fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(entrada.nombre_interno, fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(entrada.parentesco, fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(entrada.hora_registro, fuenteNormal));                
                tablaVinculos.AddCell(new Paragraph(entrada.menores, fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(entrada.organismo, fuenteNormal));

            }

            doc.Add(tablaVinculos);

            doc.Close(); // Cierra el documento pero NO el MemoryStream
            ms.Position = 0;

            return ms;
        }
        //FIN SABANA DE LA VISITA
        //----------------------------------------------------------------------------------

        //SABANA DE LA VISITA         
        public static MemoryStream RepPdfInternoSabana(DInternoSabanaResponse internoSabanaResponse)
        {
            MemoryStream ms = new MemoryStream();

            Document doc = new Document(PageSize.A4, 30, 30, 30, 30);

            PdfWriter writer = PdfWriter.GetInstance(doc, ms);
            writer.CloseStream = false; // evita cerrar el MemoryStream al cerrar el documento

            doc.Open();

            var fuenteLogo = FontFactory.GetFont(FontFactory.TIMES, 9, BaseColor.BLACK);
            var fuenteOrganismo = FontFactory.GetFont(FontFactory.TIMES, 10, BaseColor.BLACK);
            var fuenteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.BLACK);
            var fuenteNormal = FontFactory.GetFont(FontFactory.HELVETICA, 9, BaseColor.BLACK);

            
            string organismo = CurrentUser.Instance.organismo.ToUpper();
            // Crear tabla con 2 columnas
            PdfPTable tablaEncabezado = new PdfPTable(1);
            tablaEncabezado.WidthPercentage = 35; // ocupa la mitad de la página
            tablaEncabezado.HorizontalAlignment = Element.ALIGN_LEFT; // tabla a la izquierda

            // Centrar contenido de todas las celdas
            tablaEncabezado.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            tablaEncabezado.DefaultCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            tablaEncabezado.DefaultCell.Border = Rectangle.NO_BORDER;

            // Agregar celdas
            tablaEncabezado.AddCell(new Paragraph("  SERVICIO PENITENCIARIO DE LA PROVINCIA DE SALTA", fuenteLogo));
            tablaEncabezado.AddCell(new Paragraph(organismo, fuenteOrganismo));

            // Agregar tabla al documento
            doc.Add(tablaEncabezado);
            //fin logo encabezado.....................................

            //fecha
            DateTime fechaHoy = DateTime.Now;
            CultureInfo cultura = new CultureInfo("es-ES");

            // "d 'de' MMMM 'de' yyyy" → ejemplo: "9 de septiembre de 2025"
            string fechaCompleta = "Salta, " + fechaHoy.ToString("d 'de' MMMM 'de' yyyy", cultura);

            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(fechaCompleta, fuenteNormal)
            {
                Alignment = Element.ALIGN_RIGHT
            });
            //fin fecha.............................

            //doc.Add(new Paragraph(" "));

            //CARGAR DATOS RECIBIDOS
            List<DEntradaSalidaSabanaInterno> listaSabana = internoSabanaResponse.listaEntradasResponse;

            //datos interno
            doc.Add(new Paragraph(" Apellido y nombre del interno: " + internoSabanaResponse.nombre_interno, fuenteTitulo));
            doc.Add(new Paragraph(" Prontuario: " + internoSabanaResponse.prontuario, fuenteTitulo));
            //fin datos interno

            Paragraph titulo = new Paragraph("Sabana del INTERNO", fuenteTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.SpacingAfter = 8;
            doc.Add(titulo);

            //doc.Add(new Paragraph(" "));

            PdfPTable tablaVinculos = new PdfPTable(6);
            tablaVinculos.WidthPercentage = 100;
            tablaVinculos.SetWidths(new float[] { 0.8f, 2.0f, 0.9f, 0.7f, 2.0f, 1.5f });
            tablaVinculos.AddCell(new Paragraph("Fecha", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Visita", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Parentesco", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Entrada", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Menores", fuenteTitulo));
            tablaVinculos.AddCell(new Paragraph("Unidad", fuenteTitulo));

            // Filas dinámicas
            foreach (var entrada in listaSabana)
            {
                tablaVinculos.AddCell(new Paragraph(entrada.fecha_registro.ToString("dd/MM/yyyy") ?? "", fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(entrada.nombre_visita, fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(entrada.parentesco, fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(entrada.hora_registro, fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(entrada.menores, fuenteNormal));
                tablaVinculos.AddCell(new Paragraph(entrada.organismo, fuenteNormal));

            }

            doc.Add(tablaVinculos);

            doc.Close(); // Cierra el documento pero NO el MemoryStream
            ms.Position = 0;

            return ms;
        }
        //FIN SABANA DE LA VISITA
        //----------------------------------------------------------------------------------
    }
}
