using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryVerduBaseDatos
{
       
    public partial class frmAgregarEntrenador : Form
    {
        OleDbConnection coneccionBaseDatos = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
        OleDbCommand comandoBD = new OleDbCommand();
        public frmAgregarEntrenador()
        {
            InitializeComponent();
        }

        private void frmAgregarEntrenador_Load(object sender, EventArgs e)
        {
            //conectar la base de datos 
            try
            {
                coneccionBaseDatos = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DEPORTE.accdb");
                coneccionBaseDatos.Open();
                EstadoConeccionEntrenador.BackColor = Color.Green;
                ConeccionEntrenadorTool.Text = "Conectado correctamente" + " " + DateTime.Now;
            }
            catch (Exception mensajito)
            {
                ConeccionEntrenadorTool.Text = mensajito.Message;
                EstadoConeccionEntrenador.BackColor = Color.Red;
                //throw;
            }
            coneccionBaseDatos.Close();
        }

        private void btnAgregarEntrenador_Click(object sender, EventArgs e)
        {
            //abre la base de datoss y carga los datos nuevos
            try
            {
                coneccionBaseDatos.Open();
                comandoBD.Connection = coneccionBaseDatos;

                comandoBD.CommandText = "INSERT INTO ENTRENADORES ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [PROVINCIA], [DEPORTE])" +
                    "VALUES ( '" + txtCodigoEntrenador.Text + "','" + txtNombreEntrenador.Text + "','" + txtApellidoEntrenador.Text + "','" +
                    txtDireccionEntrenador.Text + "','" + txtProvinciaEntrenador.Text + "','" + cboDeporteEntrenador.Text + "')";
                //executeNonQuery para la sentencia SQL del oledbCommand
                comandoBD.ExecuteNonQuery();
                coneccionBaseDatos.Close();
                MessageBox.Show("Datos cargados");
            }
            catch (Exception mensajito)
            {
                MessageBox.Show(mensajito.Message);
                //throw;
            }
            coneccionBaseDatos.Close();
        }
    }
}
