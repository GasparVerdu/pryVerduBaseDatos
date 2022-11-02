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
    public partial class frmConsultaDeportistas : Form
    {
        OleDbConnection coneccionBaseDatos = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
        OleDbCommand comandoBD = new OleDbCommand();
        //Como su nombre indica, Reader
        OleDbDataReader LectorBD;

        //var para tener la ruta mas rapido
        string RutaBDDeporte = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb";
        public frmConsultaDeportistas()
        {
            InitializeComponent();
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            try
            {
                //limpiar grilla
                dgvDeportistas.Rows.Clear();
                coneccionBaseDatos = new OleDbConnection(RutaBDDeporte);
                coneccionBaseDatos.Open();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = coneccionBaseDatos;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = "DEPORTISTA";

                LectorBD  = comandoBD.ExecuteReader();

                while (LectorBD.Read())
                {
                    dgvDeportistas.Rows.Add(LectorBD["CODIGO DEPORTISTA"].ToString(), LectorBD["NOMBRE"], LectorBD["APELLIDO"], LectorBD["DIRECCION"], LectorBD["TELEFONO"], LectorBD["EDAD"], LectorBD["DEPORTE"]);
                }
            }
            catch (Exception mensajito)
            {

                MessageBox.Show(mensajito.Message);
                //throw;
            }
            coneccionBaseDatos.Close();
        }

        private void frmConsultaDeportistas_Load(object sender, EventArgs e)
        {
            //conectar la base de datos 
            try
            {
                coneccionBaseDatos = new OleDbConnection(RutaBDDeporte);
                coneccionBaseDatos.Open();
                EstadoConeccionDepCons.BackColor = Color.Green;
                ConsultaDepTool.Text = "Conectado correctamente" + " " + DateTime.Now;
            }
            catch (Exception mensajito)
            {
                EstadoConeccionDepCons.Text = mensajito.Message;
                ConsultaDepTool.BackColor = Color.Red;
                //throw;
            }
            coneccionBaseDatos.Close();
        }
    }
}
