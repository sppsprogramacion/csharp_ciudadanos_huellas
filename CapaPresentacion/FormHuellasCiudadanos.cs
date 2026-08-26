using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormHuellasCiudadanos : Form
    {
        private int idCiudadanoGlobal = 0;
        public FormHuellasCiudadanos(int idCiudadano)
        {
            InitializeComponent();

            idCiudadanoGlobal = idCiudadano;
        }

        private async void FormHuellasCiudadanos_Load(object sender, EventArgs e)
        {
            if(this.idCiudadanoGlobal == 0)
            {
                return;
            }

            NCiudadano nCiudadano = new NCiudadano();
            (DCiudadano dCiudadano, string errorResponse) = await nCiudadano.BuscarCiudadanoXID(idCiudadanoGlobal);

            if (dCiudadano == null)
            {
                MessageBox.Show(errorResponse, "Atención al Ciudadano", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtIdCiudadano.Text = dCiudadano.id_ciudadano.ToString();
            txtApellidoCivil.Text = dCiudadano.apellido.ToString();
            txtNombreCivil.Text = dCiudadano.nombre.ToString();
            txtDniCivil.Text = dCiudadano.dni.ToString();
            txtSexo.Text = dCiudadano.sexo.sexo.ToString();
            txtFechaNacimiento.Text = dCiudadano.fecha_nac.ToShortDateString();
            txtFechaAlta.Text = dCiudadano.fecha_alta.ToShortDateString();
            picFotoVisita.Load(dCiudadano.foto);

        }
    }
}
