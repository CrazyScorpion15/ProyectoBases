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
        Conexion conexion = new Conexion();

        Dictionary<string, object> parametros = new Dictionary<string, object>();
        public Creacion()
        {
            InitializeComponent();

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
            TimeSpan DuracionPelicula = dtDuracionPelicula.Value.TimeOfDay;
            TimeSpan TiempoMinimo = TimeSpan.FromMinutes(1);
            TimeSpan TiempoMaximo = TimeSpan.FromHours(5);

            try
            {
                if (string.IsNullOrWhiteSpace(txtNombrePelicula.Text) || string.IsNullOrWhiteSpace(txtDescripcionPelicula.Text))
                {
                    MessageBox.Show("Error: Se necesita llenar toda la informacion");
                    return;
                }
                if (!(DuracionPelicula > TiempoMinimo && DuracionPelicula < TiempoMaximo))
                {
                    MessageBox.Show("Error: La duración de la película debe ser mayor a 1 minuto y menor a 5 horas");
                    return;
                }

                parametros.Clear();

                string NombrePelicula = txtNombrePelicula.Text;
                string ClasifiacionPelicula = cbClasificacionPelicula.Text;
                string Duracion = dtDuracionPelicula.Text;
                string Descripcion = txtDescripcionPelicula.Text;

                parametros.Add("@NOMBRE", NombrePelicula);
                parametros.Add("@NOMBRECLASIFICACION", ClasifiacionPelicula);
                parametros.Add("@DURACION", Duracion);
                parametros.Add("@DESCRIPCION", Descripcion);

                bool sp = conexion.EjecutarSP("SP_CREACIONPELICULA", parametros);

                if (sp)
                {
                    MessageBox.Show("Se creo correctamente la pelicula");
                    txtNombrePelicula.Text = "";
                    txtDescripcionPelicula.Text = "";
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la accion del boton");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {                
                DateTime fechaSeleccionada = dtFechaInicio.Value;

                if (fechaSeleccionada < DateTime.Now)
                {
                    MessageBox.Show("La fecha seleccionada no puede ser anterior al día de hoy.");
                    return;
                }

                parametros.Clear();

                string NombrePelicula = cbNombrePelicula.Text;
                string NombreSala = cbSala.Text;

                parametros.Add("@FECHAINICIO", fechaSeleccionada);
                parametros.Add("@NOMBRESALA", NombreSala);
                parametros.Add("@NOMBREPELICULA", NombrePelicula);

                bool sp = conexion.EjecutarSP("SP_CREARSESION", parametros);

                if (sp) {
                    MessageBox.Show("Se creo correctamente la sesion");                    
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error en la accion del boton");
            }
        }
    }
}
