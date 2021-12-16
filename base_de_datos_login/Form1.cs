using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base_de_datos_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection conexion = new SqlConnection("server=DESKTOP-5L3E30I ; database= Sistema ; INTEGRATED SECURITY = true");
        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT USUARIO, CONTRASEÑA FROM PERSONA WHERE USUARIO = @vusuario AND CONTRASEÑA = @vcontraseña", conexion);
            comando.Parameters.AddWithValue("@vusuario", textBox1.Text);
            comando.Parameters.AddWithValue("@vcontraseña", textBox2.Text);



            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read()) 
            {

                conexion.Close();
                Home pantalla = new Home();
                pantalla.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
