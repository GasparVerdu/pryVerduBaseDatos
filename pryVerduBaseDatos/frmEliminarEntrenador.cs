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
    public partial class frmEliminarEntrenador : Form
    {
        OleDbConnection coneccionBaseDatos = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
        OleDbCommand comandoBD = new OleDbCommand();
        //Como su nombre indica, Reader
        OleDbDataReader LectorBD;

        //var para no escribirlo tantas veces
        string RutaBDDeporte = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb";
        public frmEliminarEntrenador()
        {
            InitializeComponent();
        }

        private void frmElimanarEntrenador_Load(object sender, EventArgs e)
        {
            //desactiva los botones
            btnEliminar.Enabled = false;

            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            txtProvincia.Enabled = false;
            cboDeporte.Enabled = false;

            //conectar la base de datos 
            try
            {
                coneccionBaseDatos = new OleDbConnection(RutaBDDeporte);
                coneccionBaseDatos.Open();
                EstadoConeccionEntrEliminar.BackColor = Color.Green;
                EliminarEntrenadoresTool.Text = "Conectado correctamente" + " " + DateTime.Now;
            }
            catch (Exception mensajito)
            {
                EstadoConeccionEntrEliminar.Text = mensajito.Message;
                EliminarEntrenadoresTool.BackColor = Color.Red;
                //throw;
            }
            coneccionBaseDatos.Close();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (txtCodigoEntrenador.Text != "")
            {
                string Codigo = txtCodigoEntrenador.Text;
                coneccionBaseDatos.Open();
                comandoBD.Connection = coneccionBaseDatos;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = "ENTRENADORES";

                LectorBD = comandoBD.ExecuteReader();

                //buscarlo hasta que deje de ser distinto o hasta que deje de leer 
                while (LectorBD.Read() && LectorBD.GetString(0) != Codigo)
                {

                }
                //el lector va a funcionar como un split
                if (LectorBD.GetString(0) == Codigo)
                {
                    //por lo que en la posicion correspondientes estaran los datos de los diferentes campos
                    txtNombre.Text = LectorBD.GetString(1);
                    txtApellido.Text = LectorBD.GetString(2);
                    txtDireccion.Text = LectorBD.GetString(3);
                    txtProvincia.Text = LectorBD.GetString(4);
                    cboDeporte.Text = LectorBD.GetString(5);
                }
                else
                {
                    MessageBox.Show("No existe el codigo ingresado");
                }
                coneccionBaseDatos.Close();
                btnEliminar.Enabled = true;

                txtApellido.Enabled = true;
                txtNombre.Enabled = true;
                txtDireccion.Enabled = true;
                txtProvincia.Enabled = true;
                cboDeporte.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigoEntrenador.Text;

            if (txtCodigoEntrenador.Text != "")
            {

                Codigo = txtCodigoEntrenador.Text;

                coneccionBaseDatos = new OleDbConnection(RutaBDDeporte);
                coneccionBaseDatos.Open();
                comandoBD.Connection = coneccionBaseDatos;
                //este using crea un nuevo comando 
                using (System.Data.OleDb.OleDbCommand commandUpdate = new System.Data.OleDb.OleDbCommand(
                        "DELETE * FROM ENTRENADORES WHERE [CODIGO ENTRENADOR]=@Codigo", coneccionBaseDatos))
                {
                    //actualiza en los respectivos campos los datos
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@Codigo", Codigo));
                    commandUpdate.ExecuteNonQuery();
                }
                MessageBox.Show("Entrenador eliminado");
            }
            else
            {
                MessageBox.Show("Ingrese un codigo");
            }
        }
    }
}
