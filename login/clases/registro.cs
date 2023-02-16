using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.clases
{
    internal class registro
    {
        public void registrar(TextBox solicitante, TextBox Localidad, TextBox Municipio, TextBox Fecha, TextBox N_telefono)
        {
            try
            {
                Cconexion objetoConexion = new Cconexion();
                string query= "insert into registro2 (solicitante,Localidad,Municipio,Fecha,N_telefono)"+ "values('" + solicitante.Text + "','" + Localidad.Text + "','" + Municipio.Text + "','" + Fecha.Text + "','" + N_telefono.Text + "')";
                MySqlCommand mycomand= new MySqlCommand(query,objetoConexion.establecerConexion());
                MySqlDataReader reader = mycomand.ExecuteReader();
                MessageBox.Show("se guardo el registro con exito");
                while(reader.Read()) { 
                objetoConexion.cerrarConexion();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("no se pudo guardar los datos, error:" + ex.ToString());
            }
        }

        public void mostrarregistrosdgv(DataGridView tablaaltas)
        {
            try
            {

                Cconexion cconexion = new Cconexion();
                string query = "select * from registro2";
                tablaaltas.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, cconexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaaltas.DataSource = dt;
                cconexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los Datos. error: " + ex.ToString());

            }
        }

        public void mostrarRegistros(DataGridView tablaregistro2, TextBox solicitante, TextBox N_telefono)
        {
            try
            {
                solicitante.Text = tablaregistro2.CurrentRow.Cells[0].Value.ToString();
                N_telefono.Text = tablaregistro2.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("no se modificaron los datos, error:" + ex.ToString());
            }
        }

        public void modregistros(TextBox solicitante, TextBox N_telefono)
        {
            try
            {
                Cconexion objetoConexion = new Cconexion();
                string query = "update registro2 set solicitante='" + solicitante.Text + "', N_telefono='" + N_telefono.Text  + "';";
                MySqlCommand mycomand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mycomand.ExecuteReader();
                MessageBox.Show("se modifico el registro con exito");
                while (reader.Read())
                {
                    objetoConexion.cerrarConexion();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("no se pudo modificar los datos, error:" + ex.ToString());
            }
        }

        public void deleteregistros(TextBox solicitante)
        {
            try
            {
                Cconexion objetoConexion = new Cconexion();
                string query = "delete from registro2 where solicitante='" + solicitante.Text+"';";
                MySqlCommand mycomand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mycomand.ExecuteReader();
                MessageBox.Show("se elimino el registro con exito");
                while (reader.Read())
                {
                    objetoConexion.cerrarConexion();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("no se pudo eliminar los datos, error:" + ex.ToString());
            }
        }
    }
}
