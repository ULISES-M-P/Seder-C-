using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace login
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicio f1 = new inicio();
            f1.CenterToScreen();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            registro re = new registro();
            re.Show();
        }

        private void ingreso_Click(object sender, EventArgs e)
        {
            string username, pass;
            username = nombre.Text;
            pass = contraseña.Text;
            MySqlConnection con = new MySqlConnection("server = 127.0.0.1; Database=usuarios_seder; User Id = root; password=admin");
            try
            {
                con.Open();
            }
            catch (MySqlException ex) { MessageBox.Show("Error " + ex.ToString()); }
            String sql = "select user,pass from users where user ='" + username + "' AND pass ='" + pass + "' ";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataReader read = comando.ExecuteReader();
            if (read.Read())
            {
                this.Hide();
                MessageBox.Show("Bienvenido " + username);
                this.Hide();
                registro rg = new registro();
                rg.Show();
            }
            else
            {
                MessageBox.Show("No existe el usuario " + username);
            }
        }


        private void nombre_Leave(object sender, EventArgs e)
        {
            if (nombre.Text == "")
            {
                nombre.Text = "Ingrese su usuario";
                nombre.ForeColor = Color.Black;
            }
        }

        private void nombre_Enter(object sender, EventArgs e)
        {
            if (nombre.Text == "Ingrese su usuario")
            {
                nombre.Text = "";
                nombre.ForeColor = Color.Black;
            }
        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void contraseña_Enter(object sender, EventArgs e)
        {
            if(contraseña.Text == "Ingrese la contraseña"){
                contraseña.Text = "";
                contraseña.ForeColor = Color.Black;
                contraseña.UseSystemPasswordChar = true;
                
            }
        }

        private void contraseña_Leave(object sender, EventArgs e)
        {
            if (contraseña.Text == "")
            {
                contraseña.Text = "Ingrese la contraseña";
                contraseña.ForeColor = Color.Black;
                contraseña.UseSystemPasswordChar = false;
            }
        }

        private void muestra_CheckedChanged(object sender, EventArgs e)
        {
            if(muestra.Checked==true)
            {
                contraseña.UseSystemPasswordChar = false;
            }
            else
            {
                contraseña.UseSystemPasswordChar = true;
            }
        }

        
    }
}
