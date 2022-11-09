using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVerduBaseDatos
{
    public partial class frmActualizarEntrenador : Form
    {
        OleDbConnection coneccionBaseDatos = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
        OleDbCommand comandoBD = new OleDbCommand();
        //Como su nombre indica, Reader
        OleDbDataReader LectorBD;

        //var para no escribirlo tantas veces
        string RutaBDDeporte = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb";
        public frmActualizarEntrenador()
        {
            InitializeComponent();
        }

        private void frmActualizarEntrenador_Load(object sender, EventArgs e)
        {
            //conectar la base de datos 
            try
            {
                coneccionBaseDatos = new OleDbConnection(RutaBDDeporte);
                coneccionBaseDatos.Open();
                EstadoConeccionEntrModificar.BackColor = Color.Green;
                ModificarEntrenadoresTool.Text = "Conectado correctamente" + " " + DateTime.Now;
            }
            catch (Exception mensajito)
            {
                EstadoConeccionEntrModificar.Text = mensajito.Message;
                ModificarEntrenadoresTool.BackColor = Color.Red;
                //throw;
            }
            coneccionBaseDatos.Close();

            btnModificar.Enabled = false;

            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            txtProvincia.Enabled = false;
            cboDeporte.Enabled = false;
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
                btnModificar.Enabled = true;

                txtApellido.Enabled = true;
                txtNombre.Enabled = true;
                txtDireccion.Enabled = true;
                txtProvincia.Enabled = true;
                cboDeporte.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            string Codigo, Nombre, Apellido, Direccion, Deporte, Provincia;

            if (txtCodigoEntrenador.Text != "")
            {
                Codigo = txtCodigoEntrenador.Text;
                Nombre = txtNombre.Text;
                Apellido = txtApellido.Text;
                Direccion = txtDireccion.Text;
                Deporte = cboDeporte.Text;

                Provincia = txtProvincia.Text;

                coneccionBaseDatos = new OleDbConnection(RutaBDDeporte);
                coneccionBaseDatos.Open();
                comandoBD.Connection = coneccionBaseDatos;
                using (System.Data.OleDb.OleDbCommand commandUpdate = new System.Data.OleDb.OleDbCommand(
                    "UPDATE ENTRENADORES SET NOMBRE=@NOMBRE, APELLIDO=@APELLIDO, DIRECCION=@DIRECCION," +
                    "PROVINCIA=@PROVINCIA, DEPORTE=@DEPORTE WHERE [CODIGO ENTRENADOR]=@Codigo", coneccionBaseDatos))
                {
                    //actualiza en los respectivos campos los datos
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@NOMBRE", Nombre));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@APELLIDO", Apellido));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DIRECCION", Direccion));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@PROVINCIA", Provincia));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@DEPORTE", Deporte));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@Codigo", Codigo));
                    commandUpdate.ExecuteNonQuery();
                }
                MessageBox.Show("Actualizado con exito!!");
                coneccionBaseDatos.Close();
            }
            else
            {
                MessageBox.Show("Codigo invalido");
        }

    }
}
}
