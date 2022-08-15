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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxSagas.Items.Add("Transformers");
            cbxSagas.Items.Add("Averngers");
            cbxSagas.Items.Add("Cars");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            Persona p1 = new Persona();
            p1.Nombre = txtbNombre.Text;

            p1.FechaNacimiento = dtpFechaNacimiento.Value;
            //Operador Ternario.
            p1.Mavel= cbxMavel.Checked == true ? "Le gustá Mavel" : "No le gustá Marvel.";

            if (rbThor.Checked)
            {
                p1.Heroe = "Thor";
            }
            else if (rbCap.Checked)
            {
                p1.Heroe = "Capitan America";
            }
            else
            {
                p1.Heroe = "Iron man";
            }

            p1.SagaFavorita = cbxSagas.Text;

            p1.Copas = nupCopas.Value.ToString();

            MessageBox.Show(p1.saludar());



        }

        
    }
}
