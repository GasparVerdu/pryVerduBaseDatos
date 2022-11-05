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
    public partial class frmConsultaEntrenadores : Form
    {
        OleDbConnection coneccionBaseDatos = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
        OleDbCommand comandoBD = new OleDbCommand();
        //Como su nombre indica, Reader
        OleDbDataReader LectorBD;

        //var para tener la ruta mas rapido
        string RutaBDDeporte = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb";
        public frmConsultaEntrenadores()
        {
            InitializeComponent();
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            try
            {
                //limpiar grilla
                dgvEntrenadores.Rows.Clear();
                //conecta y mientras el lector lee datos que los ponga en la grilla con lo que asigna el ExecuteReader al lector.
                coneccionBaseDatos = new OleDbConnection(RutaBDDeporte);
                coneccionBaseDatos.Open();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = coneccionBaseDatos;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = "ENTRENADORES";

                LectorBD = comandoBD.ExecuteReader();

                while (LectorBD.Read())
                {
                    dgvEntrenadores.Rows.Add(LectorBD["CODIGO DEPORTISTA"].ToString(), LectorBD["NOMBRE"], LectorBD["APELLIDO"], LectorBD["DIRECCION"], LectorBD["PROVINCIA"], LectorBD["DEPORTE"]);
                }
            }
            catch (Exception mensajito)
            {

                MessageBox.Show(mensajito.Message);
                //throw;
            }
            coneccionBaseDatos.Close();
        }

        private void frmConsultaEntrenadores_Load(object sender, EventArgs e)
        {
            //conectar la base de datos 
            try
            {
                coneccionBaseDatos = new OleDbConnection(RutaBDDeporte);
                coneccionBaseDatos.Open();
                EstadoConeccionEntrCons.BackColor = Color.Green;
                ConsultaEntrenadoresTool.Text = "Conectado correctamente" + " " + DateTime.Now;
            }
            catch (Exception mensajito)
            {
                EstadoConeccionEntrCons.Text = mensajito.Message;
                ConsultaEntrenadoresTool.BackColor = Color.Red;
                //throw;
            }
            coneccionBaseDatos.Close();
        }
    }
}
