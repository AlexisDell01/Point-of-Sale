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
        private void Acceder_us(string cLogin_us, string cPassword_us)
        {
            try
            {
                DataTable TablaAcceder = new DataTable();
                TablaAcceder = N_Login.Acceder_us(cLogin_us, cPassword_us);
                if (TablaAcceder.Rows.Count > 0) //Si tiene permiso para el uso del sistema
                {
                    Frm_DashBoard oFrm_DB = new Frm_DashBoard();
                    Frm_Login oFrm_LO = new Frm_Login();
                    oFrm_DB.Show();
                    oFrm_LO.Close();



                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecto",
                                     "Aviso del Sistema",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
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
            this.Acceder_us(Txt_login_us.Text.Trim(), Txt_Password_us.Text.Trim());
            this.Hide();
            
            

            
        }
    }
}
