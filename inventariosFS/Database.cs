using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inventariosFS
{
    class Database
    {
        public static string tipoUsuario = "";
        static string[] stringConexion = System.IO.File.ReadAllLines(@"" + System.Windows.Forms.Application.StartupPath + "\\conexion.txt");
        public static MySqlConnection _conn = new MySqlConnection(stringConexion[0]);
        public static DataTable tablaEquipos;
        public static string connectionStringTablaInsercion;
        public static OleDbConnection __connExcel;
        public static MySqlDataAdapter adapt;
        public static DataTable tablaBusqueda;
        public static string userType;

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


        /*
        public static void verPDF(string path)
        {
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
            }
        }*/
        public static void killExcelProcesses()
        {
            System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("Excel");
            foreach (System.Diagnostics.Process p in process)
            {
                if (!string.IsNullOrEmpty(p.ProcessName))
                {
                    try
                    {
                        p.Kill();
                    }
                    catch { }
                }
            }
        }

        public static string[] FixEscapeCharacters(params string[] parameters)
        {
            string[] newParameters = new string[parameters.Length];
            int index = 0;
            foreach (var param in parameters)
            {
                if (param.Contains("'"))
                    newParameters[index] = param.Replace("'", "''");
                else if (param.Contains("\""))
                    newParameters[index] = param.Replace("\"", "\"\"");
                else if (param.Contains("["))
                    newParameters[index] = param.Replace("[", "[[]");
                else
                    newParameters[index] = param;
                index++;
            }
            return newParameters;
        }

        public static DataTable runSelectQuery(string query)
        {
            query = query.Replace("\n", "");
            query = query.Replace("'", "\'");

            Console.WriteLine(query);
            DataTable tablaSelect = new DataTable();
            string sql = query;

            try
            {

                var comm = new MySqlCommand(sql, Database._conn);
                Database._conn.Open();
                Database.adapt = new MySqlDataAdapter(comm);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(Database.adapt);
                Database.tablaBusqueda = new DataTable();
                Database.adapt.Fill(tablaSelect);
                Database._conn.Close();

                if (tablaSelect == null)
                {

                    return null;
                }
                else if (tablaSelect.Rows.Count < 1)
                {
                    return null;
                }

                return tablaSelect;

            }
            catch (Exception e)
            {
                Database.ManageException(e);
                Console.WriteLine(sql);
                return null;

            }
        }

        public static long runInsert(string query)
        {
            query = query.Replace("\n", "");
            query = query.Replace("'", "\'");

            var comm = new MySqlCommand(query, Database._conn);
            try
            {
                Database._conn.Open();
                Console.WriteLine(query);
                comm.ExecuteNonQuery();
                Database._conn.Close();
                return comm.LastInsertedId;
            }
            catch (Exception e)
            {
                Database.ManageException(e);
                return -1;
            }

        }
        public static bool runQuery(string query)
        {
            query = query.Replace("\n", "");
            query = query.Replace("'", "\'");
            var comm = new MySqlCommand(query, Database._conn);
            try
            {
                Database._conn.Open();
                Console.WriteLine(query);
                comm.ExecuteNonQuery();
                Database._conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Database.ManageException(e);
                return false;
            }

        }
        public static void getTablaEquipos()
        {
            Database.tablaEquipos = new DataTable();
            string sql = string.Format("SELECT * from tEquipo WHERE  estado=1 ");




            try
            {

                var comm = new MySqlCommand(sql, Database._conn);
                Database._conn.Open();
                Database.adapt = new MySqlDataAdapter(comm);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(Database.adapt);
                Database.tablaBusqueda = new DataTable();
                Database.adapt.Fill(Database.tablaEquipos);
                Database._conn.Close();

            }
            catch (Exception e)
            {
                Database.ManageException(e);

            }
        }

        public static void ManageException(Exception e)
        {
            if (_conn.State == System.Data.ConnectionState.Open)
                _conn.Close();
            MessageBox.Show(e.ToString());
            MessageBox.Show("Es posible que su conexión de red no este funcionando o que el servidor no este respondiendo en estos momentos");
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




    }
}