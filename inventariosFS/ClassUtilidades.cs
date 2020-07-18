using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace inventariosFS
{
    class ClassUtilidades
    {
        public static void autosizeGrid(DataGridView dataGrid)
        {
            dataGrid.ForeColor = Color.Black;

            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.AllowUserToResizeColumns = true;

            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGrid.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGrid.AllowUserToAddRows = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.ReadOnly = true;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;


        }

        public static void autosizeGrid(DataGridView dataGrid, int tamaño)
        {
            dataGrid.ForeColor = Color.Black;

            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.AllowUserToResizeColumns = true;

            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGrid.DefaultCellStyle.Font = new Font("Segoe UI", tamaño);
            dataGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", tamaño, FontStyle.Bold);
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", tamaño, FontStyle.Bold);
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGrid.AllowUserToAddRows = false;
            dataGrid.RowHeadersVisible = false;
            dataGrid.ReadOnly = true;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;


        }



        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        internal static void matarProcesoDeExcel(Microsoft.Office.Interop.Excel.Application xlApp)
        {
            uint processId = 0;
            GetWindowThreadProcessId(new IntPtr(xlApp.Hwnd), out processId);
            try
            {
                if (processId != 0)
                {
                    Process excelProcess = Process.GetProcessById((int)processId);
                    excelProcess.CloseMainWindow();
                    excelProcess.Refresh();
                    excelProcess.Kill();
                }
            }
            catch
            {
                // Process was already killed
            }

        }


        internal static void colorearModificados(DataGridView dataGrid)
        {
            for (int x = 0; x < dataGrid.Rows.Count; x++)
            {
                if (dataGrid.Rows[x].Cells["modificado"].Value == null)
                    continue;

                if ((dataGrid.Rows[x].Cells["modificado"].Value.ToString() == "1"))
                    dataGrid.Rows[x].DefaultCellStyle.BackColor = Color.Yellow;

            }
        }

        public static void verPDF(string path)
        {
            /*
            try
            {
                FormVistaPrevia vistaPrevia = new FormVistaPrevia();
                vistaPrevia.Navegar(path);
                vistaPrevia.Show();
                vistaPrevia.TopMost = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo leer el manual de usuario. \n" + ex.ToString());
            }*/
        }

        public static void CopyDataTableToClipboard(DataTable DT)
        {
            if (DT == null)
            {
                Clipboard.SetText(" ");
                return;
            }
            if ((DT.Rows.Count == 0))
            {
                Clipboard.SetText(" ");
                return;
            }
            StringBuilder Output = new StringBuilder();

            //The first "line" will be the Headers.
            /*
            for (int i = 0; i < DT.Columns.Count; i++)
            {
                Output.Append(DT.Columns[i].ColumnName + "\t");
            }

            Output.Append("\n");
            */
            //Generate Cell Value Data
            foreach (DataRow Row in DT.Rows)
            {
                for (int i = 0; i < Row.ItemArray.Length; i++)
                {
                    //Handling the last cell of the line.
                    if (i == (Row.ItemArray.Length - 1))
                    {

                        Output.Append(Row.ItemArray[i].ToString() + "\n");
                    }
                    else
                    {

                        Output.Append(Row.ItemArray[i].ToString() + "\t");
                    }
                }
            }

            Clipboard.SetText(Output.ToString());
        }

        internal static void exportarDataTableToExcel(DataTable tabla, string encabezado)
        {
            try
            {

                int columnas = tabla.Columns.Count;
                if (tabla == null)
                {
                    MessageBox.Show("No se encontró información en la tabla para exportación. Contacta a Aseguramiento de calidad.");
                    return;
                }


                ClassUtilidades.CopyDataTableToClipboard(tabla, true);
                //Creamos una nueva aplicación de excel. 
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                //Abrimos la plantilla de reportes y creamos un nuevo workbook para mostrar ahí el reporte.
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();
                //Obtenemos todas las hojas de la plantilla 
                Microsoft.Office.Interop.Excel.Sheets sheets = xlWorkBook.Worksheets;

                //Obtenemos la primera hoja de la plantilla 
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = xlApp.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;



                int inicio_y_tabla = 4;
                int inicio_x_tabla = 2;

                //Colocamos la fecha de eleboración del reporte. 
                xlWorkSheet.Cells[1, inicio_x_tabla + columnas - 1] = "'" + DateTime.Now.ToString("dd/MM/yyyy");
                xlWorkSheet.Cells[1, inicio_x_tabla + columnas - 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

                //Combinamos la celda del encabezado. 				
                xlWorkSheet.Range[xlWorkSheet.Cells[2, inicio_x_tabla], xlWorkSheet.Cells[2, columnas + inicio_x_tabla - 1]].Merge();
                xlWorkSheet.Range[xlWorkSheet.Cells[2, inicio_x_tabla], xlWorkSheet.Cells[2, columnas + inicio_x_tabla - 1]].Font.size = 15;
                xlWorkSheet.Range[xlWorkSheet.Cells[2, inicio_x_tabla], xlWorkSheet.Cells[2, columnas + inicio_x_tabla - 1]].Font.bold = true;
                xlWorkSheet.Range[xlWorkSheet.Cells[2, inicio_x_tabla], xlWorkSheet.Cells[2, columnas + inicio_x_tabla - 1]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Cells[2, inicio_x_tabla] = encabezado;

                //Pegamos nuestra tabla para la generación del reporte. 
                Microsoft.Office.Interop.Excel.Range CR = xlWorkSheet.Cells[inicio_y_tabla, inicio_x_tabla] as Microsoft.Office.Interop.Excel.Range;
                CR.Select();
                xlWorkSheet.Paste();

                //Colocamos los bordes de las celdas 
                xlWorkSheet.Range[xlWorkSheet.Cells[inicio_y_tabla, inicio_x_tabla], xlWorkSheet.Cells[tabla.Rows.Count + inicio_y_tabla, columnas + inicio_x_tabla - 1]].borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                xlWorkSheet.Range[xlWorkSheet.Cells[inicio_y_tabla, inicio_x_tabla], xlWorkSheet.Cells[tabla.Rows.Count + inicio_y_tabla, columnas + inicio_x_tabla - 1]].borders.Weight = 2d;

                //Se ponen todas las columnas del mismo ancho. 
                xlWorkSheet.Range[xlWorkSheet.Cells[inicio_y_tabla, 1], xlWorkSheet.Cells[tabla.Rows.Count + inicio_y_tabla, columnas + inicio_x_tabla]].ColumnWidth = 25;

                //Coloreamos los encabezados de las celdas. 
                xlWorkSheet.Range[xlWorkSheet.Cells[inicio_y_tabla, inicio_x_tabla], xlWorkSheet.Cells[inicio_y_tabla, columnas + inicio_x_tabla - 1]].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue);
                xlWorkSheet.Range[xlWorkSheet.Cells[inicio_y_tabla, inicio_x_tabla], xlWorkSheet.Cells[inicio_y_tabla, columnas + inicio_x_tabla - 1]].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White);


                string letra = obtenerLetraDeRango(columnas + inicio_x_tabla);
                //Establecemos los márgenes para la impresión y hacemos autoFit


                xlWorkSheet.PageSetup.PrintArea = "";
                xlWorkSheet.PageSetup.PrintArea = string.Format("A1:{0}{1}", letra, tabla.Rows.Count + inicio_y_tabla);
                Microsoft.Office.Interop.Excel.Range aRange = xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[tabla.Rows.Count + inicio_y_tabla, columnas + inicio_x_tabla]];
                aRange.Rows.AutoFit();

                string rutaPDF = System.Windows.Forms.Application.StartupPath + "\\ultimoReporte.pdf";
                //MessageBox.Show("Guardado en " + rutaPDF); 
                xlWorkSheet.ExportAsFixedFormat(
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
                xlApp.DisplayAlerts = true;
                //xlWorkBook.WindowDeactivate += cerrarExcel;
            }
            catch (Exception e)
            {
                ClassUtilidades.mostrarMensajeValidacion(e.Message.ToString());

            }
        }

        public static void copyDataGridViewToClipboard(DataGridView dataGridView)
        {
            dataGridView.SelectAll();
            dataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            DataObject dataObj = dataGridView.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        internal static void CopyDataTableToClipboard(DataTable DT, bool headerCopied = false)
        {
            if (DT == null)
            {
                Clipboard.SetText(" ");
                return;
            }
            if ((DT.Rows.Count == 0))
            {
                Clipboard.SetText(" ");
                return;
            }
            StringBuilder Output = new StringBuilder();

            //The first "line" will be the Headers.
            if (headerCopied)
            {
                for (int i = 0; i < DT.Columns.Count; i++)
                {
                    Output.Append(DT.Columns[i].ColumnName + "\t");
                }
            }

            Output.Append("\n");

            //Generate Cell Value Data
            foreach (DataRow Row in DT.Rows)
            {
                for (int i = 0; i < Row.ItemArray.Length; i++)
                {
                    //Handling the last cell of the line.
                    if (i == (Row.ItemArray.Length - 1))
                    {

                        Output.Append(Row.ItemArray[i].ToString().Replace("\n", " ") + "\n");
                    }
                    else
                    {
                        if (i == 0)
                            Output.Append("'" + Row.ItemArray[i].ToString().Replace("\n", " ") + "\t");
                        else
                            Output.Append(Row.ItemArray[i].ToString().Replace("\n", " ") + "\t");
                    }
                }
            }

            Clipboard.SetText(Output.ToString());
        }

        private static string obtenerLetraDeRango(int numero)
        {
            int A = 65 - 1;

            int letra = A + numero;
            return Encoding.ASCII.GetString(new byte[] { byte.Parse(letra.ToString()) });



        }

        public static void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje,
            "Aviso",
            MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk,
            MessageBoxDefaultButton.Button1);
        }

        public static void mostrarMensajeValidacion(string mensaje)
        {
            MessageBox.Show(mensaje,
            "Aviso",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error,
            MessageBoxDefaultButton.Button1);
        }
    }
}
