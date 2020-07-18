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
    public partial class FormRegistrarSalida : Form
    {
        private string p;

        public FormRegistrarSalida()
        {
            InitializeComponent();
        }

        public FormRegistrarSalida(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
    }
}
