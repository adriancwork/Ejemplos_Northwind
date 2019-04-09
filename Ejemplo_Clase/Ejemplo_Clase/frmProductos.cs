using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejemplo_Clase
{
    public partial class frmProductos : Form
    {
        SqlConnection cnn;

        public frmProductos(SqlConnection cnx)
        {
            InitializeComponent();
            cnn = cnx;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }


    }
}
