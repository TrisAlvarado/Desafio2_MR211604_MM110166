using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio2_MR211604_MM110166
{
    public partial class Arco : Form
    {
        public bool control; // variable de control
        public int dato; // el dato que almacenará el vértice
        public Arco()
        {
            InitializeComponent();
            control = false;
            dato = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                dato = Convert.ToInt16(txtVertice.Text.Trim());

                if (dato < 0)
                {
                    MessageBox.Show("Debes ingresar un valor positivo", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                }
                else
                {
                    control = true;
                    Hide();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Debes ingresar un valor numérico");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            control = false;
            Hide();
        }

        private void Vertice_Load(object sender, EventArgs e)
        {
            txtVertice.Focus();
        }

        private void Vertice_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Vertice_Shown(object sender, EventArgs e)
        {
            txtVertice.Clear();
            txtVertice.Focus();
        }

        private void txtVertice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click(null, null);
            }
        }
    }
}
