using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01_Mi_Primera_Vez.Presentacion.Personal;

namespace _01_Mi_Primera_Vez.Presentacion
{
    public partial class CUUsuario : UserControl
    {
        public CUUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personal.Frmpersonal frmpersonal = new Personal.Frmpersonal("n");
            frmpersonal.Text = "Nuevo Ingreso de Personal";
            frmpersonal.ShowDialog();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
          
            CUPersonal frmPrueba = new CUPersonal();
            this.Controls.Clear();
            frmPrueba.Show();
            this.Controls.Add(frmPrueba);
        }

        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
