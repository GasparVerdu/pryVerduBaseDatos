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
    public partial class frmInicio : Form
    {

        public OleDbConnection coneccionBaseDatos;
        //public OleDbCommand objdato;
        //public OleDbDataReader oblectura;

        public string RutaBaseDatos = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb";
        //public string RutaBaseDatos = "DEPORTE.accdb";
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            try
            {
                //si conecta que se ponga en verde
                coneccionBaseDatos = new OleDbConnection(RutaBaseDatos);
                coneccionBaseDatos.Open();
                toolStrip1.BackColor = Color.Green;
                toolStripLabel1.Text = "Coneccion concretada" + "" + DateTime.Now;
                
            }
            catch (Exception mensaje)
            {
                //si no conecta que se ponga rojo
                toolStripLabel1.Text = mensaje.Message;
                toolStrip1.BackColor = Color.Red;
                
            }
            coneccionBaseDatos.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void entrenadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarEntrenador frmAgregarEntrenador = new frmAgregarEntrenador();
            frmAgregarEntrenador.ShowDialog();
        }

        private void deportistasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgregarDeportista frmAgregarDeportista = new frmAgregarDeportista();
            frmAgregarDeportista.ShowDialog();
        }

        private void entrenadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaEntrenadores frmConsultaEntrenadores = new frmConsultaEntrenadores();
            frmConsultaEntrenadores.ShowDialog();
        }

        private void deportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDeportistas frmConsultaDeportistas = new frmConsultaDeportistas();
            frmConsultaDeportistas.ShowDialog();
        }

        private void enToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizarEntrenador frmActualizarEntrenador = new frmActualizarEntrenador();
            frmActualizarEntrenador.ShowDialog();
        }

        private void deportistasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmActualizarDeportista frmActualizarDeportista = new frmActualizarDeportista();
            frmActualizarDeportista.ShowDialog();
        }
    }
}
