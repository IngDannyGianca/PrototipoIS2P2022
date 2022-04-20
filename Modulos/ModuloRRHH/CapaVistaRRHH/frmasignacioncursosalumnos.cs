using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaRRHH
{
    public partial class frmasignacioncursosalumnos : Form
    {
        public frmasignacioncursosalumnos()
        {
            InitializeComponent();




			TextBox[] alias = navegador1.ClasificaTextboxsegunParent(this);
			navegador1.ObtenerCamposdeTabla(alias, "asignacioncursosalumnos", "hotelsancarlos");
			navegador1.MetodoSalirVista(this);
			navegador1.LlenarCombobox(comboBox1, "carreras", "carreras", "nombre_carrera", "estatus_carrera");
			navegador1.LlenarCombobox(comboBox2, "sedes", "codigo_sede", "nombre_sede", "estatus_sede");
			navegador1.LlenarCombobox(comboBox3, "jornadas", "codigo_jornada", "nombre_jornada", "estatus_jornada");
			navegador1.LlenarCombobox(comboBox4, "secciones", "codigo_seccion", "nombre_seccion", "estatus_seccion");
			navegador1.LlenarCombobox(comboBox5, "aulas", "codigo_aula", "nombre_aula", "estatus_aula");
			navegador1.LlenarCombobox(comboBox6, "cursos", "codigo_curso", "nombre_curso", "estatus_curso");
			navegador1.LlenarCombobox(comboBox7, "alumnos", "carnet_alumno", "nombre_alumno", "estatus_alumno");


			//inicio de elementos para dar de baja
			navegador1.campoEstado = "estatus";
			//fin de elementos para dar de baja

			/* Inicio ID Aplicacion usada para reportes y ayudas */
			navegador1.idAplicacion = "2018";
			navegador1.idmodulo = "2";
			/* Inicio ID Aplicacion usada para reportes y ayudas */

			//inicio de elementos para ejecutar la ayuda
			navegador1.tablaAyuda = "Aplicacion";
			navegador1.campoAyuda = "pkId";
			//fin de elementos para ejecutar la ayuda


			// Inicio datos para ejecurar reportes
			navegador1.LlamarRutaReporte("ruta", "idAplicacion", "Reporte");
			// Final datos para ejecutar reportes

			navegador1.ObtenerNombreDGV(this.dgvVistaPrevia);
			navegador1.LlenarTabla();
			navegador1.ObtenerReferenciaFormActual(this);
			//String cadena = txtprueba.Text;
			//navegador1.pruebaMensaje(cadena);
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			navegador1.EnviarDatoComboaTextbox(comboBox1, txt1);
		}
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			navegador1.EnviarDatoComboaTextbox(comboBox2, txt2);
		}
		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			navegador1.EnviarDatoComboaTextbox(comboBox3, txt3);
		}
		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{
			navegador1.EnviarDatoComboaTextbox(comboBox4, txt4);
		}
		private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
		{
			navegador1.EnviarDatoComboaTextbox(comboBox5, txt5);
		}
		private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
		{
			navegador1.EnviarDatoComboaTextbox(comboBox6, txt6);
		}
		private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
		{
			navegador1.EnviarDatoComboaTextbox(comboBox7, txt7);
		}






		private void txtEstado_TextChanged(object sender, EventArgs e)
		{
			navegador1.ActivaRadiobtn(rbnEstatusamodulo, rbnEstatusimodulo, textBox2);
		}

		private void rbnEstatusamodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.CambioEstadoTextbox(textBox2, rbnEstatusamodulo, "1");
		}

		private void rbnEstatusimodulo_CheckedChanged(object sender, EventArgs e)
		{
			navegador1.CambioEstadoTextbox(textBox2, rbnEstatusimodulo, "0");
		}

        private void frmasignacioncursosalumnos_Load(object sender, EventArgs e)
        {

        }
    }
}
