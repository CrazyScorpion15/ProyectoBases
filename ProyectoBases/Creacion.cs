using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBases
{
    public partial class Creacion : Form
    {        
        public Creacion()
        {
            InitializeComponent();

            //llamar sp para obtener los datos necesarios de las peliculas y salas
            Conexion conexion = new Conexion();

            Dictionary<string, object> parametros = new Dictionary<string, object>();

            parametros.Add("@BANDERA", "DATOSPELICULA");

            DataTable resultadoPelicula = conexion.EjecutarSPConResultado("SP_OBTENERDATOSVENTANAS", parametros);

            cbClasificacionPelicula.Items.Clear();
            cbNombrePelicula.Items.Clear();
            cbSala.Items.Clear();
            parametros.Clear();

            foreach (DataRow item in resultadoPelicula.Rows)
            {
                cbNombrePelicula.Items.Add(item["Nombre"].ToString());

                
                string clasificacion = item["TipoClasificacion"].ToString();
                if (!cbClasificacionPelicula.Items.Contains(clasificacion))
                {
                    cbClasificacionPelicula.Items.Add(clasificacion);
                }
            }

            parametros.Add("@BANDERA", "DATOSSALA");

            DataTable resultadoSala = conexion.EjecutarSPConResultado("SP_OBTENERDATOSVENTANAS", parametros);

            foreach (DataRow item in resultadoSala.Rows)
            {
                cbSala.Items.Add(item["Nombre"].ToString());
            }

            if (cbClasificacionPelicula.Items.Count > 0) cbClasificacionPelicula.SelectedIndex = 0;
            if (cbNombrePelicula.Items.Count > 0) cbNombrePelicula.SelectedIndex = 0;
            if (cbSala.Items.Count > 0) cbSala.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
