using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_3eventos
{
    public partial class frmPrimcipal : Form
    {
        public frmPrimcipal()
        {
            InitializeComponent();
        }

        private void frmPrimcipal_Load(object sender, EventArgs e)
        {

        }


        private void perfilPersonaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Aplicattion.OpenForms (Coleccion de obajetos Form abiertos)

            foreach (var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya tiene una ventana de este tipo en ejecución.");
                    return;
                }
            }




            Form ventana = new Form1();
            //Metodo MdiParent pertmite establecer a ventana padre e hija
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
