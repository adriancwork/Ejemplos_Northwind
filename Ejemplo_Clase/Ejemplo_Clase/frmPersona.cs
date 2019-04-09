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
    public partial class frmPersona : Form
    {
        SqlConnection cnn;

        public frmPersona()
        {
            InitializeComponent();
        }

        private void frmPersona_Load(object sender, EventArgs e)
        {
            string connetionString = null;
            connetionString = "Data Source = lenovo-pc\\sqlserverexpress; Initial Catalog=Northwind; Integrated Security = true";

            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
               // MessageBox.Show("Conexion abierta!");
            }
            catch {
               // MessageBox.Show("No se realizó la conexión");
                this.Close();
            }
        }

        private void frmPersona_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Conexion cerrada!");
            cnn.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            String str;

            String Id = txtbxID.Text;
            String Nombre = txtbxNombre.Text;
            String Sueldo = txtbxSueldo.Text;
            String Fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            /*str = "INSERT INTO Ejemplo (Id, Nombre, Sueldo, Fecha) " + 
                "VALUES (" + Id + ", '" + Nombre + "'," + Sueldo + ", '" + Fecha + "')";*/

            str = "EXECUTE Pro_Inser_Persona_Ejemplo " + Id + "," + "'" + Nombre + "'" + "," + Sueldo + "," + "'" + Fecha + "'";

            SqlCommand myCommand = new SqlCommand(str, cnn);
            try
            {
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Registro insertado");
            }
            catch {
                MessageBox.Show("Hace falta insertar el Id");
            }
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String Id = txtbxID.Text;
            SqlDataReader reader;
            SqlCommand myCommand = new SqlCommand();

            myCommand.CommandType = CommandType.Text;
            //myCommand.CommandText = ("SELECT * FROM Ejemplo WHERE Id = " + Id);
            myCommand.CommandText = "EXECUTE Pro_Cons_Persona_Ejemplo " + Id;

            myCommand.Connection = cnn;
            try
            {
                reader = myCommand.ExecuteReader(); //Incorrect syntax near '='

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtbxNombre.Text = reader["Nombre"].ToString();
                        txtbxSueldo.Text = reader["Sueldo"].ToString();
                        this.dtpFecha.Value = (DateTime)reader["Fecha"];
                    }
                }
                else
                {
                    txtbxNombre.Text = "";
                    txtbxSueldo.Text = "";
                    dtpFecha.Value = DateTime.Now;
                    MessageBox.Show("No existe registro con el Id Indicado");
                }
                reader.Close();
            }
            catch {
                MessageBox.Show("Hace falta insertar un Id");
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            String str;

            try
            {
                str = "DELETE FROM Ejemplo WHERE Id = " + txtbxID.Text;
                SqlCommand myCommand = new SqlCommand(str, cnn);
                myCommand.ExecuteNonQuery();

                txtbxID.Text = "";
                txtbxNombre.Text = "";
                txtbxSueldo.Text = "";
                dtpFecha.Value = DateTime.Now;

                MessageBox.Show("Registro eliminado");
            }
            catch {
                MessageBox.Show("El campo Id esta vacio!");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String str;

            String Id = txtbxID.Text;
            String Nombre = txtbxNombre.Text;
            String Sueldo = txtbxSueldo.Text;
            String Fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            str = "UPDATE Ejemplo SET Nombre = " + "'" + Nombre + "'," + "Sueldo = " + Sueldo + ", " +
                "Fecha = " + "'" + Fecha + ", WHERE Id = " + Id;

            try
            {
                SqlCommand myCommand = new SqlCommand(str, cnn);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado");
            }
            catch {
                MessageBox.Show("El Id no conincide con uno en la base de datos");
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbxID.Text = "";
            txtbxNombre.Text = "";
            txtbxSueldo.Text = "";
            dtpFecha.Value = DateTime.Now;
        }

        private void btnLlamarForma_Click(object sender, EventArgs e)
        {
            frmProductos frmProductos = new frmProductos(cnn);
            frmProductos.Show();
            
        }

        private void frmPersona_Leave(object sender, EventArgs e)
        {
            btnConsultar_Click(null, null);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
