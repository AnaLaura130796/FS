using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventariosFS
{
    public partial class FormVerInventario : Form
    {
        
        public string query = "";
        public BindingSource bindingInicial = new BindingSource();
        public DataTable tablaInicial = new DataTable(); 

      

        public FormVerInventario(string query)
        {
            // TODO: Complete member initialization
            this.query = query;
            InitializeComponent();
            llenarAlmacenes();
            actualizarDataGridView();
            llenarPresentaciones();

        }

        private void actualizarDataGridView()
        {
            DataTable tablaInventario = Database.runSelectQuery(query);
            if (tablaInventario != null)
            {
                dataGridViewInventario.DataSource = tablaInventario;
                ClassUtilidades.autosizeGrid(dataGridViewInventario, 7);
                guardarbindingInicial();
                //Quitamos las columnas de configuración. 
                dataGridViewInventario.Columns[""].Visible = false;
                dataGridViewInventario.Columns[""].Visible = false;
                dataGridViewInventario.Columns["Modelo"].HeaderText = "";
                dataGridViewInventario.Columns["Marca"].HeaderText = "";

            }
        }

        private void guardarbindingInicial()
        {
            DataTable temporal = (DataTable)dataGridViewInventario.DataSource;
            tablaInicial = temporal;
            bindingInicial.DataSource = temporal.Copy();
        }

        private void llenarPresentaciones()
        {
            comboBox_presentacion.Items.Add("Cajas");
            comboBox_presentacion.Items.Add("Mazos");
            comboBox_presentacion.Items.Add("Todos"); 
        }

        private void llenarAlmacenes()
        {
            string selectAlmacenes = "select * from lu_almacenes";
            DataTable tablaTemporal = Database.runSelectQuery(selectAlmacenes);
            comboBox_almacen.DataSource = tablaTemporal;
            comboBox_almacen.ValueMember = "id_almacen";
            comboBox_almacen.DisplayMember = "nombre";
        }

        private void dataGridViewInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            mostrarEntradaSalida();

        }
        private void mostrarEntradaSalida()
        {
            Point newPoint = new Point((this.Width / 2) - (_panelFechas.Width / 2), this.Height / 2 - (_panelFechas.Height / 2));
            _panelFechas.Location = newPoint;
            ClassAnimador.animar(_panelFechas, ClassAnimador.Effect.Roll, 150, 360);
        }

        private void buttonEntrada_Click(object sender, EventArgs e)
        {
            //Ocultamos el menú para elegir entradas y salidas. 
            mostrarEntradaSalida();

            if (dataGridViewInventario.CurrentRow.Index < 0)
            {
                MessageBox.Show("Selecciona un producto del inventario para registrar la salida");
                return;
            }

            int fila = dataGridViewInventario.CurrentRow.Index;

            string idProducto = dataGridViewInventario.Rows[fila].Cells["id_producto"].Value.ToString();
            FormRegistrarEntrada formulario = new FormRegistrarEntrada(string.Format("Select a.*, b.nombre as presentacion from lu_productos a left join cf_presentaciones b on a.id_presentacion = b.id_presentacion where id_producto='{0}'", idProducto));
            formulario.ShowDialog();
            actualizarDataGridView();
           
        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {
            //Ocultamos la ventana
            mostrarEntradaSalida();

            if (dataGridViewInventario.CurrentRow.Index < 0)
            {
                MessageBox.Show("Selecciona un producto del inventario para registrar la salida");
                return;
            }

            int fila = dataGridViewInventario.CurrentRow.Index;

            string idProducto = dataGridViewInventario.Rows[fila].Cells["id_producto"].Value.ToString();
            FormRegistrarSalida formulario = new FormRegistrarSalida(string.Format("Select a.*, b.nombre as presentacion from lu_productos a left join cf_presentaciones b on a.id_presentacion = b.id_presentacion where id_producto='{0}'", idProducto));
            formulario.ShowDialog();
            actualizarDataGridView();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            mostrarEntradaSalida(); 
        }

        private void FormVerInventario_Load(object sender, EventArgs e)
        {
            comboBox_almacen.Text = "";
            comboBox_presentacion.Text = "";
        }

        private void comboBox_almacen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_almacen_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_reporte_inventario_Click(object sender, EventArgs e)
        {
            
           
                this.Cursor = Cursors.WaitCursor;
                classGeneradorDeReportes.exportarInventarioCompleto();
                this.Cursor = Cursors.Default;
            
        }

        private void button_reporte_busqueda_Click(object sender, EventArgs e)
        {
            //Filtramos nuestra tabla inicial con los mismos filtros que el binding. 
            tablaInicial.DefaultView.RowFilter = bindingInicial.Filter;
            //Obtenemos una nueva tabla con los filtros aplicados. 
            DataTable filtered = tablaInicial.DefaultView.ToTable();
            //Removemos la fila de la clave para que no aparezca en la exportación. 
            filtered.Columns.Remove("id_producto");
           
            //remover las filas que tengan valor a 0 para no aparecer en la exportación 
            for (int i = 0; i < filtered.Rows.Count; i++)
            {
                for (int x = 0; x < filtered.Rows.Count; x++)
                {
                    if (filtered.Rows[x]["mazos"].ToString() == "0")
                    {
                        filtered.Rows.Remove(filtered.Rows[x]);
                    }
                }
            }
            this.Cursor = Cursors.WaitCursor;
            classGeneradorDeReportes.exportarBusquedaDeInventario(filtered);
            this.Cursor = Cursors.Default;
        }

        private void button_registrar_producto_Click(object sender, EventArgs e)
        {
            //Registrar producto
            FormRegistrarProducto ventaRegistar = new FormRegistrarProducto();
            ventaRegistar.ShowDialog();

        }

    }
}
