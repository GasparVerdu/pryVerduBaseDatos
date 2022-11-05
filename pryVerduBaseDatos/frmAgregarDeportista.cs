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
    public partial class frmAgregarDeportista : Form
    {
        OleDbConnection coneccionBaseDatos = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
        OleDbCommand comandoBD = new OleDbCommand();
        
        public frmAgregarDeportista()
        {
            InitializeComponent();
        }

        private void frmDeportistas_Load(object sender, EventArgs e)
        {
            //conectar la base de datos 
            try
            {
                coneccionBaseDatos = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DEPORTE.accdb");
                coneccionBaseDatos.Open();
                StripConeccionDep.BackColor = Color.Green;
                ConeccionDeportistasTool.Text = "Conectado correctamente" + " " + DateTime.Now;
            }
            catch (Exception mensajito)
            {
                ConeccionDeportistasTool.Text = mensajito.Message;
                StripConeccionDep.BackColor = Color.Red;
                //throw;
            }
            coneccionBaseDatos.Close();
        }

        private void btnAgregarDeportista_Click(object sender, EventArgs e)
        {
            //abre la base de datoss y carga los datos nuevos
            try
            {
                coneccionBaseDatos.Open();
                comandoBD.Connection = coneccionBaseDatos;

                comandoBD.CommandText = "INSERT INTO DEPORTISTA ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [TELEFONO], [EDAD], [DEPORTE])" +
                    "VALUES ( '" + txtCodigoDeportista.Text + "','" + txtNombreDeportista.Text + "','" + txtApellidoDeportista.Text + "','" +
                    txtDireccionDeportista.Text + "','" + mskTelefonoDeportista.Text + "','" + nudEdadDeportista.Value + "','" + cboDeporteDeportista.Text + "')";
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
