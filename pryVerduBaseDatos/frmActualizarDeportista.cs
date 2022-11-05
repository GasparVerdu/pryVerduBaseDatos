﻿using System;
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
    public partial class frmActualizarDeportista : Form
    {
        OleDbConnection coneccionBaseDatos = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb");
        OleDbCommand comandoBD = new OleDbCommand();
        //Como su nombre indica, Reader
        OleDbDataReader LectorBD;

        //var para no escribirlo tantas veces
        string RutaBDDeporte = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DEPORTE.accdb";
        public frmActualizarDeportista()
        {
            InitializeComponent();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            //desactiva el boton modificar
            btnModificar.Enabled = false;

            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtEdad.Enabled = false;
            cboDeporte.Enabled = false;

            if (txtCodigoDeportista.Text != "")
            {
                string Codigo = txtCodigoDeportista.Text;
                coneccionBaseDatos.Open();
                comandoBD.Connection = coneccionBaseDatos;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = "DEPORTISTA";

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
                    txtTelefono.Text = LectorBD.GetString(4);
                    txtEdad.Text = Convert.ToString(LectorBD.GetInt32(5));
                    cboDeporte.Text = LectorBD.GetString(6);
                }
                else
                {
                    MessageBox.Show("No existe el codigo ingresado");
                }
                //coneccionBaseDatos.Close();
                //btnModificar.Enabled = true;

                //txtApellido.Enabled = true;
                //txtNombre.Enabled = true;
                //txtDireccion.Enabled = true;
                //txtTelefono.Enabled = true;
                //txtEdad.Enabled = true;
                //cboDeporte.Enabled = true;
            }    
            //else
            //{
            //    MessageBox.Show("No existe el codigo ingresado");
            //}
            //coneccionBaseDatos.Close();

        }

        private void frmActualizarDeportista_Load(object sender, EventArgs e)
        {
            //conectar la base de datos 
            try
            {
                coneccionBaseDatos = new OleDbConnection(RutaBDDeporte);
                coneccionBaseDatos.Open();
                EstadoConeccionDepModificar.BackColor = Color.Green;
                ModificarDeportistasTool.Text = "Conectado correctamente" + " " + DateTime.Now;
            }
            catch (Exception mensajito)
            {
                EstadoConeccionDepModificar.Text = mensajito.Message;
                ModificarDeportistasTool.BackColor = Color.Red;
                //throw;
            }
            coneccionBaseDatos.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Codigo, Nombre, Apellido, Direccion, Deporte;

            int Telefono, Edad;

            Codigo = txtCodigoDeportista.Text;
            Nombre = txtNombre.Text;
            Apellido = txtApellido.Text;
            Direccion = txtDireccion.Text;
            Deporte = cboDeporte.Text;

            Telefono = Convert.ToInt32(txtTelefono.Text);
            Edad = Convert.ToInt32(txtEdad.Text);


        }
    }
}
