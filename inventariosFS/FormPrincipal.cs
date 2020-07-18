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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            
        }

      

        private void button_home_Click(object sender, EventArgs e)
        {
            ClassAnimador.animar(_panel_Menu, ClassAnimador.Effect.Slide, 150, 360); 
        }

        private void button_regresar_sub_menu_Click(object sender, EventArgs e)
        {
            ClassAnimador.animar(_panel_Menu, ClassAnimador.Effect.Slide, 150, 360);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ClassAnimador.activarAnimacion(_panel_Menu);
        }
        private void buttonConsultaInventario_Click(object sender, EventArgs e)
        {
            //Se manda el query con la consulta para que la información sea vaciada en la siguiente vista.
            //Se tiene que visualizar toda la información
            string query = "SELECT a.modelo as Modelo " +
                ", a.costo as Costo " +
                ", a.precio as Precio " + 
                ", b.nombre as Marca " +
                ", c.nombre as Proveedor " +
                ", a.fecha_de_registro as Registro " +
                ", d.cantidad " +
                ", d.comentarios " +
                ", d.piezas " +
                "FROM lu_productos a " +
                "LEFT JOIN lu_marcas b ON b.id_marca = a.id_marca " +
                "LEFT JOIN lu_proveedores c ON c.id_proveedor = a.id_proveeddor " +
                "LEFT JOIN ft_entradas d ON d.id_producto = a.id_producto;";

            //Se abre la ventana para mostrar el inventario completo. 
            FormVerInventario ventanaInventario = new FormVerInventario(query);
            ventanaInventario.ShowDialog();

        }
        private void buttonConsultarEntradas_Click(object sender, EventArgs e)
        {

        }

        private void buttonConsultarSalidas_Click(object sender, EventArgs e)
        {

        }

        private void buttonPanelAdministrativo_Click(object sender, EventArgs e)
        {
            FormPanelAdmin ventanaPanelAdmin = new FormPanelAdmin();
            ventanaPanelAdmin.ShowDialog();
        }
    }
}
