using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace inventariosFS
{
    class classGeneradorDeReportes
    {
        private static void getpaths()
        {
            string[] lines = new string[0];
            try
            {
                lines = System.IO.File.ReadAllLines(@"" + System.Windows.Forms.Application.StartupPath + "\\paths.txt");
                pathPlantillaInventarios = lines[0];

            }
            catch
            {
                MessageBox.Show("No se pudo leer la configuración. Verificar el archivo de paths.");
                System.Environment.Exit(1);
            }

        }

        internal static void exportarInventarioCompleto()
        {
            if ((classGeneradorDeReportes.pathPlantillaInventarios == "") || classGeneradorDeReportes.pathPlantillaInventarios == null)
            {
                classGeneradorDeReportes.getpaths();
            }

            //Creamos un objeto misvalue para facilitar las configuraciones. 
            object misValue = System.Reflection.Missing.Value;
            //Creamos nuestro DataTable 
            DataTable tablaParaExportacion = new DataTable();

            string selectInventario = "select  " +
            "a.clave " +
            ", a.cliente " +
            ", a.material " +
            ", a.calibre " +
            ", a.color " +
            ", a.corte " +
            ", a.orientacion " +
            ", a.perfil " +
            ", a.frecuencia " +
            ", a.amplitud " +
            ", a.lubricante " +
            ", a.mazos " +
            ", a.kilos " +
            ", DATE_FORMAT(a.fechaDeFabricacion, '%d/%m/%Y') as fechaDeFabricacion " +
            ", a.lote " +
            ", a.fila " +
            ", b.nombre " +
            ", DATE_FORMAT(a.fecha_de_registro, '%d/%m/%Y') as fecha_de_registro " +
            ", DATE_FORMAT(a.fecha_de_modificacion, '%d/%m/%Y') as fecha_de_modificacion" +
            ", DATE_FORMAT(a.fecha_de_recepcion_de_material, '%d/%m/%Y') as fecha_de_recepcion_de_material " +
            ", a.diametro_mazo " +
            ", c.nombre as presentacion " +
            ", a.comentarios as Comentarios " +
            ", a.pedidopmm as Pedido " +
            "from lu_productos a " +
            "left join lu_almacenes b on a.id_almacen=b.id_almacen " +
            "left join cf_presentaciones c on a.id_presentacion = c.id_presentacion " +
            "where a.mazos<>0;  ";
            //"inner join lu_almacenes b on a.id_almacen=b.id_almacen where a.mazos<>0;  ";


            tablaParaExportacion = Database.runSelectQuery(selectInventario);

            //En caso de devolver una tabla nula, debemos construirla de nuevo para evitar errores. 
            if (tablaParaExportacion == null)
            {
                tablaParaExportacion = new DataTable();

            }

            //Creamos una nueva aplicación de excel. 
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();


            //Abrimos la plantilla de reportes y creamos un nuevo workbook para mostrar ahí el reporte. 
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(classGeneradorDeReportes.pathPlantillaInventarios);
            Microsoft.Office.Interop.Excel.Workbook workbookExportacion;
            //Obtenemos todas las hojas de la plantilla 
            Microsoft.Office.Interop.Excel.Sheets sheets = xlWorkBook.Worksheets;

            //Obtenemos la primera hoja de la plantilla 
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

            //Se copia la hoja actual y se coloca automáticamente en un nuevo workbook. 
            xlWorkSheet.Copy(Type.Missing, Type.Missing);

            //Cerramos la plantilla original de excel. 
            xlApp.DisplayAlerts = false;
            xlWorkBook.Save();
            xlWorkBook.Close(0);


            //Comenzamos a trabajar con el workbook de exportación 

            //Asignamos un identificador para nuestro workbook 
            workbookExportacion = xlApp.ActiveWorkbook;
            Microsoft.Office.Interop.Excel.Sheets sheetsExportacion = workbookExportacion.Worksheets;
            Microsoft.Office.Interop.Excel.Worksheet sheetExportacion = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

            //Primeras 10 columnas de la tabla
            //Copiamos la tabla de exportación al portaPapeles            
            ClassUtilidades.CopyDataTableToClipboard(tablaParaExportacion);
            Microsoft.Office.Interop.Excel.Range CR = sheetExportacion.Cells[2, 1] as Microsoft.Office.Interop.Excel.Range;
            CR.Select();
            //string textos = Clipboard.GetText(); 
            sheetExportacion.Paste(CR);

            Microsoft.Office.Interop.Excel.Range formatRange = sheetExportacion.get_Range("L1", "M1");
            formatRange.EntireColumn.NumberFormat = "0.00";

            Microsoft.Office.Interop.Excel.Range formatRange2 = sheetExportacion.get_Range("P1", "P1");
            formatRange2.EntireColumn.NumberFormat = "0";

            Microsoft.Office.Interop.Excel.Range formatRange3 = sheetExportacion.get_Range("N1", "N1");
            formatRange3.EntireColumn.NumberFormat = "dd/mm/yyyy";

            Microsoft.Office.Interop.Excel.Range formatRange4 = sheetExportacion.get_Range("R1", "T1");
            formatRange4.EntireColumn.NumberFormat = "dd/mm/yyyy";

            formatRange.NumberFormat = "dd/mm/yyyy";

            //Iteramos para poner el formato correcto de número en las celdas. 
            for (int x = 0; x < tablaParaExportacion.Rows.Count; x++)
            {
                DateTime fecha = DateTime.Parse(tablaParaExportacion.Rows[x]["fechaDeFabricacion"].ToString());
                sheetExportacion.Cells[1 + (x + 1), 14] = fecha.ToOADate();

                DateTime fecha_de_recepcion = DateTime.Parse(tablaParaExportacion.Rows[x]["fecha_de_recepcion_de_material"].ToString());
                sheetExportacion.Cells[1 + (x + 1), 18] = fecha_de_recepcion.ToOADate();

                DateTime fecha_de_registro = DateTime.Parse(tablaParaExportacion.Rows[x]["fecha_de_registro"].ToString());
                sheetExportacion.Cells[1 + (x + 1), 19] = fecha_de_registro.ToOADate();

                DateTime fecha_de_modificacion = DateTime.Parse(tablaParaExportacion.Rows[x]["fecha_de_modificacion"].ToString());
                sheetExportacion.Cells[1 + (x + 1), 20] = fecha_de_modificacion.ToOADate();

                sheetExportacion.Cells[2 + x, 12] = tablaParaExportacion.Rows[x]["mazos"].ToString();
                sheetExportacion.Cells[2 + x, 13] = tablaParaExportacion.Rows[x]["kilos"].ToString();
                sheetExportacion.Cells[2 + x, 16] = tablaParaExportacion.Rows[x]["fila"].ToString();
            }
            //Últimas columnas de la tabla
            //Copiamos la tabla de exportación al portaPapeles
            /*classDataBaseManager.CopyDataTableToClipboard(tablaParaExportacion2);
            CR = sheetExportacion.Cells[5, 11] as Microsoft.Office.Interop.Excel.Range;
            CR.Select();
            sheetExportacion.Paste(CR, Clipboard.GetText());
            */
            int cantidadRegistros = tablaParaExportacion.Rows.Count;

            int ultimaCelda = (cantidadRegistros) + 4;
            //

            //Establecemos los márgenes para la impresión.             
            sheetExportacion.PageSetup.PrintArea = "A1:M" + ultimaCelda;
            Microsoft.Office.Interop.Excel.Range aRange = sheetExportacion.get_Range("A5", "M" + ultimaCelda);
            aRange.Rows.AutoFit();
            xlApp.DisplayAlerts = false;

            //Colocamos los bordes de las celdas 
            sheetExportacion.Range[sheetExportacion.Cells[5, 1], sheetExportacion.Cells[ultimaCelda + 5, 13]].borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            sheetExportacion.Range[sheetExportacion.Cells[5, 1], sheetExportacion.Cells[ultimaCelda + 5, 13]].borders.Weight = 2d;


            string rutaPDF = System.Windows.Forms.Application.StartupPath + "\\ultimoReporte.pdf";
            //MessageBox.Show("Guardado en " + rutaPDF); 
            sheetExportacion.ExportAsFixedFormat(
            Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF,
            rutaPDF,
            Microsoft.Office.Interop.Excel.XlFixedFormatQuality.xlQualityStandard,
            true,
            false,
            Type.Missing,
            Type.Missing,
            false);



            xlApp.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;
            xlApp.Visible = true;
            //Cerramos el Excel para mostrar solo el PDF. 
            //ClassUtilidades.matarProcesoDeExcel(xlApp);
            //Mostramos el PDF 
            //ClassUtilidades.verPDF(rutaPDF);
        }

        public static string pathPlantillaInventarios { get; set; }

        internal static void exportarBusquedaDeInventario(DataTable temporal)
        {
            if ((classGeneradorDeReportes.pathPlantillaInventarios == "") || classGeneradorDeReportes.pathPlantillaInventarios == null)
            {
                classGeneradorDeReportes.getpaths();
            }

            //Creamos un objeto misvalue para facilitar las configuraciones. 
            object misValue = System.Reflection.Missing.Value;
            //Creamos nuestro DataTable 
            DataTable tablaParaExportacion = temporal;

            //En caso de devolver una tabla nula, debemos construirla de nuevo para evitar errores. 
            if (tablaParaExportacion == null)
            {
                tablaParaExportacion = new DataTable();

            }

            //Creamos una nueva aplicación de excel. 
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();


            //Abrimos la plantilla de reportes y creamos un nuevo workbook para mostrar ahí el reporte. 
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(classGeneradorDeReportes.pathPlantillaInventarios);
            Microsoft.Office.Interop.Excel.Workbook workbookExportacion;
            //Obtenemos todas las hojas de la plantilla 
            Microsoft.Office.Interop.Excel.Sheets sheets = xlWorkBook.Worksheets;

            //Obtenemos la primera hoja de la plantilla 
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

            //Se copia la hoja actual y se coloca automáticamente en un nuevo workbook. 
            xlWorkSheet.Copy(Type.Missing, Type.Missing);

            //Cerramos la plantilla original de excel. 
            xlApp.DisplayAlerts = false;
            xlWorkBook.Save();
            xlWorkBook.Close(0);


            //Comenzamos a trabajar con el workbook de exportación 

            //Asignamos un identificador para nuestro workbook 
            workbookExportacion = xlApp.ActiveWorkbook;
            Microsoft.Office.Interop.Excel.Sheets sheetsExportacion = workbookExportacion.Worksheets;
            Microsoft.Office.Interop.Excel.Worksheet sheetExportacion = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

            //Primeras 10 columnas de la tabla
            //Copiamos la tabla de exportación al portaPapeles            
            ClassUtilidades.CopyDataTableToClipboard(tablaParaExportacion);
            Microsoft.Office.Interop.Excel.Range CR = sheetExportacion.Cells[2, 1] as Microsoft.Office.Interop.Excel.Range;
            CR.Select();
            //string textos = Clipboard.GetText(); 
            sheetExportacion.Paste(CR);

            //Últimas columnas de la tabla
            //Copiamos la tabla de exportación al portaPapeles
            /*classDataBaseManager.CopyDataTableToClipboard(tablaParaExportacion2);
            CR = sheetExportacion.Cells[5, 11] as Microsoft.Office.Interop.Excel.Range;
            CR.Select();
            sheetExportacion.Paste(CR, Clipboard.GetText());
            */

            Microsoft.Office.Interop.Excel.Range formatRange = sheetExportacion.get_Range("L1", "M1");
            formatRange.EntireColumn.NumberFormat = "0.00";

            Microsoft.Office.Interop.Excel.Range formatRange2 = sheetExportacion.get_Range("P1", "P1");
            formatRange2.EntireColumn.NumberFormat = "0";

            Microsoft.Office.Interop.Excel.Range formatRange3 = sheetExportacion.get_Range("N1", "N1");
            formatRange3.EntireColumn.NumberFormat = "mm/dd/yyyy";

            Microsoft.Office.Interop.Excel.Range formatRange4 = sheetExportacion.get_Range("R1", "T1");
            formatRange4.EntireColumn.NumberFormat = "mm/dd/yyyy";

            int cantidadRegistros = tablaParaExportacion.Rows.Count;
            //Copiamos nuevamente las fechas en el formato indicado
            for (int x = 0; x < tablaParaExportacion.Rows.Count; x++)
            {

                DateTime fecha = DateTime.Parse(tablaParaExportacion.Rows[x]["fechaDeFabricacion"].ToString());
                sheetExportacion.Cells[1 + (x + 1), 14] = fecha.ToOADate();

                DateTime fecha_de_recepcion = DateTime.Parse(tablaParaExportacion.Rows[x]["fecha_de_recepcion_de_material"].ToString());
                sheetExportacion.Cells[1 + (x + 1), 18] = fecha_de_recepcion.ToOADate();

                DateTime fecha_de_registro = DateTime.Parse(tablaParaExportacion.Rows[x]["fecha_de_registro"].ToString());
                sheetExportacion.Cells[1 + (x + 1), 19] = fecha_de_registro.ToOADate();

                DateTime fecha_de_modificacion = DateTime.Parse(tablaParaExportacion.Rows[x]["fecha_de_modificacion"].ToString());
                sheetExportacion.Cells[1 + (x + 1), 20] = fecha_de_modificacion.ToOADate();

                sheetExportacion.Cells[2 + x, 12] = tablaParaExportacion.Rows[x]["mazos"].ToString();
                sheetExportacion.Cells[2 + x, 13] = tablaParaExportacion.Rows[x]["kilos"].ToString();
                sheetExportacion.Cells[2 + x, 16] = tablaParaExportacion.Rows[x]["fila"].ToString();

            }



            int ultimaCelda = (cantidadRegistros) + 4;
            //

            //Establecemos los márgenes para la impresión.             
            sheetExportacion.PageSetup.PrintArea = "A1:M" + ultimaCelda;
            Microsoft.Office.Interop.Excel.Range aRange = sheetExportacion.get_Range("A5", "M" + ultimaCelda);
            aRange.Rows.AutoFit();
            xlApp.DisplayAlerts = false;

            //Colocamos los bordes de las celdas 
            sheetExportacion.Range[sheetExportacion.Cells[5, 1], sheetExportacion.Cells[ultimaCelda + 5, 13]].borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            sheetExportacion.Range[sheetExportacion.Cells[5, 1], sheetExportacion.Cells[ultimaCelda + 5, 13]].borders.Weight = 2d;


            string rutaPDF = System.Windows.Forms.Application.StartupPath + "\\ultimoReporte.pdf";
            //MessageBox.Show("Guardado en " + rutaPDF); 
            sheetExportacion.ExportAsFixedFormat(
            Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF,
            rutaPDF,
            Microsoft.Office.Interop.Excel.XlFixedFormatQuality.xlQualityStandard,
            true,
            false,
            Type.Missing,
            Type.Missing,
            false);



            xlApp.WindowState = Microsoft.Office.Interop.Excel.XlWindowState.xlMaximized;
            xlApp.Visible = true;
            //Cerramos el Excel para mostrar solo el PDF. 
            //ClassUtilidades.matarProcesoDeExcel(xlApp);
            //Mostramos el PDF 
            //ClassUtilidades.verPDF(rutaPDF);
        }
    }

}






