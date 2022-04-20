using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;
using static datosUsuario;

namespace CapaVistaRRHH
{
    public partial class frmMDIRRHH : Form
    {
        CapaControladorSeguridadHSC.Controlador bitacora = new CapaControladorSeguridadHSC.Controlador();
        public frmMDIRRHH()
        {
            InitializeComponent();
        }

        private void frmMDIRRHH_Load(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            {
                this.Close();
            }
        }

        private void cerrarSeciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtUsuario.Text = form.usuario();
            }
            else
            { this.Close(); }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCursos form3 = new frmCursos();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //frmCarreras form3 = new frmCarreras();
                //form3.MdiParent = this;
               //bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                //form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void tipoDeFaltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSecciones form3 = new frmSecciones();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSedes form3 = new frmSedes();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmMaestros form3 = new frmMaestros();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void conceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Conceptos form3 = new Conceptos();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void cuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFacultades form3 = new frmFacultades();
                form3.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form3.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAlumnos form = new frmAlumnos();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmJornada form = new frmJornada();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void conceptosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {
                frmMaestros form = new frmMaestros();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }

        }

        private void excepciToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmasignacioncursosmastros form = new frmasignacioncursosmastros();
            form.MdiParent = this;
            bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
            form.Show();

        }

        private void conceptosAEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmasignacioncursosalumnos form = new frmasignacioncursosalumnos();
            form.MdiParent = this;
            bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
            form.Show();
        }

        private void excepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAulas form = new frmAulas();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        private void seccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSecciones form = new frmSecciones();
                form.MdiParent = this;
                bitacora.guardarEnBitacora(IdUsuario, "1", "0002", "Entrada a la Vista");
                form.Show();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }
    }
    }
    
    

