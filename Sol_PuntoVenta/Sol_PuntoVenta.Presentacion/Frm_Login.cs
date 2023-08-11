using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sol_PuntoVenta.Negocio;

namespace Sol_PuntoVenta.Presentacion
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }


        #region "Mis Metodos"
        public string NombreUsuario { get; set; }
        public bool Acceder_us(string cLogin_us, string cPassword_us)
        {
            try
            {
                DataTable TablaAcceder = new DataTable();
                TablaAcceder = N_Login.Acceder_us(cLogin_us, cPassword_us);
                return TablaAcceder.Rows.Count > 0; // Retorna true si las credenciales son correctas
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return false; // En caso de error, retorna false
            }
            #endregion
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pct_logo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Acceder_Click(object sender, EventArgs e)
        {
            bool credencialesCorrectas = this.Acceder_us(Txt_login_us.Text.Trim(), Txt_Password_us.Text.Trim());

            if (credencialesCorrectas)
            {
                NombreUsuario = Txt_login_us.Text.Trim();
                this.Hide();

                Frm_DashBoard frmDashboard = new Frm_DashBoard(NombreUsuario);
                frmDashboard.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Intente nuevamente.");
            }
        }

        private void Txt_login_us_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
