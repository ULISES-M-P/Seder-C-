using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login.clases;
using MySql.Data.MySqlClient;

namespace login
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
           clases.registro mostrarReg = new clases.registro();
            mostrarReg.mostrarregistrosdgv(dgvRegistros);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string solicitante = txt_solicitante.Text;
            string localidad = txt_localidad.Text;
            string municipio = txt_municipio.Text;
            string domicilio = txt_domicilio.Text;
            string fecha = txt_fecha.Text;
            string ntelefono = txt_telefono.Text;

            clases.registro objetoagregar=new clases.registro();
            objetoagregar.registrar(txt_solicitante, txt_localidad, txt_municipio, txt_fecha, txt_telefono);
            objetoagregar.mostrarregistrosdgv(dgvRegistros);

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registro_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clases.registro objetomodif = new clases.registro();
            objetomodif.mostrarRegistros(dgvRegistros,txt_solicitante,txt_telefono);
            objetomodif.mostrarregistrosdgv(dgvRegistros);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clases.registro objetodelete = new clases.registro();
            objetodelete.deleteregistros(txt_solicitante);
            objetodelete.mostrarregistrosdgv(dgvRegistros);
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            clases.registro objetomodif = new clases.registro();
            objetomodif.modregistros(txt_solicitante, txt_telefono);
            objetomodif.mostrarregistrosdgv(dgvRegistros);
        }
    }

}