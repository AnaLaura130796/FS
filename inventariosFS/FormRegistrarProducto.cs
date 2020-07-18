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
    public partial class FormRegistrarProducto : Form
    {
        public FormRegistrarProducto()
        {
            InitializeComponent();
            llenarPresentaciones();
            llenarMarcas();
           
        }

   
        private void llenarMarcas()
        {
            string selectMarcas = "select * from lu_marcas";
            DataTable tablaTemporal = Database.runSelectQuery(selectMarcas);
            comboBox_marca.DataSource = tablaTemporal;
            comboBox_marca.ValueMember = "id_almacen";
            comboBox_marca.DisplayMember = "nombre";
        }

        private void llenarPresentaciones()
        {
            string selectPresentaciones = "select * from cf_presentaciones";
            DataTable tablaTemporal = Database.runSelectQuery(selectPresentaciones);
            comboBox_marca.DataSource = tablaTemporal;
            comboBox_marca.ValueMember = "id_presentacion";
            comboBox_marca.DisplayMember = "nombre";
        }

        private void button_registrar_producto_Click(object sender, EventArgs e)
        {
            //Se inserta el registro a la base de datos
            //Se debe poner un action para permitir la actualización de datos.
            string queryInsert = string.Format("INSERT INTO lu_productos " +
                "(id_producto " +
                ",modelo " +
                ",descripcion " +
                ",id_marca " +
                ",id_proveedor " +
                ",costo " +
                ",precio " +
                ",estado " +
                ",fecha_de_registro " +
                ")" +
                "VALUES" + 
                "();" 
                );
        }

        private void comboBox_costo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_costo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_precio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_proveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_marca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_marca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
